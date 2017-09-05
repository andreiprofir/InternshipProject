using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.Cinema;

namespace CinemaTickets.Services.Interfaces
{
    public interface ICinemaService
    {
        List<CinemaForListDto> GetAllByCityId(long? cityId = null);

        CinemaFullInfoDto GetById(long cinemaId);
    }
}