using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Domain;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Mapping.Mappings;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Mapping
{
    class Program
    {
        private const string ConnectionString =
                @"Data Source=MDDSK40048;Initial Catalog=CinemaTickets;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
            ;

        static void Main(string[] args)
        {
            //AutoMapping();
            FluentMapping();
        }

        static void FluentMapping()
        {
            Configuration configuration = Fluently.Configure()
                .Database(MsSqlConfiguration
                    .MsSql2012
                    .ConnectionString(ConnectionString))
                .Mappings(m => m.FluentMappings
                    .AddFromAssemblyOf<MovieMap>())
                .BuildConfiguration();

            var exporter = new SchemaExport(configuration);
            exporter.Drop(true, true);
            exporter.Create(true, true);
            
            Console.WriteLine("Finish...");
        }

        static void AutoMapping()
        {
            var cfg = new TestDatabaseConfiguration();

            Configuration configuration = Fluently.Configure()
                .Database(MsSqlConfiguration
                    .MsSql2012
                    .ConnectionString(ConnectionString))
                .Mappings(m => m.AutoMappings.Add(AutoMap.AssemblyOf<Movie>(cfg)))
                .BuildConfiguration();

            var exporter = new SchemaExport(configuration);
            exporter.Drop(true, true);
            exporter.Create(true, true);

            Console.WriteLine("Finish...");
        }
    }
}
