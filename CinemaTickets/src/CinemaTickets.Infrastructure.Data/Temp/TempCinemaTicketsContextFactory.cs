using System.IO;
using CinemaTickets.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CinemaTickets.Infrastructure.Data.Temp
{
    public class TempCinemaTicketsContextFactory : IDesignTimeDbContextFactory<CinemaTicketsContext>
    {
        public CinemaTicketsContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory());

            builder.AddJsonFile("appsettings.json");

            IConfigurationRoot config = builder.Build();

            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<CinemaTicketsContext>();
            DbContextOptions<CinemaTicketsContext> options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            return new CinemaTicketsContext(options);
        }
    }
}