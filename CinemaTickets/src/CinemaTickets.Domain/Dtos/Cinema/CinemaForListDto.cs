using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.City;
using CinemaTickets.Domain.Dtos.Picture;

namespace CinemaTickets.Domain.Dtos.Cinema
{
    public class CinemaForListDto
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public List<string> Formats { get; set; }

        public PictureSampleDto Poster { get; set; }

        public CitySampleDto City { get; set; }
    }
}