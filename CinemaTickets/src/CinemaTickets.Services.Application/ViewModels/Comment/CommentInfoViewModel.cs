using System;
using CinemaTickets.Services.Application.ViewModels.Customer;

namespace CinemaTickets.Services.Application.ViewModels.Comment
{
    public class CommentInfoViewModel
    {
        public long Id { get; set; }

        public DateTimeOffset Date { get; set; }

        public int Likes { get; set; }

        public string Text { get; set; }

        public CommentInfoViewModel AnswerTo { get; set; }

        public string CommentType { get; set; }

        public CustomerInfoForCommentViewModel Customer { get; set; }
    }
}