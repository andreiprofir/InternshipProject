using System.Linq;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Infrastructure.Data.Interfaces;
using CinemaTickets.Infrastructure.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CinemaTickets.Infrastructure.Data.Repositories
{
    public class SessionPriceRepository : Repository<SessionPrice>, ISessionPriceRepository
    {
        public SessionPriceRepository(DbContext context, 
            IQuerySpecificationBuilder<SessionPrice> queryBuilder) : base(context, queryBuilder)
        {
        }

        public decimal GetPrice(long movieSessionId, long seatTypeId)
        {
            return CreateQuery()
                .Where(x => x.MovieSessionId == movieSessionId && x.SeatTypeId == seatTypeId)
                .Select(x => x.Price)
                .FirstOrDefault();
        }
    }
}