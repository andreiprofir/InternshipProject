using System;
using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.Cinema;
using CinemaTickets.Services.Interfaces;

namespace CinemaTickets.Infrastructure.Business.Services
{
    public class CinemaService : ICinemaService
    {
        public List<CinemaSampleWithMovieSessionsDto> Get()
        {
            throw new NotImplementedException();
        }
    }
}