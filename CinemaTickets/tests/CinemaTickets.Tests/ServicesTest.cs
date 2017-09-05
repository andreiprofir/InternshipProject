using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using AutoMapper;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Cinema;
using CinemaTickets.Domain.Dtos.City;
using CinemaTickets.Domain.Dtos.Genre;
using CinemaTickets.Domain.Dtos.Movie;
using CinemaTickets.Domain.Dtos.MovieSession;
using CinemaTickets.Domain.Dtos.Picture;
using CinemaTickets.Domain.Dtos.Promotion;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Infrastructure.Business.Services;
using CinemaTickets.Infrastructure.Data.Concrete;
using CinemaTickets.Infrastructure.Data.Context;
using CinemaTickets.Infrastructure.Data.Repositories;
using CinemaTickets.Services.Application.AutoMapper;
using CinemaTickets.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Xunit;
using Xunit.Abstractions;

namespace CinemaTickets.Tests
{
    public class ServicesTest
    {
        private DbContextOptions<IdentityContext> _options;
        private readonly ITestOutputHelper _output;
        private IMapper _mapper;

        private CinemaTicketsContext _context;

        public ServicesTest(ITestOutputHelper output)
        {
            var builder = new ConfigurationBuilder();

            // установка пути к текущему каталогу
            builder.SetBasePath(Directory.GetCurrentDirectory());

            // получаем конфигурацию из файла appsettings.json
            builder.AddJsonFile("appsettings.json");

            // создаем конфигурацию
            var config = builder.Build();

            // получаем строку подключения
            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<IdentityContext>();
            _options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            _output = output;

            var config1 = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainToDtoMappingProfile());
                cfg.AddProfile(new DtoToDomainMappingProfile());
            });

            _mapper = config1.CreateMapper();

            config1.AssertConfigurationIsValid<DomainToDtoMappingProfile>();

            _context = new CinemaTicketsContext(_options);
        }

        [Fact]
        public void GetMoviesByGenreTest()
        {
            IMovieService service = new MovieService(new MovieRepository(_context, new QuerySpecificationBuilder<Movie>()), _mapper);

            _output.WriteLine($"{service.GetMoviesByGenre(3).Count}");
        }

        [Fact]
        public void GetGenreByIdTest()
        {
            IGenreService service = new GenreService(new GenreRepository(_context, new QuerySpecificationBuilder<Genre>()), _mapper);

            GenreSampleInfoDto res = service.GetById(1);

            _output.WriteLine($"{res.Id} {res.Name}");
        }

        [Fact]
        public void GetFullInfoOfMovieByIdTest()
        {
            IMovieService service = new MovieService(new MovieRepository(_context, new QuerySpecificationBuilder<Movie>()), _mapper);

            MovieFullInfoDto dto = service.GetFullInfoOfMovieById(60);

            _output.WriteLine($"{dto.Id} {dto.Name} {dto.OriginalName}");

            var query = from ms in dto.MovieSessions
                        group ms by new { ms.Cinema.Id, ms.Cinema.Name };

            foreach (var session in query)
            {
                _output.WriteLine($"->{session.Key.Id} {session.Key.Name}");
                foreach (var a in session)
                {
                    _output.WriteLine($"-->>>{a.Id} {a.Format} {a.MinPrice} {a.Time:G}");
                }
            }
        }

        [Fact]
        public void GetAllCitiesWithCinemasTest()
        {
            ICityService service = new CityService(new CityRepository(_context, new QuerySpecificationBuilder<City>()), _mapper);

            List<CityWithCinemasDto> result = service.GetAllCitiesWithCinemas();

            foreach (var dto in result)
            {
                _output.WriteLine($"{dto.Id} {dto.Name}");
                foreach (var d in dto.Cinemas)
                {
                    _output.WriteLine($"-->{d.Id} {d.Name} {d.Address}");
                }
            }
        }

        [Fact]
        public void GetPromotionByIdTest()
        {
            IPromotionService service = new PromotionService(new PromotionRepository(_context, new QuerySpecificationBuilder<Promotion>()), _mapper);

            PromotionFullInfoDto dto = service.GetPromotionById(121);

            _output.WriteLine($"{dto?.Id} {dto?.Title} {dto?.ShortDescription}");
        }

        [Fact]
        public void AllValidIn()
        {
            IPromotionService service = new PromotionService(new PromotionRepository(_context, new QuerySpecificationBuilder<Promotion>()), _mapper);

            List<PromotionForListDto> dto = service.GetAllValidIn(9);

            foreach (var a in dto)
            {
                _output.WriteLine($"{a.Id} {a.Title} {a.ShortDescription}");
                foreach (var b in a.Cinemas)
                {
                    _output.WriteLine($"-->{b.Id} {b.Name}");
                }
            }
        }

        [Fact]
        public void GetAllMoviesForPoster()
        {
            IMovieService service = new MovieService(new MovieRepository(_context, new QuerySpecificationBuilder<Movie>()), _mapper);

            List<MovieInfoForListOfPostersDto> dto = service.GetAllMoviesForPoster(71);

            foreach (var d in dto)
            {
                _output.WriteLine($"{d.Id} {d.Name} {d.Poster}");

                foreach (var session in d.MovieSessions)
                {
                    _output.WriteLine($"-->{session?.MinPrice} {session.Format} {session.Time}");
                }
            }
        }

        [Fact]
        public void GetAll()
        {
            ICinemaService service = new CinemaService(new CinemaRepository(_context, new QuerySpecificationBuilder<Cinema>()), _mapper);

            List<CinemaForListDto> dto = service.GetAllByCityId();

            foreach (var d in dto)
            {
                _output.WriteLine($"{d.Id} {d.Name} {d.Phone} {d.Address} {d.City.Name}");
                foreach (var f in d.Formats)
                {
                    _output.WriteLine($"-->{f}");
                }
            }
        }
    }
}
