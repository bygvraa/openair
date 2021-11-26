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
        public async Task<List<UserClass>> GetUsers()
        {
            return await _context.user.ToListAsync();
        }

        public async Task CreateUser(UserClass user)
        {
            _context.user.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUser(UserClass user)
        {
            _context.user.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
