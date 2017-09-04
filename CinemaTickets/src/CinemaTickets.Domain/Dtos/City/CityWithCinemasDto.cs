using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.Cinema;

namespace CinemaTickets.Domain.Dtos.City
{
    public class CityWithCinemasDto
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public List<CinemaNameAndAddressDto> Cinemas { get; set; }
    }
}