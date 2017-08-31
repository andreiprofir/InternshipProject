using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using AutoMapper;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Genre;
using CinemaTickets.Domain.Dtos.Movie;
using CinemaTickets.Domain.Dtos.Picture;
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

            MovieFullInfoDto dto = service.GetFullInfoOfMovieById(36);

            _output.WriteLine($"{dto.Id} {dto.Name} {dto.OriginalName}");
        }
    }
}
