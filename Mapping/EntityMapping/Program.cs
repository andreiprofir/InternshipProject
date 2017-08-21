using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityMapping
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (CinemaTickets cinema = new CinemaTickets())
            {
                Console.WriteLine(cinema.Entities.Count());

                Console.WriteLine(cinema.Genres.Count());

                //Genre genre = new Genre
                //{
                //    Entity = new Entity(),
                //    Name = "Genre1"
                //};

                //cinema.Genres.Add(genre);

                cinema.Genres.Remove(cinema.Genres.First());

                cinema.SaveChanges();

                Console.WriteLine(cinema.Entities.Count());

                Console.WriteLine(cinema.Genres.Count());
            }
        }
    }
}
