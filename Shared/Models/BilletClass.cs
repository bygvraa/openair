using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace OpenAir.Shared.Models
{
    public class BilletClass
    {
        [Key]
        public int billet_id { get; set; }
        public string billet { get; set; }
        public int pris { get; set; }
        public DateTime dato { get; set; }
    }
}
