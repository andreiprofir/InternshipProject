﻿using System;
using System.Collections.Generic;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Actor;
using CinemaTickets.Domain.Dtos.Country;
using CinemaTickets.Domain.Dtos.Director;
using CinemaTickets.Domain.Dtos.Genre;
using CinemaTickets.Domain.Dtos.Language;
using CinemaTickets.Domain.Dtos.Writer;

namespace CinemaTickets.Domain.Dtos.Movie
{
    public class MovieDto
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string OriginalName { get; set; }

        public string Trailer { get; set; }

        public int Duration { get; set; }

        public DateTimeOffset ReleaseDate { get; set; }

        public int AgeLimit { get; set; }

        public string ImdbRaiting { get; set; }

        public string Description { get; set; }

        //public Entity Entity { get; set; }

        public List<long> MovieActors { get; set; }

        public List<long> MovieCountries { get; set; }

        public List<long> MovieDirectors { get; set; }

        public List<long> MovieGenres { get; set; }

        public List<long> MovieLanguages { get; set; }

        public List<long> MovieWriters { get; set; }
    }
}