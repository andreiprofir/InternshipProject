using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDefined.DataModel
{
    public class Session
    {
        public long Id
        {
            get => default(int);
            set
            {
            }
        }

        public Movie Movie
        {
            get => null;
            set
            {
            }
        }

        public Hall Hall
        {
            get => null;
            set
            {
            }
        }

        public DateTimeOffset Time
        {
            get => DateTimeOffset.Now;
            set
            {
            }
        }

        public decimal Prices
        {
            get => default(int);
            set
            {
            }
        }
    }
}