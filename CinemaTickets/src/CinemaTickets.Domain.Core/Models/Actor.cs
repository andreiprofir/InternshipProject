using System.Collections.Generic;
using CinemaTickets.Domain.Core.Exceptions;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Actor
    {
        public Actor()
        {
            MovieActors = new HashSet<MovieActor>();
        }

        public long Id { get; set; }

        private const int MaxLength = 64;

        private string _firstName;

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (value.Length > MaxLength)
                    throw new StringTooLongException($"{nameof(FirstName)} is too long, max length is {MaxLength}.");

                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new StringTooShortException($"{nameof(FirstName)} is too short.");

                _firstName = value;
            }
        }

        private string _lastName;

        public string LastName
        {
            get => _lastName;
            set
            {
                if (value.Length > MaxLength)
                    throw new StringTooLongException($"{nameof(LastName)} is too long, max length is {MaxLength}.");

                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new StringTooShortException($"{nameof(LastName)} is too short.");

                _lastName = value;
            }
        }

        private ICollection<MovieActor> _movieActors;

        public ICollection<MovieActor> MovieActors
        {
            get => _movieActors;
            set
            {
                if (value == null)
                    throw new CollectionNullException($"{nameof(MovieActors)} is null.");

                _movieActors = value;
            }
        }
    }
}
