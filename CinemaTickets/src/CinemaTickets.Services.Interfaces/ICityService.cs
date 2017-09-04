using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.City;

namespace CinemaTickets.Services.Interfaces
{
    public interface ICityService
    {
        List<CityWithCinemasDto> GetAllCitiesWithCinemas();
    }
}