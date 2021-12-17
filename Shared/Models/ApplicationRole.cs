using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace OpenAir.Shared.Models
{
    public class ApplicationRole : IdentityRole
    {
        [Key]
        public override string Id { get; set; }
        public override string Name { get; set; }
        public string Description { get; set; }


        // Konstruktør
        public ApplicationRole() : base()
        {
        }
        public ApplicationRole(string roleName) : base(roleName)
        {
        }

    }
}
