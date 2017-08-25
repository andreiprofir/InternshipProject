using System;
using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Comment
    {
        public Comment()
        {
            InverseAnswerTo = new HashSet<Comment>();
        }

        public long Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public int Likes { get; set; }
        public string Text { get; set; }
        public long UserId { get; set; }
        public long EntityId { get; set; }
        public long? AnswerToId { get; set; }
        public long? CommentTypeId { get; set; }

        public Comment AnswerTo { get; set; }
        public CommentType CommentType { get; set; }
        public Entity Entity { get; set; }
        public User User { get; set; }
        public ICollection<Comment> InverseAnswerTo { get; set; }
    }
}
