﻿using Microsoft.AspNetCore.Authorization;
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


        // Find navnet på en bruger
        [HttpGet]
        public async Task<string> GetName(ApplicationUser user)
        {
            return await userManager.GetUserNameAsync(user);
        }


        // Find alle roller for en specifik bruger
        [HttpGet("{id}")]
        public async Task<List<string>> GetUserRoles(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            var roles = await userManager.GetRolesAsync(user);

            var roleList = roles.ToList();

            return roleList;
        }


        // Find alle brugere i en specifik rolle
        [HttpGet("UserRole/{role}")]
        public async Task<List<ApplicationUser>> GetUsersInRole(string role)
        {
            var users = await userManager.GetUsersInRoleAsync(role);
            var userList = users.ToList();

            return userList;
        }


        // Tilføj en bruger til en rolle
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


        // Fjern en bruger fra en rolle
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
