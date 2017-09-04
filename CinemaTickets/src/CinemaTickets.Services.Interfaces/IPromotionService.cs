using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.Promotion;

namespace CinemaTickets.Services.Interfaces
{
    public interface IPromotionService
    {
        PromotionFullInfoDto GetPromotionById(long promotionId);

        List<PromotionForListDto> GetAllValidIn(long cityId);
    }
}