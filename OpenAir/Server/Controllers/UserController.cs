using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenAir.Shared.Models;
using OpenAir.Server.Data.Repositories;
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
        // Bruger en metode ('GetAllUsers()') fra 'UserRepository' til at retunere en liste over alle brugere
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserClass>>> GetAll()
        {
            return await _service.GetAllUsers();
        }

        // GET: api/user/5
        // Tager id'et på en bestemt bruger og retunerer alle oplysninger på brugeren
        [HttpGet("{id}")]
        public async Task<ActionResult<UserClass>> Get(string id)
        {
            var user = await _service.GetUser(id);

            if (user == null)
                return NotFound();

            return user;
        }

        // POST: api/user
        // Laver en ny bruger med et unikt id (guid)
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] UserClass user)
        {
            if (ModelState.IsValid)
                user.id = Guid.NewGuid().ToString();
                await _service.CreateUser(user);

            return Ok();
        }

        // PUT: api/user
        // Tager en bruger som argument og retunerer alle brugerens oplysninger
        [HttpPut]
        public async Task<ActionResult<UserClass>> Update([FromBody] UserClass user)
        {
            if (ModelState.IsValid)
                await _service.UpdateUser(user);

            return user;
        }

        // DELETE: api/user/5
        // Tager et id som argument og fjerner den tilhørende bruger
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            if (ModelState.IsValid)
                await _service.DeleteUser(id);

            return Ok();
        }

    }
}
