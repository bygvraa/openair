using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace OpenAir.Shared.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public override string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string Email { get; set; }
        public override string PasswordHash { get; set; }
        public DateTime BirthDate { get; set; }
        public string Skills { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }


        // Konstruktør
        public ApplicationUser()
        {
        }
        public ApplicationUser(string Id, string FirstName, string LastName, string Email, DateTime BirthDate, string Skills, DateTime Created)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.BirthDate = BirthDate;
            this.Skills = Skills;
            this.Created = Created;
        }


        // Metoder til Get
        public string GetFullName() { return $"{FirstName} {LastName}"; }
        public string GetEmail() { return Email; }
        public DateTime GetBirthDate() { return BirthDate; }
        public string GetSkills() { return Skills; }
        public DateTime GetCreated() { return Created; }
        public DateTime GetModified() { return Modified; }
    }
}