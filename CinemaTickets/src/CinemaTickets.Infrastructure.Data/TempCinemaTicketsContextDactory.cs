using System.Reflection;
using CinemaTickets.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CinemaTickets.Infrastructure.Data
{
    public class TempCinemaTicketsContextDactory : IDesignTimeDbContextFactory<CinemaTicketsContext>
    {
        public CinemaTicketsContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<IdentityContext>();

            builder.UseSqlServer(
                "Data Source=DESKTOP-0PB30CN;Initial Catalog=CinemaTickets;Integrated Security=True;Connect Timeout=60;",
                op => op.MigrationsAssembly(typeof(CinemaTicketsContext).GetTypeInfo().Assembly.GetName().Name));

            return new CinemaTicketsContext(builder.Options);
        }
    }
}