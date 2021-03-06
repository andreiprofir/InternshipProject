﻿using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class CommentType
    {
        public CommentType()
        {
            Comments = new HashSet<Comment>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
