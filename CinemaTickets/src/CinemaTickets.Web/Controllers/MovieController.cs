using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CinemaTickets.Domain.Dtos;
using CinemaTickets.Domain.Dtos.Actor;
using CinemaTickets.Domain.Dtos.Country;
using CinemaTickets.Domain.Dtos.Director;
using CinemaTickets.Domain.Dtos.Genre;
using CinemaTickets.Domain.Dtos.Language;
using CinemaTickets.Domain.Dtos.Movie;
using CinemaTickets.Domain.Dtos.Writer;
using CinemaTickets.Infrastructure.Data.Repositories.Interfaces;
using CinemaTickets.Services.Application.ViewModels;
using CinemaTickets.Services.Application.ViewModels.Actor;
using CinemaTickets.Services.Application.ViewModels.Country;
using CinemaTickets.Services.Application.ViewModels.Director;
using CinemaTickets.Services.Application.ViewModels.Genre;
using CinemaTickets.Services.Application.ViewModels.Language;
using CinemaTickets.Services.Application.ViewModels.Movie;
using CinemaTickets.Services.Interfaces;
using CinemaTickets.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CinemaTickets.Web.Controllers
{
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private IMapper _mapper;
        private IMovieService _movieService;
        private IActorService _movieActorService;
        private ICountryService _countryService;
        private IDirectorService _directorService;
        private IGenreService _genreService;
        private ILanguageService _languageService;
        private IWriterService _writerService;
        private IOrderService _orderService;
        private ISeatService _seatService;

        public MovieController(IMapper mapper, 
            IMovieService movieService,
            IActorService actorService,
            ICountryService countryService,
            IDirectorService directorService,
            IGenreService genreService,
            ILanguageService languageService,
            IWriterService writerService, 
            IOrderService orderService, 
            ISeatService seatService)
        {
            _mapper = mapper;
            _movieService = movieService;

            _movieActorService = actorService;
            _countryService = countryService;
            _directorService = directorService;
            _genreService = genreService;
            _languageService = languageService;
            _writerService = writerService;
            _orderService = orderService;
            _seatService = seatService;
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
            List<MovieInGenreDto> source = _movieService.GetMoviesByGenre();

            List<MovieInGenreViewModel> movies = _mapper.Map<List<MovieInGenreViewModel>>(source);

            return View(movies);
        }
        
        [Authorize(Roles = "admin, moderator")]
        [Route("/create")]
        [HttpGet]
        public IActionResult Create()
        {
            var movie = new MovieViewModel();

            SetViewDataVariables();

            return View("Edit", movie);
        }

        [Authorize(Roles = "admin, moderator")]
        [Route("edit/{id}")]
        [HttpGet]
        public IActionResult Edit(long id)
        {
            MovieDto source = _movieService.Get(id);

            MovieViewModel movie = _mapper.Map<MovieViewModel>(source);

            SetViewDataVariables();

            return View(movie);
        }

        [Authorize(Roles = "admin, moderator")]
        [Route("edit/{id?}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(MovieViewModel movie)
        {
            if (!ModelState.IsValid)
            {
                SetViewDataVariables();
                return View(movie);
            }

            var dto = _mapper.Map<MovieDto>(movie);
            _movieService.Update(dto);

            return RedirectToAction("Display", new {id = dto.Id});
        }

        [Authorize(Roles = "admin, moderator")]
        [Route("delete/{id}")]
        [HttpGet]
        public IActionResult Delete(long id)
        {
            _movieService.Delete(id);

            return RedirectToAction("Index");
        }

        [Authorize(Roles = "user")]
        [HttpGet]
        public IActionResult BuyTicket(long sessionId)
        {
            var model = new BuyTicketViewModel
            {
                MovieSessionId = sessionId
            };

            List<SeatDto> seats = _seatService.GetAllBy(sessionId);

            var sourceForSelectList = seats.Select(x => new
            {
                Value = x.Id,
                Label = $"[R = {x.RowNumber}, C = {x.ColumnNumber}] Type: {x.SeatType.ToLower()}"
            });

            ViewBag.Seats = new SelectList(sourceForSelectList, "Value", "Label");

            return PartialView("_BuyTicket", model);
        }

        [Authorize(Roles = "user")]
        [HttpPost]
        public IActionResult BuyTicket(BuyTicketViewModel model)
        {
            var movieId = _orderService.BuyTicketAndGetMovieId(User, new BuyTicketDto
            {
                MovieSessionId = model.MovieSessionId,
                SeatId = model.SeatId
            });

            return RedirectToAction("Display", new {id = movieId});
        }

        
        [HttpGet]
        [Route("tickets")]
        [Authorize]
        public IActionResult GetOrders()
        {
            List<OrderDto> orders = _orderService.GetAllBy(User);

            List<OrderViewModel> model = _mapper.Map<List<OrderDto>, List<OrderViewModel>>(orders);

            return View("Orders", model);
        }

        private void SetViewDataVariables()
        {
            List<ActorDto> actorsSource = _movieActorService.GetAll();
            List<CountryDto> countriesSource = _countryService.GetAll();
            List<DirectorDto> directorsSource = _directorService.GetAll();
            List<GenreSampleInfoDto> genresSource = _genreService.GetAllSample();
            List<LanguageDto> languagesSource = _languageService.GetAll();
            List<WriterDto> writersSource = _writerService.GetAll();

            ViewData["MovieActors"] = _mapper.Map<List<ActorViewModel>>(actorsSource);
            ViewData["MovieCountries"] = _mapper.Map<List<CountryViewModel>>(countriesSource);
            ViewData["MovieDirectors"] = _mapper.Map<List<DirectorViewModel>>(directorsSource);
            ViewData["MovieGenres"] = _mapper.Map<List<GenreSampleViewModel>>(genresSource);
            ViewData["MovieLanguages"] = _mapper.Map<List<LanguageViewModel>>(languagesSource);
            ViewData["MovieWriters"] = _mapper.Map<List<WriterViewModel>>(writersSource);
        }
    }
}