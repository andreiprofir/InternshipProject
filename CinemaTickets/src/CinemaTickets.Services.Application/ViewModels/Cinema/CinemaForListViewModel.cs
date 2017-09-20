using System.Collections.Generic;
using CinemaTickets.Services.Application.ViewModels.City;
using CinemaTickets.Services.Application.ViewModels.Picture;

namespace CinemaTickets.Services.Application.ViewModels.Cinema
{
    public class CinemaForListViewModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public List<string> Formats { get; set; }

        public PictureSampleViewModel Poster { get; set; }

        public CitySampleViewModel City { get; set; }
    }
}