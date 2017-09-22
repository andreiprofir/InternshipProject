using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.Country;

namespace CinemaTickets.Services.Interfaces
{
    public interface ICountryService
    {
        List<CountryDto> GetAll();
    }
}