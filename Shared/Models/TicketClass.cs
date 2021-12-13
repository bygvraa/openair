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
        public int Price { get; set; }

        public TicketClass() { }
        public TicketClass(int Id, string Title, int Price)
        {
            this.Id = Id;
            this.Title = Title;
            this.Price = Price;
        }
    }
}
