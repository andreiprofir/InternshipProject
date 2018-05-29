using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Interfaces;

namespace CinemaTickets.Infrastructure.Data.Repositories.Interfaces
{
    public interface ISessionPriceRepository : IRepository<SessionPrice>
    {
        decimal GetPrice(long movieSessionId, long seatTypeId);
    }
}