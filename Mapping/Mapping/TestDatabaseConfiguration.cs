using System;
using ConsoleApp1.Domain;
using FluentNHibernate.Automapping;

namespace Mapping
{
    public class TestDatabaseConfiguration : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            return type.Namespace == typeof(Movie).Namespace;
        }
    }
}