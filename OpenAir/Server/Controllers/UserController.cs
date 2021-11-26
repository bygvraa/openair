using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenAir.Shared.Models;
using OpenAir.Server.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace OpenAir.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IDataAccessProvider _service;

        public UserController(IDataAccessProvider service)
        {
            _service = service;
        }

        // GET: api/user
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserClass>>> Get()
        {
            return await _service.GetUsers();
        }

        // GET: api/user/5
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
        [HttpPut]
        public async Task<ActionResult<UserClass>> Edit([FromBody] UserClass user)
        {
            if (ModelState.IsValid)
            {
                await _service.UpdateUser(user);
            }

            return user;
        }

        // DELETE: api/Account/5
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
