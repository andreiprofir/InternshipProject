using System.Collections.Generic;
using System.Linq.Expressions;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Interfaces;
using Microsoft.EntityFrameworkCore.Query;

namespace CinemaTickets.Infrastructure.Data.Repositories.Interfaces
{
    public interface ICinemaRepository : IRepository<Cinema>
    {
        List<Cinema> GetAllIncludeCityAndHallsAndPictures(params ISpecification<Cinema>[] specifications);

        Cinema GetByIdWithFullInfo(params ISpecification<Cinema>[] specifications);
    }
}