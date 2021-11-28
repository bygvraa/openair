using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OpenAir.Shared.Models
{
    public class UserClass
    {
        [Key]
        public string id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int? role { get; set; }
        public DateTime created { get; set; }


        public UserClass() { }

        public UserClass(string id, string first_name, string last_name, string email, string password, int role)
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.password = password;
            this.role = role;
        }

        public UserClass(string first_name, string last_name, string email, string password, int role = 0)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.password = password;
            this.role = role;
        }

        public string GetFullName()
        {
            return $"{first_name} {last_name}";
        }

        public DateTime GetCreated()
        {
            return created;
        }

    }
}