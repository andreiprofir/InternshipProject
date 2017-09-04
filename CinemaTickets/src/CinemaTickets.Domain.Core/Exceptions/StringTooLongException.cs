using System;

namespace CinemaTickets.Domain.Core.Exceptions
{
    public class StringTooLongException : Exception
    {
        public StringTooLongException(string message) : base(message)
        {
        }
    }
}