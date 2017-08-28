using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CinemaTickets.Domain.Interfaces
{
    public interface ISpecification<TEntity> 
        where TEntity : class
    {
    }
}