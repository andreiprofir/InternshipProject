using System.Collections.Generic;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Interfaces;

namespace CinemaTickets.Infrastructure.Data.Repositories.Interfaces
{
    public interface ICityRepository : IRepository<City>
    {
        List<City> GetAllCitiesAndIncludeCinamas(params ISpecification<City>[] specifications);
    }
}