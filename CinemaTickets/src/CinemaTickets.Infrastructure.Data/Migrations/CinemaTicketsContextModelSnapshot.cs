﻿// <auto-generated />
using CinemaTickets.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace CinemaTickets.Infrastructure.Data.Migrations
{
    [DbContext(typeof(CinemaTicketsContext))]
    partial class CinemaTicketsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Actor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("FirstName", "LastName")
                        .IsUnique()
                        .HasName("AK_Actors_FirstName_LastName");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Cinema", b =>
                {
                    b.Property<long>("Id");

                    b.Property<long>("CityId");

                    b.Property<string>("ContactPhone")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int>("Dislikes")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(0)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Info");

                    b.Property<int>("Likes")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(0)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.CinemaPromotion", b =>
                {
                    b.Property<long>("CinemaId");

                    b.Property<long>("PromotionId");

                    b.HasKey("CinemaId", "PromotionId");

                    b.HasIndex("PromotionId");

                    b.ToTable("CinemaPromotions");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.City", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("AK_Cities_Name");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Comment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("AnswerToId");

                    b.Property<long?>("CommentTypeId");

                    b.Property<long>("CustomerId");

                    b.Property<DateTimeOffset>("Date");

                    b.Property<long>("EntityId");

                    b.Property<int>("Likes")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1024);

                    b.HasKey("Id");

                    b.HasIndex("AnswerToId");

                    b.HasIndex("CommentTypeId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EntityId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.CommentType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("AK_CommentTypes_Name");

                    b.ToTable("CommentTypes");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Country", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("AK_Countries_Name");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Customer", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("AvatarUri");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .HasMaxLength(64);

                    b.Property<string>("LastName")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Customer");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Director", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("FirstName", "LastName")
                        .IsUnique()
                        .HasName("AK_Directors_FirstName_LastName");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Entity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Entities");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Genre", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("AK_Genres_Name");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Hall", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CinemaId");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.ToTable("Halls");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Language", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("AK_Languages_Name");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Movie", b =>
                {
                    b.Property<long>("Id");

                    b.Property<int>("AgeLimit")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(0)");

                    b.Property<string>("Description");

                    b.Property<int>("Dislikes")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(0)");

                    b.Property<int>("Duration")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(1)");

                    b.Property<string>("ImdbRaiting")
                        .HasMaxLength(255);

                    b.Property<int>("Likes")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(0)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("OriginalName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset>("ReleaseDate");

                    b.Property<string>("Trailer")
                        .HasMaxLength(1024);

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.MovieActor", b =>
                {
                    b.Property<long>("ActorId");

                    b.Property<long>("MovieId");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieActors");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.MovieCountry", b =>
                {
                    b.Property<long>("CountryId");

                    b.Property<long>("MovieId");

                    b.HasKey("CountryId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieCountries");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.MovieDirector", b =>
                {
                    b.Property<long>("DirectorId");

                    b.Property<long>("MovieId");

                    b.HasKey("DirectorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieDirectors");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.MovieGenre", b =>
                {
                    b.Property<long>("GenreId");

                    b.Property<long>("MovieId");

                    b.HasKey("GenreId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieGenres");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.MovieLanguage", b =>
                {
                    b.Property<long>("LanguageId");

                    b.Property<long>("MovieId");

                    b.HasKey("LanguageId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieLanguages");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.MoviePromotion", b =>
                {
                    b.Property<long>("MovieId");

                    b.Property<long>("PromotionId");

                    b.HasKey("MovieId", "PromotionId");

                    b.HasIndex("PromotionId");

                    b.ToTable("MoviePromotions");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.MovieSession", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("HallId");

                    b.Property<long>("MovieId");

                    b.Property<DateTimeOffset>("Time");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieSessions");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.MovieWriter", b =>
                {
                    b.Property<long>("MovieId");

                    b.Property<long>("WriterId");

                    b.HasKey("MovieId", "WriterId");

                    b.HasIndex("WriterId");

                    b.ToTable("MovieWriters");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CustomerId");

                    b.Property<long>("MovieSessionId");

                    b.Property<long>("SeatId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SeatId");

                    b.HasIndex("MovieSessionId", "SeatId", "CustomerId")
                        .IsUnique()
                        .HasName("AK_Orders_MovieSessionId_SeatId_CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Picture", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alt")
                        .HasMaxLength(255);

                    b.Property<long>("EntityId");

                    b.Property<string>("Uri")
                        .IsRequired()
                        .HasMaxLength(1024);

                    b.HasKey("Id");

                    b.HasIndex("EntityId");

                    b.HasIndex("Uri")
                        .IsUnique()
                        .HasName("AK_Pictures_Uri");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Promotion", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("DescriptionOfRules");

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(512);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("ValidFrom");

                    b.Property<DateTimeOffset?>("ValidTo");

                    b.HasKey("Id");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Seat", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ColumnNumber")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(0)");

                    b.Property<long>("HallId");

                    b.Property<string>("Identifier")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<bool?>("IsBusy")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(0)");

                    b.Property<int>("RowNumber")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(0)");

                    b.Property<long>("SeatTypeId");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.HasIndex("SeatTypeId");

                    b.HasIndex("RowNumber", "ColumnNumber", "HallId")
                        .IsUnique()
                        .HasName("AK_Seats_RowNumber_ColumnNumber_HallId");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.SeatType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("AK_SeatTypes_Name");

                    b.ToTable("SeatTypes");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.SessionPrice", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("MovieSessionId");

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("money")
                        .HasDefaultValueSql("(0)");

                    b.Property<long>("SeatTypeId");

                    b.HasKey("Id");

                    b.HasIndex("SeatTypeId");

                    b.HasIndex("MovieSessionId", "SeatTypeId")
                        .IsUnique()
                        .HasName("AK_SessionPrices_MovieSessionId_SeatTypeId");

                    b.ToTable("SessionPrices");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Writer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("FirstName", "LastName")
                        .IsUnique()
                        .HasName("AK_Writers_FirstName_LastName");

                    b.ToTable("Writers");
                });

            modelBuilder.Entity("CinemaTickets.Infrastructure.Data.Models.Identity.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("CinemaTickets.Infrastructure.Data.Models.Identity.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<long>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("CinemaTickets.Infrastructure.Data.Models.UserCustomer", b =>
                {
                    b.HasBaseType("CinemaTickets.Domain.Core.Models.Customer");


                    b.ToTable("UserCustomer");

                    b.HasDiscriminator().HasValue("UserCustomer");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Cinema", b =>
                {
                    b.HasOne("CinemaTickets.Domain.Core.Models.City", "City")
                        .WithMany("Cinemas")
                        .HasForeignKey("CityId")
                        .HasConstraintName("FK_Cinemas_Cities");

                    b.HasOne("CinemaTickets.Domain.Core.Models.Entity", "Entity")
                        .WithOne("Cinemas")
                        .HasForeignKey("CinemaTickets.Domain.Core.Models.Cinema", "Id")
                        .HasConstraintName("FK_Cinemas_Entities");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.CinemaPromotion", b =>
                {
                    b.HasOne("CinemaTickets.Domain.Core.Models.Cinema", "Cinema")
                        .WithMany("CinemaPromotions")
                        .HasForeignKey("CinemaId")
                        .HasConstraintName("FK_CinemaPromotions_Cinemas")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CinemaTickets.Domain.Core.Models.Promotion", "Promotion")
                        .WithMany("CinemaPromotions")
                        .HasForeignKey("PromotionId")
                        .HasConstraintName("FK_CinemaPromotions_Promotions")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Comment", b =>
                {
                    b.HasOne("CinemaTickets.Domain.Core.Models.Comment", "AnswerTo")
                        .WithMany("InverseAnswerTo")
                        .HasForeignKey("AnswerToId")
                        .HasConstraintName("FK_Comments_Comments");

                    b.HasOne("CinemaTickets.Domain.Core.Models.CommentType", "CommentType")
                        .WithMany("Comments")
                        .HasForeignKey("CommentTypeId")
                        .HasConstraintName("FK_Comments_CommentTypes");

                    b.HasOne("CinemaTickets.Domain.Core.Models.Customer", "Customer")
                        .WithMany("Comments")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Comments_Customers");

                    b.HasOne("CinemaTickets.Domain.Core.Models.Entity", "Entity")
                        .WithMany("Comments")
                        .HasForeignKey("EntityId")
                        .HasConstraintName("FK_Comments_Entities");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Genre", b =>
                {
                    b.HasOne("CinemaTickets.Domain.Core.Models.Entity", "Entity")
                        .WithOne("Genres")
                        .HasForeignKey("CinemaTickets.Domain.Core.Models.Genre", "Id")
                        .HasConstraintName("FK_Genres_Entities");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Hall", b =>
                {
                    b.HasOne("CinemaTickets.Domain.Core.Models.Cinema", "Cinema")
                        .WithMany("Halls")
                        .HasForeignKey("CinemaId")
                        .HasConstraintName("FK_Halls_Cinemas");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Movie", b =>
                {
                    b.HasOne("CinemaTickets.Domain.Core.Models.Entity", "Entity")
                        .WithOne("Movies")
                        .HasForeignKey("CinemaTickets.Domain.Core.Models.Movie", "Id")
                        .HasConstraintName("FK_Movies_Entities");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.MovieActor", b =>
                {
                    b.HasOne("CinemaTickets.Domain.Core.Models.Actor", "Actor")
                        .WithMany("MovieActors")
                        .HasForeignKey("ActorId")
                        .HasConstraintName("FK_MovieActors_Actors")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CinemaTickets.Domain.Core.Models.Movie", "Movie")
                        .WithMany("MovieActors")
                        .HasForeignKey("MovieId")
                        .HasConstraintName("FK_MovieActors_Movies")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.MovieCountry", b =>
                {
                    b.HasOne("CinemaTickets.Domain.Core.Models.Country", "Country")
                        .WithMany("MovieCountries")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("FK_MovieCountries_Countries")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CinemaTickets.Domain.Core.Models.Movie", "Movie")
                        .WithMany("MovieCountries")
                        .HasForeignKey("MovieId")
                        .HasConstraintName("FK_MovieCountries_Movies")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.MovieDirector", b =>
                {
                    b.HasOne("CinemaTickets.Domain.Core.Models.Director", "Director")
                        .WithMany("MovieDirectors")
                        .HasForeignKey("DirectorId")
                        .HasConstraintName("FK_MovieDirectors_Directors")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CinemaTickets.Domain.Core.Models.Movie", "Movie")
                        .WithMany("MovieDirectors")
                        .HasForeignKey("MovieId")
                        .HasConstraintName("FK_MovieDirectors_Movies")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.MovieGenre", b =>
                {
                    b.HasOne("CinemaTickets.Domain.Core.Models.Genre", "Genre")
                        .WithMany("MovieGenres")
                        .HasForeignKey("GenreId")
                        .HasConstraintName("FK_MovieGenres_Genres")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CinemaTickets.Domain.Core.Models.Movie", "Movie")
                        .WithMany("MovieGenres")
                        .HasForeignKey("MovieId")
                        .HasConstraintName("FK_MovieGenres_Movies")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.MovieLanguage", b =>
                {
                    b.HasOne("CinemaTickets.Domain.Core.Models.Language", "Language")
                        .WithMany("MovieLanguages")
                        .HasForeignKey("LanguageId")
                        .HasConstraintName("FK_MovieLanguages_Languages")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CinemaTickets.Domain.Core.Models.Movie", "Movie")
                        .WithMany("MovieLanguages")
                        .HasForeignKey("MovieId")
                        .HasConstraintName("FK_MovieLanguages_Movies")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.MoviePromotion", b =>
                {
                    b.HasOne("CinemaTickets.Domain.Core.Models.Movie", "Movie")
                        .WithMany("MoviePromotions")
                        .HasForeignKey("MovieId")
                        .HasConstraintName("FK_MoviePromotions_Movies")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CinemaTickets.Domain.Core.Models.Promotion", "Promotion")
                        .WithMany("MoviePromotions")
                        .HasForeignKey("PromotionId")
                        .HasConstraintName("FK_MoviePromotions_Promotions")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.MovieSession", b =>
                {
                    b.HasOne("CinemaTickets.Domain.Core.Models.Hall", "Hall")
                        .WithMany("MovieSessions")
                        .HasForeignKey("HallId")
                        .HasConstraintName("FK_MovieSessions_Halls");

                    b.HasOne("CinemaTickets.Domain.Core.Models.Movie", "Movie")
                        .WithMany("MovieSessions")
                        .HasForeignKey("MovieId")
                        .HasConstraintName("FK_MovieSessions_Movies");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.MovieWriter", b =>
                {
                    b.HasOne("CinemaTickets.Domain.Core.Models.Movie", "Movie")
                        .WithMany("MovieWriters")
                        .HasForeignKey("MovieId")
                        .HasConstraintName("FK_MovieWriters_Movies")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CinemaTickets.Domain.Core.Models.Writer", "Writer")
                        .WithMany("MovieWriters")
                        .HasForeignKey("WriterId")
                        .HasConstraintName("FK_MovieWriters_Writers")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Order", b =>
                {
                    b.HasOne("CinemaTickets.Domain.Core.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Orders_Customers");

                    b.HasOne("CinemaTickets.Domain.Core.Models.MovieSession", "MovieSession")
                        .WithMany("Orders")
                        .HasForeignKey("MovieSessionId")
                        .HasConstraintName("FK_Orders_MovieSessions");

                    b.HasOne("CinemaTickets.Domain.Core.Models.Seat", "Seat")
                        .WithMany("Orders")
                        .HasForeignKey("SeatId")
                        .HasConstraintName("FK_Orders_Seats");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Picture", b =>
                {
                    b.HasOne("CinemaTickets.Domain.Core.Models.Entity", "Entity")
                        .WithMany("Pictures")
                        .HasForeignKey("EntityId")
                        .HasConstraintName("FK_Pictures_Entities");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Promotion", b =>
                {
                    b.HasOne("CinemaTickets.Domain.Core.Models.Entity", "Entity")
                        .WithOne("Promotions")
                        .HasForeignKey("CinemaTickets.Domain.Core.Models.Promotion", "Id")
                        .HasConstraintName("FK_Promotions_Entities");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.Seat", b =>
                {
                    b.HasOne("CinemaTickets.Domain.Core.Models.Hall", "Hall")
                        .WithMany("Seats")
                        .HasForeignKey("HallId")
                        .HasConstraintName("FK_Seats_Halls");

                    b.HasOne("CinemaTickets.Domain.Core.Models.SeatType", "SeatType")
                        .WithMany("Seats")
                        .HasForeignKey("SeatTypeId")
                        .HasConstraintName("FK_Seats_SeatTypes");
                });

            modelBuilder.Entity("CinemaTickets.Domain.Core.Models.SessionPrice", b =>
                {
                    b.HasOne("CinemaTickets.Domain.Core.Models.MovieSession", "MovieSession")
                        .WithMany("SessionPrices")
                        .HasForeignKey("MovieSessionId")
                        .HasConstraintName("FK_SessionPrices_MovieSessions");

                    b.HasOne("CinemaTickets.Domain.Core.Models.SeatType", "SeatType")
                        .WithMany("SessionPrices")
                        .HasForeignKey("SeatTypeId")
                        .HasConstraintName("FK_SessionPrices_SeatTypes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.HasOne("CinemaTickets.Infrastructure.Data.Models.Identity.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CinemaTickets.Infrastructure.Data.Models.Identity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.HasOne("CinemaTickets.Infrastructure.Data.Models.Identity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CinemaTickets.Infrastructure.Data.Models.UserCustomer", b =>
                {
                    b.HasOne("CinemaTickets.Infrastructure.Data.Models.Identity.User", "User")
                        .WithOne("Customer")
                        .HasForeignKey("CinemaTickets.Infrastructure.Data.Models.UserCustomer", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
