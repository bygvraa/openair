using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAir.Shared.Models
{
    class ApplicationShift
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Person { get; set; }
        public string Location { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
    }
}
