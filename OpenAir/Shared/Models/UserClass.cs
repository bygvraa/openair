using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAir.Shared.Models
{
    public class UserClass
    {
        [Key]
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int? role { get; set; }
        public DateTime created { get; set; }

        public UserClass() { }

        public UserClass(string id, string name, string email, string password, int role)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.role = role;
        }

        public UserClass(string name, string email, string password, int role = 0)
        { 
            this.name = name;
            this.email = email;
            this.password = password;
            this.role = role;
        }
    }
}