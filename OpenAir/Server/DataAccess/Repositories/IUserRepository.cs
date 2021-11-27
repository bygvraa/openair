using OpenAir.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace OpenAir.Server.DataAccess.Repositories
{
    public interface IUserRepository
    {
        Task<List<UserClass>> GetUsers();
        Task<UserClass> GetSingleUser(string id);
        Task CreateUser(UserClass user);
        Task UpdateUser(UserClass user);
        Task DeleteUser(string id);
    }
}