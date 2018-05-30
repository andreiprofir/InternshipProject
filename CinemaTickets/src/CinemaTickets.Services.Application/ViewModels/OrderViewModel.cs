namespace CinemaTickets.Services.Application.ViewModels
{
    public class OrderViewModel
    {
        public long MovieId { get; set; }

        public string MovieTitle { get; set; }

        public string Identifier { get; set; }

        public int RowNumber { get; set; }

        public int ColumnNumber { get; set; }

        public string SeatType { get; set; }
    }
}