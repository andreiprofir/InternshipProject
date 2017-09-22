using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.Language;

namespace CinemaTickets.Services.Interfaces
{
    public interface ILanguageService
    {
        List<LanguageDto> GetAll();
    }
}