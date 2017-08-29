using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Infrastructure.Data.Concrete;
using CinemaTickets.Infrastructure.Data.Concrete.Specifications;
using CinemaTickets.Infrastructure.Data.Context;
using CinemaTickets.Infrastructure.Data.Repositories;
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
        }

        [Fact]
        public void SpecificationTest()
        {
            IRepository<Actor> actors = new Repository<Actor>(new CinemaTicketsContext(_options), new QuerySpecificationBuilder<Actor>());

            List<Actor> queryResult = actors.Find(
                new OrderDescSpecification<Actor> { KeySelector = a => a.FirstName},
                new CriteriaSpecification<Actor> {Predicate = a => a.Id > 0},
                new OrderAscSpecification<Actor> {KeySelector = a => a.Id});

            foreach (Actor actor in queryResult)
            {
                _output.WriteLine($"{actor.Id} {actor.FirstName} {actor.LastName}");
                foreach (MovieActor ma in actor.MovieActors)
                {
                    _output.WriteLine($"-->{ma.Movie.Id}");
                }
            }
        }
    }
}
