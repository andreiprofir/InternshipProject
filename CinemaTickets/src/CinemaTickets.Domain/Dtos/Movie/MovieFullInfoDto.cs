using System;
using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.Cinema;
using CinemaTickets.Domain.Dtos.Comment;
using CinemaTickets.Domain.Dtos.Genre;
using CinemaTickets.Domain.Dtos.MovieSession;
using CinemaTickets.Domain.Dtos.Picture;

namespace CinemaTickets.Domain.Dtos.Movie
{
    public class MovieFullInfoDto
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

        public PictureSampleDto Poster { get; set; }
        
        public List<string> Actors { get; set; }
        
        public List<string> Countries { get; set; }

        public List<string> Directors { get; set; }
        
        public List<string> Languages { get; set; }

        public List<string> Writers { get; set; }

        public List<GenreSampleInfoDto> Genres { get; set; }
        
        public List<CommentInforForMovieDto> Comments { get; set; }
        
        public List<MovieSessionForMovieDto> MovieSessions { get; set; }
    }
}