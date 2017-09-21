using System;
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

        public List<ActorDto> MovieActors { get; set; }

        public List<CountryDto> MovieCountries { get; set; }

        public List<DirectorDto> MovieDirectors { get; set; }

        public List<GenreSampleInfoDto> MovieGenres { get; set; }

        public List<LanguageDto> MovieLanguages { get; set; }

        public List<WriterDto> MovieWriters { get; set; }
    }
}