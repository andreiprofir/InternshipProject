using System;

namespace CinemaTickets.Domain.Core.Exceptions
{
    public class StringTooShortException : Exception
    {
        public StringTooShortException(string message) : base(message)
        {
            
        }
    }
}