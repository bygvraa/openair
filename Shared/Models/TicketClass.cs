using System;
using System.ComponentModel.DataAnnotations;


namespace OpenAir.Shared.Models
{
    public class TicketClass
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Amount { get; set; }
        public string Email { get; set; }


        // Konstruktør
        public TicketClass()
        {

        }
        public TicketClass(int Id, string Title, int Amount, string Email)
        {
            this.Id = Id;
            this.Title = Title;
            this.Amount = Amount;
            this.Email = Email;

        }
    }
}
