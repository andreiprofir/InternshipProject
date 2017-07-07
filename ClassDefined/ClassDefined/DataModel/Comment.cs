using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDefined.DataModel
{
    public class Comment
    {
        public long Id
        {
            get => default(int);
            set
            {
            }
        }

        public User Author
        {
            get => new User();
            set
            {
            }
        }

        public DateTimeOffset Date
        {
            get => DateTimeOffset.Now;
            set
            {
            }
        }

        public int? Likes
        {
            get => default(int);
            set
            {
            }
        }

        public Comment Link
        {
            get => new Comment();
            set
            {
            }
        }

        public string Text
        {
            get => default(string);
            set
            {
            }
        }

        public CommentType Type
        {
            get => default(int);
            set
            {
            }
        }
    }
}