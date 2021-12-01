using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpenAir.Server.Models
{
    public class ApplicationRole : IdentityRole
    {
        public int role_access { get; set; }
        public string role_name { get; set; }
    }
}
