using OpenAir.Shared.Models;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace OpenAir.Server.DataAccess
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly DomainDbContext _context;
        private readonly ILogger _logger;

        public DataAccessProvider(DomainDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("DataAccessProvider");
        }


        // Users

        // GET (find) alle brugere
        public async Task<List<UserClass>> GetUsers()
        {
            return await _context.user.ToListAsync();
        }

        // GET (find) specifik bruger
        public async Task<UserClass> GetSingleUser(string id)
        {
            return await _context.user.FirstAsync(t => t.id == id);
        }

        // POST (lav) en bruger
        public async Task CreateUser(UserClass user)
        {
            _context.user.Add(user);
            await _context.SaveChangesAsync();
        }

        // PUT (opdater) en bruger
        public async Task UpdateUser(UserClass user)
        {
            _context.user.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
