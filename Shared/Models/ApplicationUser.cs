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
        public int? Role { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        // Metoder
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public DateTime GetCreated()
        {
            return Created;
        }

        public DateTime GetModified()
        {
            return Modified;
        }
    }
}