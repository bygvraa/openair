using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenAir.Shared.Models;
using OpenAir.Server.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace OpenAir.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _service;

        public UserController(IUserRepository service)
        {
            _service = service;
        }

        // GET: api/user
        // Bruger en metode ('GetUsers()') fra 'UserRepository' til at retunere en liste over alle brugere
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserClass>>> Get()
        {
            return await _service.GetUsers();
        }

        // GET: api/user/5
        // Tager id'et på en bestemt bruger og retunerer alle oplysninger på brugeren
        [HttpGet("{id}")]
        public async Task<ActionResult<UserClass>> Details(string id)
        {
            var userClass = await _service.GetSingleUser(id);

            if (userClass == null)
            {
                return NotFound();
            }

            return userClass;
        }

        // POST: api/user
        // Laver en ny bruger med et unikt id (guid)
        [HttpPost]
        public async Task<ActionResult<UserClass>> Create([FromBody] UserClass user)
        {
            if (ModelState.IsValid)
            {
                user.id = Guid.NewGuid().ToString();
                await _service.CreateUser(user);
            }

            return user;
        }

        // PUT: api/user
        // Tager en bruger som argument og retunerer alle brugerens oplysninger
        [HttpPut]
        public async Task<ActionResult<UserClass>> Edit([FromBody] UserClass user)
        {
            if (ModelState.IsValid)
            {
                await _service.UpdateUser(user);
            }

            return user;
        }

        // DELETE: api/user/5
        // Tager et id som argument og fjerner den tilhørende bruger
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            if (ModelState.IsValid)
            {
                await _service.DeleteUser(id);
            }

            return NoContent();
        }

    }
}
