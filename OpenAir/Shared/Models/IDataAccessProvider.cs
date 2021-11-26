using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAir.Shared.Models
{
    public interface IDataAccessProvider
    {
        Task<List<UserClass>> GetUsers();
        Task CreateUser(UserClass user);
        Task UpdateUser(UserClass user);
    }
}
