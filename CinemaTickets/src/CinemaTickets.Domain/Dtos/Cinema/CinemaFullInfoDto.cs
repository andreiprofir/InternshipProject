using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.Comment;
using CinemaTickets.Domain.Dtos.Movie;
using CinemaTickets.Domain.Dtos.MovieSession;
using CinemaTickets.Domain.Dtos.Picture;

namespace CinemaTickets.Domain.Dtos.Cinema
{
    public class CinemaFullInfoDto
    {
        public long Id { get; set; }

        public string ShortName { get; set; }

        public string FullName { get; set; }

        public string Street { get; set; }

        public string ContactPhone { get; set; }

        public string Info { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }

        public string CityName { get; set; }

        public List<PictureSampleDto> Pictures { get; set; }

        public List<MovieInfoForCinemaSessionsDto> MovieSessions { get; set; }

        public List<CommentInfoDto> Comments { get; set; }
    }
}