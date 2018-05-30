using System.Collections.Generic;
using System.Linq;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Infrastructure.Data.Interfaces;
using CinemaTickets.Infrastructure.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CinemaTickets.Infrastructure.Data.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(DbContext context, IQuerySpecificationBuilder<Order> queryBuilder) : base(context, queryBuilder)
        {
        }

        public List<Order> GetAllBy(long customerId)
        {
            return CreateQuery()
                .Where(x => x.CustomerId == customerId)
                .Include(x => x.MovieSession)
                    .ThenInclude(x => x.Movie)
                .Include(x => x.Seat)
                    .ThenInclude(x => x.SeatType)
                .ToList();
        }
    }
}