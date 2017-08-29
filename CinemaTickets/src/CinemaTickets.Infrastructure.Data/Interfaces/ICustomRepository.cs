using System.Linq;
using CinemaTickets.Domain.Interfaces;

namespace CinemaTickets.Infrastructure.Data.Interfaces
{
    public interface ICustomRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Query();
    }
}