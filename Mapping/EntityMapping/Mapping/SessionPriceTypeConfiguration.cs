﻿using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Mapping
{
    public class SessionPriceTypeConfiguration : EntityTypeConfiguration<SessionPrice>
    {
        public SessionPriceTypeConfiguration()
        {
            Property(e => e.Price)
                .HasPrecision(19, 4);
        }
    }
}