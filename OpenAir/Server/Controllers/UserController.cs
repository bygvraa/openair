using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenAir.Shared.Models;
using OpenAir.Server.DataAccess;

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

        //// GET: api/Account/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<AccountClass>> GetAccountClass(int id)
        //{
        //    var accountClass = await _service.account.FindAsync(id);

        //    if (accountClass == null)
        //    {
        //        return NotFound();
        //    }

        //    return accountClass;
        //}

        // POST: api/user
        [HttpPost]
        public async Task<ActionResult<UserClass>> Create([FromBody] UserClass user)
        {
            Guid obj = Guid.NewGuid();
            user.id = obj.ToString();
            await _service.CreateUser(user);

            return user;
        }

        //// PUT: api/Account/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutAccountClass(int id, AccountClass accountClass)
        //{
        //    if (id != accountClass.account_id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(accountClass).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AccountClassExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// DELETE: api/Account/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteAccountClass(int id)
        //{
        //    var accountClass = await _context.account.FindAsync(id);
        //    if (accountClass == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.account.Remove(accountClass);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool AccountClassExists(int id)
        //{
        //    return _context.account.Any(e => e.account_id == id);
        //}
    }
}
