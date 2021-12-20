using System;
using System.Threading.Tasks;


namespace OpenAir.Shared.Models
{
    // Bruges på administrator-siden til at tildele en User en bestemt Role
    public class UserRoleClass
    {
        public ApplicationUser User { get; set; }
        public string Role { get; set; }
    }
}
