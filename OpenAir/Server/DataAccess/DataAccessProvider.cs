using OpenAir.Shared.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace OpenAir.Server.DataAccess
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly DomainDbContext _dBContext;

        public DataAccessProvider(DomainDbContext _db)
        {
            _dBContext = _db;
        }


        // Brugere

        // GET (find) alle brugere
        public async Task<List<UserClass>> GetUsers()
        {
            return await _dBContext.user.ToListAsync();
        }

        // GET (find) specifik bruger
        public async Task<UserClass> GetSingleUser(string id)
        {
            return await _dBContext.user.FirstAsync(t => t.id == id);
        }

        // POST (lav) en bruger
        public async Task CreateUser(UserClass user)
        {
            await _dBContext.user.AddAsync(user);
            await _dBContext.SaveChangesAsync();
        }

        // PUT (opdater) en bruger
        public async Task UpdateUser(UserClass user)
        {
            _dBContext.user.Update(user);
            await _dBContext.SaveChangesAsync();
        }

        public async Task DeleteUser(string id)
        {
            var entity = await _dBContext.user.FirstAsync(t => t.id == id);
            _dBContext.user.Remove(entity);
            await _dBContext.SaveChangesAsync();
        }
    }
}
