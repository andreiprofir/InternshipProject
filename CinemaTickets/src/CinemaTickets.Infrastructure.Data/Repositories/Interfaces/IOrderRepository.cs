using System.Collections.Generic;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Interfaces;

namespace CinemaTickets.Infrastructure.Data.Repositories.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        List<Order> GetAllBy(long customerId);
    }
}