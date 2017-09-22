using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.Writer;

namespace CinemaTickets.Services.Interfaces
{
    public interface IWriterService
    {
        List<WriterDto> GetAll();
    }
}