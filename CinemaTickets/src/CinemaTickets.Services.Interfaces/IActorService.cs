using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.Actor;

namespace CinemaTickets.Services.Interfaces
{
    public interface IActorService
    {
        List<ActorDto> GetAll();
    }
}