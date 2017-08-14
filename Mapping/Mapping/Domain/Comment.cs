using System;
using System.Collections.Generic;

namespace ConsoleApp1.Domain
{
    public class Comment : BaseEntity
    {
        public virtual User User { get; set; }

        public virtual DateTimeOffset Date { get; set; }

        public virtual int Likes { get; set; }
        
        public virtual string Text { get; set; }

        public virtual Entity Entity { get; set; }
        
        public virtual IList<Comment> Answers { get; set; }

        public virtual Comment AnswerTo { get; set; }

        public virtual CommentType CommentType { get; set; }
    }
}
