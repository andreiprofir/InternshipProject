using CinemaTickets.Domain.Core.Models;

namespace CinemaTickets.Domain.Dtos
{
    public class SeatDto
    {
        public long Id { get; set; }

        public int RowNumber { get; set; }

        public int ColumnNumber { get; set; }

        public string SeatType { get; set; }
    }
}