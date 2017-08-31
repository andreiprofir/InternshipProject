using System;
using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.Customer;

namespace CinemaTickets.Domain.Dtos.Comment
{
    public class CommentInforForMovieDto
    {
        public long Id { get; set; }

        public DateTimeOffset Date { get; set; }

        public int Likes { get; set; }

        public string Text { get; set; }

        public CommentInforForMovieDto AnswerTo { get; set; }

        public string CommentType { get; set; }

        public CustomerInfoForCommentDto Customer { get; set; }
    }
}