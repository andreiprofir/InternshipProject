using CinemaTickets.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(e => e.FirstName).HasMaxLength(64);

            builder.Property(e => e.LastName).HasMaxLength(64);
        }
    }
}