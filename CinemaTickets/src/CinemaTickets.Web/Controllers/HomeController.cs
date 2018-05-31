using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CinemaTickets.Domain.Dtos.Movie;
using CinemaTickets.Services.Application.ViewModels.Movie;
using CinemaTickets.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using CinemaTickets.Web.Models;

namespace CinemaTickets.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IMovieService _movieService;

        public HomeController(IMapper mapper, IMovieService movieService)
        {
            _mapper = mapper;
            _movieService = movieService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<MovieInfoForListOfPostersDto> source = _movieService.GetAllMoviesForPoster(71);

            var model = _mapper.Map<List<MovieForPosterViewModel>>(source);

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "The application to buy tickets";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Andrei Profir Contact Page";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
