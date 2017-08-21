namespace ConsoleApp2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
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
        public virtual DbSet<Movy> Movies { get; set; }
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
            modelBuilder.Entity<Actor>()
                .HasMany(e => e.Movies)
                .WithMany(e => e.Actors)
                .Map(m => m.ToTable("MovieActors").MapLeftKey("ActorId").MapRightKey("MovieId"));

            modelBuilder.Entity<Cinema>()
                .HasMany(e => e.Halls)
                .WithRequired(e => e.Cinema)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cinema>()
                .HasMany(e => e.Promotions)
                .WithMany(e => e.Cinemas)
                .Map(m => m.ToTable("CinemaPromotions").MapLeftKey("CinemaId").MapRightKey("PromotionId"));

            modelBuilder.Entity<City>()
                .HasMany(e => e.Cinemas)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Comment>()
                .HasMany(e => e.Comments1)
                .WithOptional(e => e.Comment1)
                .HasForeignKey(e => e.AnswerToId);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Movies)
                .WithMany(e => e.Countries)
                .Map(m => m.ToTable("MovieCountries").MapLeftKey("CountryId").MapRightKey("MovieId"));

            modelBuilder.Entity<Director>()
                .HasMany(e => e.Movies)
                .WithMany(e => e.Directors)
                .Map(m => m.ToTable("MovieDirectors").MapLeftKey("DirectorId").MapRightKey("MovieId"));

            modelBuilder.Entity<Entity>()
                .HasOptional(e => e.Cinema)
                .WithRequired(e => e.Entity);

            modelBuilder.Entity<Entity>()
                .HasMany(e => e.Comments)
                .WithRequired(e => e.Entity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Entity>()
                .HasOptional(e => e.Genre)
                .WithRequired(e => e.Entity);

            modelBuilder.Entity<Entity>()
                .HasOptional(e => e.Movy)
                .WithRequired(e => e.Entity);

            modelBuilder.Entity<Entity>()
                .HasMany(e => e.Pictures)
                .WithRequired(e => e.Entity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Entity>()
                .HasOptional(e => e.Promotion)
                .WithRequired(e => e.Entity);

            modelBuilder.Entity<Genre>()
                .HasMany(e => e.Movies)
                .WithMany(e => e.Genres)
                .Map(m => m.ToTable("MovieGenres").MapLeftKey("GenreId").MapRightKey("MovieId"));

            modelBuilder.Entity<Hall>()
                .HasMany(e => e.MovieSessions)
                .WithRequired(e => e.Hall)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hall>()
                .HasMany(e => e.Seats)
                .WithRequired(e => e.Hall)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.Movies)
                .WithMany(e => e.Languages)
                .Map(m => m.ToTable("MovieLanguages").MapLeftKey("LanguageId").MapRightKey("MovieId"));

            modelBuilder.Entity<Movy>()
                .HasMany(e => e.MovieSessions)
                .WithRequired(e => e.Movy)
                .HasForeignKey(e => e.MovieId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movy>()
                .HasMany(e => e.Promotions)
                .WithMany(e => e.Movies)
                .Map(m => m.ToTable("MoviePromotions").MapLeftKey("MovieId").MapRightKey("PromotionId"));

            modelBuilder.Entity<Movy>()
                .HasMany(e => e.Writers)
                .WithMany(e => e.Movies)
                .Map(m => m.ToTable("MovieWriters").MapLeftKey("MovieId").MapRightKey("WriterId"));

            modelBuilder.Entity<MovieSession>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.MovieSession)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MovieSession>()
                .HasMany(e => e.SessionPrices)
                .WithRequired(e => e.MovieSession)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Picture>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.Picture)
                .HasForeignKey(e => e.AvatarId);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Roles)
                .Map(m => m.ToTable("UserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<Seat>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Seat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SeatType>()
                .HasMany(e => e.Seats)
                .WithRequired(e => e.SeatType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SeatType>()
                .HasMany(e => e.SessionPrices)
                .WithRequired(e => e.SeatType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SessionPrice>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Comments)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
