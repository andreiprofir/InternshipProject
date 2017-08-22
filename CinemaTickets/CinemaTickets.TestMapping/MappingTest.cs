

using System;
using System.Linq;
using CinemaTickets.Infrastructure.Data.Context;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CinemaTickets.TestMapping
{
    [TestClass]
    public class MappingTest
    {
        [TestMethod]
        public void TestContext()
        {
            using (var context = new CinemaTicketsContext())
            {
                Console.WriteLine(context.Genres.Count());
            }
        }
    }
}
