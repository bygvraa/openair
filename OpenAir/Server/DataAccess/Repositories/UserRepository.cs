using OpenAir.Shared.Models;
using OpenAir.Server.DataAccess.Contexts;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OpenAir.Server.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DomainDbContext _dBContext;

        public UserRepository(DomainDbContext _db)
        {
            _dBContext = _db;
        }


        // Brugere -----------------------------------------

        // GET    - find alle brugere
        public async Task<List<UserClass>> GetUsers()
        {
            return await _dBContext.user.ToListAsync();
        }

        // GET    - find specifik bruger
        public async Task<UserClass> GetSingleUser(string id)
        {
            return await _dBContext.user.FirstAsync(t => t.id == id);
        }

        // POST   - lav en bruger
        public async Task CreateUser(UserClass user)
        {
            await _dBContext.user.AddAsync(user);
            await _dBContext.SaveChangesAsync();
        }

        // PUT    - opdater en bruger
        public async Task UpdateUser(UserClass user)
        {
            _dBContext.user.Update(user);
            await _dBContext.SaveChangesAsync();
        }

        // DELETE - fjern en bruger
        public async Task DeleteUser(string id)
        {
            var entity = await _dBContext.user.FirstAsync(t => t.id == id);
            _dBContext.user.Remove(entity);
            await _dBContext.SaveChangesAsync();
        }

        // -------------------------------------------------
    }
}