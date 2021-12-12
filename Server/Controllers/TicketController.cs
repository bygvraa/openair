using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenAir.Shared.Models;
using OpenAir.Server.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace OpenAir.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketController : ControllerBase
    {
        private readonly ITicketRepository _service;

        public TicketController(ITicketRepository service)
        {
            _service = service;
        }
        // GET: /<controller>/

        // GET: api/task
        // Bruger en metode ('GetAllTasks()') fra 'TaskRepository' til at retunere en liste over alle opgaver
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TicketClass>>> GetAll()
        {
            return await _service.GetAllTickets();
        }


        [HttpGet("{Id}")]
        public async Task<ActionResult<TicketClass>> Get(int Id)
        {
            var ticket = await _service.GetTicket(Id);

            if (ticket == null)
                return NotFound();

            return ticket;
        }
        //update IsBought 
        [HttpPut]
        public async Task<ActionResult<TicketClass>> Update(TicketClass ticket)
        {
            await _service.UpdateTicket(ticket);

            return ticket;
        }

    }
}
