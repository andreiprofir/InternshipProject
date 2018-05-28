using System;
using System.Collections.Generic;
using System.ComponentModel;
using CinemaTickets.Services.Application.ViewModels.Comment;
using CinemaTickets.Services.Application.ViewModels.Genre;
using CinemaTickets.Services.Application.ViewModels.MovieSession;
using CinemaTickets.Services.Application.ViewModels.Picture;

namespace CinemaTickets.Services.Application.ViewModels.Movie
{
    public class MovieInfoViewModel
    {
        public long Id { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Original name")]
        public string OriginalName { get; set; }

        public string Trailer { get; set; }

        [DisplayName("Length")]
        public int Duration { get; set; }

        [DisplayName("Release date")]
        public DateTimeOffset ReleaseDate { get; set; }

        [DisplayName("Age limit")]
        public int AgeLimit { get; set; }

        [DisplayName("IMDB rating")]
        public string ImdbRaiting { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }

        public PictureSampleViewModel Poster { get; set; }

        [DisplayName("Actors")]
        public List<string> Actors { get; set; }

        [DisplayName("Countries")]
        public List<string> Countries { get; set; }

        [DisplayName("Directors")]
        public List<string> Directors { get; set; }

        [DisplayName("Lannguages")]
        public List<string> Languages { get; set; }

        [DisplayName("Writers")]
        public List<string> Writers { get; set; }

        [DisplayName("Genres")]
        public List<GenreSampleViewModel> Genres { get; set; }

        public List<CommentInfoViewModel> Comments { get; set; }

        public List<MovieSessionForMovieViewModel> MovieSessions { get; set; }
    }
}