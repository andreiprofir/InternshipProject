using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CinemaTickets.Domain.Dtos.Genre;
using CinemaTickets.Domain.Dtos.Movie;
using CinemaTickets.Services.Application.ViewModels.Genre;
using CinemaTickets.Services.Application.ViewModels.Movie;
using CinemaTickets.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CinemaTickets.Web.Controllers
{
    [Route("[controller]")]
    public class GenreController : Controller
    {
        private IMapper _mapper;
        private IGenreService _genreService;
        private IMovieService _movieService;

        public GenreController(IMapper mapper, IGenreService genreService, IMovieService movieService)
        {
            _mapper = mapper;
            _genreService = genreService;
            _movieService = movieService;
        }

        [Route("/genres")]
        public IActionResult Index()
        {
            List<GenreBaseInfoDto> source = _genreService.GetAll();

            List<GenreForListOfGenresViewModel> model = _mapper.Map<List<GenreForListOfGenresViewModel>>(source);

            return View(model);
        }

        [Route("{id}")]
        public IActionResult Get(long id)
        {
            GenreBaseInfoDto source = _genreService.GetBaseInfoById(id);
            List<MovieInGenreDto> movieSource = _movieService.GetMoviesByGenre(id);

            GenreViewModel model = _mapper.Map<GenreViewModel>(source);
            model.Movies = _mapper.Map<List<MovieInGenreViewModel>>(movieSource);

            return View(model);
        }
    }
}