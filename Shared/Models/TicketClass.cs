using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OpenAir.Shared.Models
{
    public class TicketClass
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Amount { get; set; }
        public string Email { get; set; }


        public TicketClass() { }
        public TicketClass(int Id, string Title, int Amount, string Email)
        {
            this.Id = Id;
            this.Title = Title;
            this.Amount = Amount;
            this.Email = Email;

        }
    }
}
