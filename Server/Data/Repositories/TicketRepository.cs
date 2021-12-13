using OpenAir.Shared.Models;
using OpenAir.Server.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace OpenAir.Server.Data.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly ApplicationDbContext _dBContext;

        public TicketRepository(ApplicationDbContext dBContext)
        {
            _dBContext = dBContext;
        }


        // Task -----------------------------------------

        // GET    - find alle opgaver
        public async Task<List<TicketClass>> GetAllTickets()
        {
            return await _dBContext.ticket.ToListAsync();
        }

        // GET    - find specifik opgaver
        public async Task<TicketClass> GetTicket(int Id)
        {
            return await _dBContext.ticket.FindAsync(Id);
        }

        // POST   - lav en ticket
        public async Task CreateTicket(TicketClass ticket)
        {
            await _dBContext.ticket.AddAsync(ticket);
            await _dBContext.SaveChangesAsync();
        }

        // PUT    - opdater en opgave
        public async Task UpdateTicket(TicketClass ticket)
        {
            _dBContext.ticket.Update(ticket);
            await _dBContext.SaveChangesAsync();
        }

        // DELETE - fjern en opgave
        public async Task DeleteTicket(int Id)
        {
            var ticketToDelete = await _dBContext.ticket.FindAsync(Id);

            if (ticketToDelete == null)
                throw new NullReferenceException();

            _dBContext.ticket.Remove(ticketToDelete);
            await _dBContext.SaveChangesAsync();
        }

        // -------------------------------------------------
    }
}
