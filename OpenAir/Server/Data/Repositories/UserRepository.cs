using OpenAir.Shared.Models;
using OpenAir.Server.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace OpenAir.Server.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dBContext;

        public UserRepository(ApplicationDbContext dBContext)
        {
            _dBContext = dBContext;
        }


        // Brugere -----------------------------------------

        // GET    - find alle brugere
        public async Task<List<UserClass>> GetAllUsers()
        {
            return await _dBContext.user.ToListAsync();
        }

        // GET    - find specifik bruger
        public async Task<UserClass> GetUser(string id)
        {
            return await _dBContext.user.FindAsync(id);
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
            var userToUpdate = await _dBContext.user.FindAsync(user.id);

            if (userToUpdate == null)
                throw new NullReferenceException();

            _dBContext.user.Update(user);
            await _dBContext.SaveChangesAsync();
        }

        // DELETE - fjern en bruger
        public async Task DeleteUser(string id)
        {
            var userToDelete = await _dBContext.user.FindAsync(id);

            if (userToDelete == null)
                throw new NullReferenceException();

            _dBContext.user.Remove(userToDelete);
            await _dBContext.SaveChangesAsync();
        }

        // -------------------------------------------------
    }
}