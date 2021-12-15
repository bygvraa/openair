using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenAir.Shared.Models;

namespace OpenAir.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;

        public AdminController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }


        [HttpGet("{id}")]
        public async Task<List<string>> GetUserRoles(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            var roles = await userManager.GetRolesAsync(user);

            var roleList = roles.ToList();

            return roleList;
        }


        [HttpGet("UserRole/{role}")]
        public async Task<List<ApplicationUser>> GetUsersInRole(string role)
        {
            var users = await userManager.GetUsersInRoleAsync(role);
            var userList = users.ToList();

            return userList;
        }


        [HttpPut]
        public async Task AddRoleToUser([FromBody] UserRoleClass userRole)
        {
            if (ModelState.IsValid)
            {
                var currentUser = await userManager.FindByIdAsync(userRole.User.Id);

                var user = currentUser;
                var role = userRole.Role;
            
                await userManager.AddToRoleAsync(user, role);
            }
        }



        [HttpDelete("{id}/{role}")]
        public async Task RemoveRoleFromUser(string id, string role)
        {
            if (ModelState.IsValid)
            {
                var currentUser = await userManager.FindByIdAsync(id);

                var user = currentUser;

                await userManager.RemoveFromRoleAsync(user, role);
            }
        }
    }
}
