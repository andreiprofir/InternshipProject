using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Language
    {
        public Language()
        {
            MovieLanguages = new HashSet<MovieLanguage>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<MovieLanguage> MovieLanguages { get; set; }
    }
}
