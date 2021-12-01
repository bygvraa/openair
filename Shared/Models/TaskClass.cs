using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OpenAir.Shared.Models
{
    public class TaskClass
    {
            [Key]
            public int task_id { get; set; }
            public string description { get; set; }
            public string volunteer { get; set; }
            public string location { get; set; }
            public DateTime starttime { get; set; }
            public DateTime stoptime { get; set; }


        public TaskClass(int task_id, string description, string volunteer, string location, DateTime starttime, DateTime stoptime)
        {
            this.task_id = task_id;
            this.description = description;
            this.volunteer = volunteer;
            this.location = location;
            this.starttime = starttime;
            this.stoptime = stoptime;
        }
    }
}
