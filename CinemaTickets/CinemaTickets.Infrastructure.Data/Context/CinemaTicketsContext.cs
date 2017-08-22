using System.Data.Entity;
using CinemaTickets.Domain.Core.Classes;
using CinemaTickets.Infrastructure.Data.Mappings;

namespace CinemaTickets.Infrastructure.Data.Context
{
    public partial class CinemaTicketsContext : DbContext
    {
        public CinemaTicketsContext()
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
                .Add(new ActorMap())
                .Add(new CinemaMap())
                .Add(new CityMap())
                .Add(new CommentMap())
                .Add(new CommentTypeMap())
                .Add(new CountryMap())
                .Add(new DirectorMap())
                .Add(new EntityMap())
                .Add(new GenreMap())
                .Add(new HallMap())
                .Add(new LanguageMap())
                .Add(new MovieSessionMap())
                .Add(new MovieMap())
                .Add(new OrderMap())
                .Add(new PictureMap())
                .Add(new PromotionMap())
                .Add(new RoleMap())
                .Add(new SeatMap())
                .Add(new SessionPriceMap())
                .Add(new SeatTypeMap())
                .Add(new UserMap())
                .Add(new WriterMap());
        }
    }
}
