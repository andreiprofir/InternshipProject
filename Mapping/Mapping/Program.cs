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
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Impl;
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
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration
                    .MsSql2012
                    .ConnectionString(ConnectionString))
                .Mappings(m => m.FluentMappings
                    .AddFromAssemblyOf<MovieMap>())
                .ExposeConfiguration(cfg =>
                {
                    new SchemaValidator(cfg).Validate();
                })
                .BuildSessionFactory();
            
            //var exporter = ;
            ////exporter.Drop(true, true);
            ////exporter.Create(true, true);
            //exporter.Execute(true, true);
            
            Console.WriteLine("Finish...");

            using (ISession session = sessionFactory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    Genre genre = new Genre
                    {
                        Entity = new Entity(),
                        Name = "Genre3"
                    };

                    session.SaveOrUpdate(genre);

                    //session.Delete(session.Get<Genre>((long) 3));


                    transaction.Commit();
                }
            }
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
