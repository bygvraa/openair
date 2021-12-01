using OpenAir.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace OpenAir.Server.Data.Repositories
{
    public interface IUserRepository
    {
        Task<List<UserClass>> GetAllUsers();
        Task<UserClass> GetUser(string id);
        Task CreateUser(UserClass user);
        Task UpdateUser(UserClass user);
        Task DeleteUser(string id);
    }
}