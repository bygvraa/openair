using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenAir.Shared.Models;

namespace OpenAir.Server.DataAccess
{
    public interface IDataAccessProvider
    {
        Task<List<UserClass>> GetUsers();
        Task<UserClass> GetSingleUser(string id);
        Task CreateUser(UserClass user);
        Task UpdateUser(UserClass user);
        Task DeleteUser(string id);
    }
}
