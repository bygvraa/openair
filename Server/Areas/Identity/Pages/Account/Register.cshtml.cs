using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using OpenAir.Shared.Models;

namespace OpenAir.Server.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Indtast et fornavn")]
            [StringLength(100, ErrorMessage = "Fornavnet skal være på mellem {2} og {1} bogstaver.", MinimumLength = 1)]
            [Display(Name = "Fornavn")]
            public string FirstName { get; set; }

            [Required(ErrorMessage = "Indtast et efternavn")]
            [StringLength(100, ErrorMessage = "Efternavnet skal være på mellem {2} og {1} bogstaver.", MinimumLength = 1)]
            [Display(Name = "Efternavn")]
            public string LastName { get; set; }

            [Required(ErrorMessage = "Indtast en fødselsdato")]
            [DataType(DataType.Date)]
            [Display(Name = "Fødselsdato")]
            public DateTime BirthDate { get; set; }

            [Required(ErrorMessage = "Indtast en mailadresse")]
            [EmailAddress]
            [Display(Name = "Mailadresse")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Indtast en adgangskode")]
            [StringLength(100, ErrorMessage = "Adgangskoden skal være på mellem {2} og {1} tegn.", MinimumLength = 1)]
            [DataType(DataType.Password)]
            [Display(Name = "Adgangskode")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Bekræft adgangskode")]
            [Compare("Password", ErrorMessage = "Adgangskoderne er ikke ens.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser {
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,
                    BirthDate = Input.BirthDate,
                    UserName = Input.Email, 
                    Email = Input.Email, 
                    Created = DateTime.UtcNow,
                    Modified = DateTime.UtcNow
                };

                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    await _userManager.AddToRoleAsync(user, "Bruger");
                    await _userManager.AddClaimAsync(user, new Claim("given_name", user.FirstName));


                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
