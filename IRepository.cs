using System;
using System.Collections.Generic;
using CinemaTickets.Core.Domain;

namespace CinemaTickets.Core.Interfaces
{
    public interface IRepository<T>
        where T : Entity
    {
        IEnumerable<T> GetAll();

        T Get(long id);

        IEnumerable<T> Find(Func<T, bool> predicate);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Delete(long id);
    }
}