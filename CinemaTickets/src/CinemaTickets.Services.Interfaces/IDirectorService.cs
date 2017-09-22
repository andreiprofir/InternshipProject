using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.Director;

namespace CinemaTickets.Services.Interfaces
{
    public interface IDirectorService
    {
        List<DirectorDto> GetAll();
    }
}