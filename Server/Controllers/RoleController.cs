using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OpenAir.Shared.Models;

namespace OpenAir.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoleController : ControllerBase
    {
        private readonly RoleManager<ApplicationRole> roleManager;


        public RoleController(RoleManager<ApplicationRole> roleManager)
        {
            this.roleManager = roleManager;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicationRole>>> GetAll()
        {
            return await roleManager.Roles.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationRole>> Get(string id)
        {
            var role = await roleManager.FindByIdAsync(id);

            if (role == null)
                return NotFound();

            return role;
        }


        [HttpPost]
        public async Task<ActionResult> Create([FromBody] ApplicationRole role)
        {
            if (ModelState.IsValid)
                role.Id = Guid.NewGuid().ToString();
                await roleManager.CreateAsync(role);

            return Ok();
        }


        [HttpPut]
        public async Task<ActionResult<ApplicationRole>> Update([FromBody] ApplicationRole role)
        {
            if (ModelState.IsValid)
            {
                var currentRole = await roleManager.FindByIdAsync(role.Id);

                currentRole.Name = role.Name;
                currentRole.Description = role.Description;

                await roleManager.UpdateAsync(currentRole);
            }

            return role;
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            var _role = await roleManager.FindByIdAsync(id);

            if (_role == null)
                return NotFound();

            if (ModelState.IsValid)
                await roleManager.DeleteAsync(_role);

            return Ok();
        }

    }
}
