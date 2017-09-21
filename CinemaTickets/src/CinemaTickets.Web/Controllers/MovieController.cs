using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CinemaTickets.Domain.Dtos.Movie;
using CinemaTickets.Infrastructure.Data.Repositories.Interfaces;
using CinemaTickets.Services.Application.ViewModels.Movie;
using CinemaTickets.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CinemaTickets.Web.Controllers
{
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private IMapper _mapper;
        private IMovieService _movieService;

        public MovieController(IMapper mapper, IMovieService movieService)
        {
            _mapper = mapper;
            _movieService = movieService;
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult Display(long id)
        {
            MovieFullInfoDto source = _movieService.GetFullInfoOfMovieById(id);

            MovieInfoViewModel movie = _mapper.Map<MovieInfoViewModel>(source);

            return View(movie);
        }

        [Route("/movies")]
        [HttpGet]
        public IActionResult Index()
        {
            //aici de afisat toate filmele in forma cum le afisez in categorii
            return null;
        }
        
        [Authorize(Roles = "admin, moderator")]
        [Route("/create")]
        [HttpGet]
        public IActionResult Create()
        {
            var movie = new MovieViewModel();
            
            return View(movie);
        }

        [Authorize(Roles = "admin, moderator")]
        [Route("/create")]
        [HttpPost]
        public IActionResult Create(MovieViewModel movie)
        {
            if (!ModelState.IsValid)
                return View(movie);
            //salvarea datelor trebuie sa fie in service si in repositoriu
            return RedirectToAction("Index");
        }
    }
}