using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using AutoMapper;
using CinemaTickets.Domain.Core.Models;
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
        }

        [Fact]
        public void GetMoviesByGenreTest()
        {
            IRepository<Movie> actors = new Repository<Movie>(new CinemaTicketsContext(_options), new QuerySpecificationBuilder<Movie>());

            IMovieService service = new MovieService(new MovieRepository(new CinemaTicketsContext(_options), new QuerySpecificationBuilder<Movie>()), _mapper);

            _output.WriteLine($"{service.GetMoviesByGenre(3).Count}");
        }
    }
}
