using System;
using CinemaTickets.Core.Domain;

namespace CinemaTickets.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Movie> Movies { get; }

        IRepository<Cinema> Cinemas { get; }

        IRepository<User> Users { get; }

        IRepository<Promotion> Promotions { get; }

        IRepository<Order> Orders { get; }

        void Save();
    }
}