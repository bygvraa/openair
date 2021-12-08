using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO;
using OpenAir.Shared;
using Microsoft.Extensions.Logging;
using OpenAir.Shared.Models;

namespace OpenAir.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<TicketClass> Get()
        {
            using (StreamReader r = new StreamReader("/tickets.json"))
            {
                string json = r.ReadToEnd();
                List<TicketClass> items = JsonConvert.DeserializeObject<List<TicketClass>>(json);
                return items;
            }
        }
    }
}

