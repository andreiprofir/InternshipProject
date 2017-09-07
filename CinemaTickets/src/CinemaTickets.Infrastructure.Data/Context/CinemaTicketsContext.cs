using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Infrastructure.Data.Mappings;
using CinemaTickets.Infrastructure.Data.Models;
using CinemaTickets.Infrastructure.Data.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CinemaTickets.Infrastructure.Data.Context
{
    public partial class CinemaTicketsContext : IdentityDbContext<User, Role, long>
    {
        #region VirtualDbSets

        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<CinemaPromotion> CinemaPromotions { get; set; }
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
        public virtual DbSet<MovieActor> MovieActors { get; set; }
        public virtual DbSet<MovieCountry> MovieCountries { get; set; }
        public virtual DbSet<MovieDirector> MovieDirectors { get; set; }
        public virtual DbSet<MovieGenre> MovieGenres { get; set; }
        public virtual DbSet<MovieLanguage> MovieLanguages { get; set; }
        public virtual DbSet<MoviePromotion> MoviePromotions { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<MovieSession> MovieSessions { get; set; }
        public virtual DbSet<MovieWriter> MovieWriters { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
        public virtual DbSet<SeatType> SeatTypes { get; set; }
        public virtual DbSet<SessionPrice> SessionPrices { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Writer> Writers { get; set; }

        #endregion

        public CinemaTicketsContext(DbContextOptions<CinemaTicketsContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ActorMap());
            modelBuilder.ApplyConfiguration(new CinemaMap());
            modelBuilder.ApplyConfiguration(new CinemaPromotionMap());
            modelBuilder.ApplyConfiguration(new CityMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new CommentTypeMap());
            modelBuilder.ApplyConfiguration(new CountryMap());
            modelBuilder.ApplyConfiguration(new DirectorMap());
            modelBuilder.ApplyConfiguration(new GenreMap());
            modelBuilder.ApplyConfiguration(new HallMap());
            modelBuilder.ApplyConfiguration(new LanguageMap());
            modelBuilder.ApplyConfiguration(new MovieMap());
            modelBuilder.ApplyConfiguration(new MovieActorMap());
            modelBuilder.ApplyConfiguration(new MovieCountryMap());
            modelBuilder.ApplyConfiguration(new MovieDirectorMap());
            modelBuilder.ApplyConfiguration(new MovieGenreMap());
            modelBuilder.ApplyConfiguration(new MovieLanguageMap());
            modelBuilder.ApplyConfiguration(new MoviePromotionMap());
            modelBuilder.ApplyConfiguration(new MovieSessionMap());
            modelBuilder.ApplyConfiguration(new MovieWriterMap());
            modelBuilder.ApplyConfiguration(new OrderMap());
            modelBuilder.ApplyConfiguration(new PictureMap());
            modelBuilder.ApplyConfiguration(new PromotionMap());
            modelBuilder.ApplyConfiguration(new SeatMap());
            modelBuilder.ApplyConfiguration(new SeatTypeMap());
            modelBuilder.ApplyConfiguration(new SessionPriceMap());
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new WriterMap());

            modelBuilder.Entity<UserCustomer>()
                .HasOne(e => e.User)
                .WithOne(e => e.Customer)
                .HasForeignKey<UserCustomer>(e => e.Id);

            modelBuilder.Entity<User>().ToTable("Users");
            
            modelBuilder.Entity<Role>()
                .ToTable("Roles");

            modelBuilder.Entity<IdentityUserRole<long>>()
                .ToTable("UserRoles");

            modelBuilder.Entity<IdentityUserToken<long>>()
                .ToTable("UserTokens");

            modelBuilder.Entity<IdentityUserLogin<long>>()
                .ToTable("UserLogins");

            modelBuilder.Entity<IdentityUserClaim<long>>()
                .ToTable("UserClaims");

            modelBuilder.Entity<IdentityRoleClaim<long>>()
                .ToTable("RoleClaims");
        }
    }
}
