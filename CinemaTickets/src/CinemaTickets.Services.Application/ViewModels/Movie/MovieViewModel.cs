using System;
using System.Collections.Generic;
using CinemaTickets.Services.Application.ViewModels.Comment;
using CinemaTickets.Services.Application.ViewModels.Genre;
using CinemaTickets.Services.Application.ViewModels.MovieSession;
using CinemaTickets.Services.Application.ViewModels.Picture;

namespace CinemaTickets.Services.Application.ViewModels.Movie
{
    public class MovieViewModel
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

        public int Likes { get; set; }

        public int Dislikes { get; set; }

        public PictureSampleViewModel Poster { get; set; }

        public List<string> Actors { get; set; }

        public List<string> Countries { get; set; }

        public List<string> Directors { get; set; }

        public List<string> Languages { get; set; }

        public List<string> Writers { get; set; }

        public List<GenreSampleViewModel> Genres { get; set; }

        public List<CommentInfoViewModel> Comments { get; set; }

        public List<MovieSessionForMovieViewModel> MovieSessions { get; set; }
    }
}