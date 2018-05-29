using System.Collections.Generic;
using System.Linq;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Infrastructure.Data.Concrete.Specifications;
using CinemaTickets.Infrastructure.Data.Repositories.Interfaces;
using CinemaTickets.Services.Interfaces;

namespace CinemaTickets.Infrastructure.Business.Services
{
    public class SeatService : ISeatService
    {
        private readonly IMovieSessionRepository _movieSessionRepository;

        public SeatService(IMovieSessionRepository movieSessionRepository)
        {
            _movieSessionRepository = movieSessionRepository;
        }

        public List<SeatDto> GetAllBy(long movieSessionId)
        {
            List<Seat> seats = _movieSessionRepository.GetAllSeatsBy(movieSessionId);

            return seats.Select(x => new SeatDto
            {
                Id = x.Id,
                SeatType = x.SeatType?.Name ?? "sample",
                ColumnNumber = x.ColumnNumber,
                RowNumber = x.RowNumber
            }).ToList();
        }
    }
}