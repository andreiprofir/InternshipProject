using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CinemaTickets.Domain.Dtos.Cinema;
using CinemaTickets.Services.Application.ViewModels.Cinema;
using CinemaTickets.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CinemaTickets.Web.Controllers
{
    [Route("[controller]")]
    public class CinemaController : Controller
    {
        private IMapper _mapper;
        private ICinemaService _cinemaService;

        public CinemaController(IMapper mapper, ICinemaService cinemaService)
        {
            _mapper = mapper;
            _cinemaService = cinemaService;
        }

        [Route("/cinemas")]
        public IActionResult Index()
        {
            List<CinemaForListDto> source = _cinemaService.GetAllByCityId();

            List<CinemaForListViewModel> model = _mapper.Map<List<CinemaForListViewModel>>(source);

            return View(model);
        }
    }
}