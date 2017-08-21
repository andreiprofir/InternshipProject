using EntityMapping.Mapping;

namespace EntityMapping
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CinemaTickets : DbContext
    {
        public CinemaTickets()
            : base("name=CinemaTickets")
        {
        }
        
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Cinema> Cinemas { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<CommentType> CommentTypes { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Director> Directors { get; set; }
        public virtual DbSet<Entity> Entities { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Hall> Halls { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<MovieSession> MovieSessions { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
        public virtual DbSet<SeatType> SeatTypes { get; set; }
        public virtual DbSet<SessionPrice> SessionPrices { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Writer> Writers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations
                .Add(new ActorTypeConfiguration())
                .Add(new CinemaTypeConfiguration())
                .Add(new CityTypeConfiguration())
                .Add(new CommentTypeConfiguration())
                .Add(new CommentTypeTypeConfiguration())
                .Add(new CountryTypeConfiguration())
                .Add(new DirectorTypeConfiguration())
                .Add(new EntityConfiguration())
                .Add(new GenreTypeConfiguration())
                .Add(new HallTypeConfiguration())
                .Add(new LanguageTypeConfiguration())
                .Add(new MovieSessionTypeConfiguration())
                .Add(new MovieTypeConfiguration())
                .Add(new OrderTypeConfiguration())
                .Add(new PictureTypeConfiguration())
                .Add(new PromotionTypeConfiguration())
                .Add(new RoleTypeConfiguration())
                .Add(new SeatTypeConfiguration())
                .Add(new SessionPriceTypeConfiguration())
                .Add(new SeatTypeTypeConfiguration())
                .Add(new UserTypeConfiguration())
                .Add(new WriterTypeConfiguration());
        }
    }
}
