using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Xunit;
using Xunit.Abstractions;

namespace CinemaTickets.Tests
{
    public class MappingTest
    {
        private readonly ITestOutputHelper _output;

        public MappingTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Test1()
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

            var optionsBuilder = new DbContextOptionsBuilder<CinemaTicketsContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            using (CinemaTicketsContext db = new CinemaTicketsContext(options))
            {
                _output.WriteLine(db.Actors.Count().ToString());
            }
        }
    }
}
