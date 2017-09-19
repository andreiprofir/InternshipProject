using System;
using System.Collections.Generic;
using System.ComponentModel;
using CinemaTickets.Services.Application.ViewModels.Comment;
using CinemaTickets.Services.Application.ViewModels.Genre;
using CinemaTickets.Services.Application.ViewModels.MovieSession;
using CinemaTickets.Services.Application.ViewModels.Picture;

namespace CinemaTickets.Services.Application.ViewModels.Movie
{
    public class MovieViewModel
    {
        public long Id { get; set; }

        [DisplayName("Имя")]
        public string Name { get; set; }

        [DisplayName("Оригинальное название")]
        public string OriginalName { get; set; }

        public string Trailer { get; set; }

        [DisplayName("Длительность")]
        public int Duration { get; set; }

        [DisplayName("Дата выхода")]
        public DateTimeOffset ReleaseDate { get; set; }

        [DisplayName("Возраст")]
        public int AgeLimit { get; set; }

        [DisplayName("IMDB рейтинг")]
        public string ImdbRaiting { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }

        public PictureSampleViewModel Poster { get; set; }

        [DisplayName("Актёры")]
        public List<string> Actors { get; set; }

        [DisplayName("Производство")]
        public List<string> Countries { get; set; }

        [DisplayName("Режиссёр")]
        public List<string> Directors { get; set; }

        [DisplayName("Язык")]
        public List<string> Languages { get; set; }

        [DisplayName("Сценарий")]
        public List<string> Writers { get; set; }

        [DisplayName("Жанр")]
        public List<GenreSampleViewModel> Genres { get; set; }

        public List<CommentInfoViewModel> Comments { get; set; }

        public List<MovieSessionForMovieViewModel> MovieSessions { get; set; }
    }
}