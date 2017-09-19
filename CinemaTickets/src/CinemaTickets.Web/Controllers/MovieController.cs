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
        public IActionResult Display(long id)
        {
            MovieFullInfoDto source = _movieService.GetFullInfoOfMovieById(id);

            MovieViewModel movie = _mapper.Map<MovieViewModel>(source);

            return View(movie);
        }
    }
}