using System;
using System.Collections.Generic;

namespace EntityMapping
{
    public partial class Comment
    {
        public Comment()
        {
            Answers = new HashSet<Comment>();
        }

        public long Id { get; set; }

        public DateTimeOffset Date { get; set; }

        public int Likes { get; set; }

        public string Text { get; set; }

        public long UserId { get; set; }

        public long EntityId { get; set; }

        public long? AnswerToId { get; set; }

        public long? CommentTypeId { get; set; }

        public virtual ICollection<Comment> Answers { get; set; }

        public virtual Comment AnswerTo { get; set; }

        public virtual CommentType CommentType { get; set; }

        public virtual Entity Entity { get; set; }

        public virtual User User { get; set; }
    }
}
