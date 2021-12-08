using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpenAir.Shared.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public override string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public int? Role { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public ApplicationUser() { }
        public ApplicationUser(string Id, string FirstName, string LastName, string Email, string Password, DateTime Birthday, int? Role, DateTime Created)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Password = Password;
            this.Birthday = Birthday;
            this.Role = Role;
            this.Created = Created;
        }



        // Metoder
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public DateTime GetCreated()
        {
            return Created;
        }
    }

}