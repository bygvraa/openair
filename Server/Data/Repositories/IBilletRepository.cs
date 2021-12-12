using OpenAir.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenAir.Server.Data.Repositories
{
    public interface IBilletRepository
    {
        Task <List<TicketClass>> GetAllTickets();
        Task <TicketClass> GetTicket(int Id);
        Task CreateTicket(TicketClass ticket);
        Task UpdateTicket(TicketClass ticket);
        Task DeleteTicket(int Id);
    }
}
