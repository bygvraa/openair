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
   
    [Route("[controller]")]
    public class TicketController : ControllerBase
    {
        private readonly ITicketRepository _service;

        public TicketController(ITicketRepository service)
        {
            _service = service;
        }


        // Finder alle tickets og retunerer dem som en liste
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TicketClass>>> GetAll()
        {
            return await _service.GetAllTickets();
        }

        // Find en bestemt ticket
        [HttpGet("{Id}")]
        public async Task<ActionResult<TicketClass>> Get(int Id)
        {
            var ticket = await _service.GetTicket(Id);

            if (ticket == null)
                return NotFound();

            return ticket;
        }


        // Lav en ticket
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] TicketClass ticket)
        {
            await _service.CreateTicket(ticket);

            return Ok();
        }

    }
}
