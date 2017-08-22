using System.Data.Entity.ModelConfiguration;
using CinemaTickets.Domain.Core.Models;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class CommentTypeMap : EntityTypeConfiguration<CommentType>
    {
        public CommentTypeMap()
        {

        }
    }
}