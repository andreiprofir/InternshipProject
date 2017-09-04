using System.Collections.Generic;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Interfaces;

namespace CinemaTickets.Infrastructure.Data.Repositories.Interfaces
{
    public interface IPromotionRepository : IRepository<Promotion>
    {
        Promotion GetByIdWithIncludes(long promotionId);
    }
}