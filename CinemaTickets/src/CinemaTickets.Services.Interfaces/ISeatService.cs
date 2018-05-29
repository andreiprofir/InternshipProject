using System.Collections.Generic;
using CinemaTickets.Domain.Dtos;

namespace CinemaTickets.Services.Interfaces
{
    public interface ISeatService
    {
        List<SeatDto> GetAllBy(long movieSessionId);
    }
}