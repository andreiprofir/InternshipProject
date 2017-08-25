using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Country
    {
        public Country()
        {
            MovieCountries = new HashSet<MovieCountry>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<MovieCountry> MovieCountries { get; set; }
    }
}
