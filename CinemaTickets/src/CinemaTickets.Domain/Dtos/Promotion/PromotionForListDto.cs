using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.Cinema;
using CinemaTickets.Domain.Dtos.Picture;

namespace CinemaTickets.Domain.Dtos.Promotion
{
    public class PromotionForListDto
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public PictureSampleDto Poster { get; set; }

        public List<CinemaSampleDto> Cinemas { get; set; }
    }
}