using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OpenAir.Shared.Models;

namespace OpenAir.Server.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [Display(Name = "Brugernavn/mailadresse")]
        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [StringLength(100, ErrorMessage = "Fornavnet skal være på mellem {2} og {1} bogstaver.", MinimumLength = 1)]
            [Display(Name = "Fornavn")]
            public string FirstName { get; set; }

            [StringLength(100, ErrorMessage = "Efternavnet skal være på mellem {2} og {1} bogstaver.", MinimumLength = 1)]
            [Display(Name = "Efternavn")]
            public string LastName { get; set; }

            [DataType(DataType.Date)]
            [Display(Name = "Fødselsdato")]
            public DateTime BirthDate { get; set; }

            //[Phone]
            //[Display(Name = "Telefonnummer")]
            //public string PhoneNumber { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            //var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            Username = userName;
            var firstName = user.FirstName;
            var lastName = user.LastName;
            var birthDate = user.BirthDate;

            Input = new InputModel
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate,
                //PhoneNumber = phoneNumber
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }


            if (Input.FirstName != user.FirstName)
            {
                // Opdater claim "given_name" (fornavn)
                string oldName = user.FirstName;

                var claimOld = new Claim("given_name", oldName);
                var claimNew = new Claim("given_name", Input.FirstName);

                var setClaimResult = await _userManager.ReplaceClaimAsync(user, claimOld, claimNew);

                if (setClaimResult.Succeeded)
                {
                    // Opdater selve fornavnet
                    user.FirstName = Input.FirstName;
                    await _userManager.UpdateAsync(user);
                }
            }

            if (Input.LastName != user.LastName)
            {
                user.LastName = Input.LastName;
                await _userManager.UpdateAsync(user);
            }

            if (Input.BirthDate != user.BirthDate)
            {
                user.BirthDate = Input.BirthDate;
                await _userManager.UpdateAsync(user);
            }

            //var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            //if (Input.PhoneNumber != phoneNumber)
            //{
            //    var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
            //    if (!setPhoneResult.Succeeded)
            //    {
            //        StatusMessage = "Unexpected error when trying to set phone number.";
            //        return RedirectToPage();
            //    }
            //}

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Din profil er blevet opdateret";
            return RedirectToPage();
        }
    }
}
