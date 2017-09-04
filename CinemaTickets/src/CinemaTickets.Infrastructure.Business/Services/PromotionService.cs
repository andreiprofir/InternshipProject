using AutoMapper;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Promotion;
using CinemaTickets.Infrastructure.Data.Repositories.Interfaces;
using CinemaTickets.Services.Interfaces;

namespace CinemaTickets.Infrastructure.Business.Services
{
    public class PromotionService : IPromotionService
    {
        private readonly IPromotionRepository _promotionRepository;
        private readonly IMapper _mapper;

        public PromotionService(IPromotionRepository promotionRepository, IMapper mapper)
        {
            _promotionRepository = promotionRepository;
            _mapper = mapper;
        }

        public PromotionFullInfoDto GetPromotionById(long promotionId)
        {
            Promotion source = _promotionRepository.GetByIdWithIncludes(promotionId);

            PromotionFullInfoDto result = _mapper.Map<PromotionFullInfoDto>(source);

            return result;
        }
    }
}