using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Promotion;
using CinemaTickets.Infrastructure.Data.Concrete.Specifications;
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

        public List<PromotionForListDto> GetAllValidIn(long cityId)
        {
            List<Promotion> source = _promotionRepository.GetAllWithIncludePicturesAndCinemas(
                Specification.Where<Promotion>(p => p.CinemaPromotions.Any(cp => cp.Cinema.CityId == cityId)),
                Specification.Where<Promotion>(p => p.ValidTo == null || p.ValidTo > DateTimeOffset.Now));

            List<PromotionForListDto> result = _mapper.Map<List<PromotionForListDto>>(source);

            return result;
        }
    }
}