using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAir.Shared.Models
{
    public class ApplicationTask
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string User { get; set; }
        public string Location { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
