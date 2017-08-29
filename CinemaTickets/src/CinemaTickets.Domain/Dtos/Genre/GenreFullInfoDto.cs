using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.Picture;

namespace CinemaTickets.Domain.Dtos.Genre
{
    public class GenreFullInfoDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<PictureDto> Pictures { get; set; }
    }
}