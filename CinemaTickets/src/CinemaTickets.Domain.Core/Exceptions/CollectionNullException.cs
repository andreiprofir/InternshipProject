using System;

namespace CinemaTickets.Domain.Core.Exceptions
{
    public class CollectionNullException : Exception
    {
        public CollectionNullException(string message) : base(message)
        {
            
        }
    }
}