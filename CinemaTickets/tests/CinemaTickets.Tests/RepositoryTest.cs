using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using AutoMapper.XpressionMapper.Extensions;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Genre;
using CinemaTickets.Domain.Dtos.Picture;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Infrastructure.Data.Concrete;
using CinemaTickets.Infrastructure.Data.Concrete.Specifications;
using CinemaTickets.Infrastructure.Data.Concrete.Specifications.Generics;
using CinemaTickets.Infrastructure.Data.Context;
using CinemaTickets.Infrastructure.Data.Repositories;
using CinemaTickets.Services.Application.AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Xunit;
using Xunit.Abstractions;

namespace CinemaTickets.Tests
{
    public class RepositoryTest
    {
        private DbContextOptions<IdentityContext> _options;
        private readonly ITestOutputHelper _output;
        private IMapper _mapper;

        public RepositoryTest(ITestOutputHelper output)
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
        public void SpecificationTest()
        {
            IRepository<Actor> actors = new Repository<Actor>(new CinemaTicketsContext(_options), new QuerySpecificationBuilder<Actor>());

            List<Actor> queryResult = actors.Find(
                Specification.OrderByDescending<Actor>(a => a.FirstName),
                Specification.Where<Actor>(a => a.Id > 0),
                Specification.OrderBy<Actor>(a => a.Id)
            );
            

            foreach (Actor actor in queryResult)
            {
                _output.WriteLine($"{actor.Id} {actor.FirstName} {actor.LastName}");
                //foreach (MovieActor ma in actor.MovieActors)
                //{
                //    _output.WriteLine($"-->{ma.Movie.Id}");
                //}
            }
        }

        [Fact]
        public void AutoMapperTest()
        {
            using (var context = new CinemaTicketsContext(_options))
            {
                var src = context.Genres
                    .Include(g => g.Entity)
                        .ThenInclude(e => e.Pictures)
                    .ToList();

                var dest = _mapper.Map<List<GenreBaseInfoDto>>(src);

                foreach (var d in dest)
                {
                    _output.WriteLine($"{d.Name} {d.Poster?.Uri}");
                }
            }
        }
    }
}
