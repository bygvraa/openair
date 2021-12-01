using OpenAir.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace OpenAir.Server.Data.Repositories
{
    public interface IUserRepository
    {
        Task<List<ApplicationUser>> GetAllUsers();
        Task<ApplicationUser> GetUser(string id);
        Task CreateUser(ApplicationUser user);
        Task UpdateUser(ApplicationUser user);
        Task DeleteUser(string id);
    }
}