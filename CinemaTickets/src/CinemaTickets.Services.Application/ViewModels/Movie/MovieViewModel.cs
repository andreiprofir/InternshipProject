using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CinemaTickets.Services.Application.ViewModels.Actor;
using CinemaTickets.Services.Application.ViewModels.Country;
using CinemaTickets.Services.Application.ViewModels.Director;
using CinemaTickets.Services.Application.ViewModels.Genre;
using CinemaTickets.Services.Application.ViewModels.Language;

namespace CinemaTickets.Services.Application.ViewModels.Movie
{
    public class MovieViewModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string OriginalName { get; set; }

        public string Trailer { get; set; }

        public int Duration { get; set; }

        [DataType(DataType.Date)]
        public DateTimeOffset ReleaseDate { get; set; }

        public int AgeLimit { get; set; }

        public string ImdbRaiting { get; set; }

        public string Description { get; set; }

        public List<long> MovieActors { get; set; }

        public List<long> MovieCountries { get; set; }

        public List<long> MovieDirectors { get; set; }

        public List<long> MovieGenres { get; set; }

        public List<long> MovieLanguages { get; set; }

        public List<long> MovieWriters { get; set; }
    }
}