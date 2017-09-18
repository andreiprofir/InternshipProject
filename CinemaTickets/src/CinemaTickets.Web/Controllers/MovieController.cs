using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CinemaTickets.Domain.Dtos.Movie;
using CinemaTickets.Infrastructure.Data.Repositories.Interfaces;
using CinemaTickets.Services.Application.ViewModels.Movie;
using CinemaTickets.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CinemaTickets.Web.Controllers
{
    public class MovieController : Controller
    {
        private IMapper _mapper;
        private IMovieService _movieService;

        public MovieController(IMapper mapper, IMovieService movieService)
        {
            _mapper = mapper;
            _movieService = movieService;
        }

        [Route("movie/{movieId}")]
        public IActionResult Display(long movieId)
        {
            MovieFullInfoDto source = _movieService.GetFullInfoOfMovieById(movieId);

            MovieViewModel movie = _mapper.Map<MovieViewModel>(source);

            return View(movie);
        }
    }
}