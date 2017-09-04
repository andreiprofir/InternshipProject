using System;
using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.Cinema;
using CinemaTickets.Domain.Dtos.Movie;
using CinemaTickets.Domain.Dtos.Picture;

namespace CinemaTickets.Domain.Dtos.Promotion
{
    public class PromotionFullInfoDto
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string DescriptionOfRules { get; set; }

        public DateTimeOffset? ValidFrom { get; set; }

        public DateTimeOffset? ValidTo { get; set; }
        
        public PictureSampleDto Poster { get; set; }

        public List<CinemaForPromotionDto> CinemaPromotions { get; set; }

        public List<MovieBaseInfoDto> MoviePromotions { get; set; }
    }
}