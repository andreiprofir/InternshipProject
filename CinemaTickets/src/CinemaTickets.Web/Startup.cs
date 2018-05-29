using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Infrastructure.Business.Services;
using CinemaTickets.Infrastructure.Data.Concrete;
using CinemaTickets.Infrastructure.Data.Context;
using CinemaTickets.Infrastructure.Data.Interfaces;
using CinemaTickets.Infrastructure.Data.Models.Identity;
using CinemaTickets.Infrastructure.Data.Repositories;
using CinemaTickets.Infrastructure.Data.Repositories.Interfaces;
using CinemaTickets.Services.Application.AutoMapper;
using CinemaTickets.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CinemaTickets.Web.Models;
using CinemaTickets.Web.Services;

namespace CinemaTickets.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CinemaTicketsContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<User, Role>(opt =>
                {
                    opt.Password.RequiredLength = 6;
                    opt.Password.RequireDigit = false;
                    opt.Password.RequireLowercase = false;
                    opt.Password.RequireNonAlphanumeric = false;
                    opt.Password.RequireUppercase = false;
                    opt.Password.RequireNonAlphanumeric = false;
                })
                .AddEntityFrameworkStores<CinemaTicketsContext>()
                .AddDefaultTokenProviders();

            services.AddAuthentication().AddFacebook(facebookOptions =>
            {
                facebookOptions.AppId = "626492187709103";
                facebookOptions.AppSecret = "60d9f4cdc0059c33b06daf1eaed953ed";
            });

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();

            services.AddMvc();
            services.AddAutoMapper(additional => additional.AddProfiles(Assembly.Load("CinemaTickets.Services.Application")));

            services.AddScoped<DbContext, CinemaTicketsContext>();
            services.AddScoped(typeof(IQuerySpecificationBuilder<>), typeof(QuerySpecificationBuilder<>));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IMovieService, MovieService>();

            services.AddScoped<IGenreRepository, GenreRepository>();
            services.AddScoped<IGenreService, GenreService>();

            services.AddScoped<ICinemaRepository, CinemaRepository>();
            services.AddScoped<ICinemaService, CinemaService>();

            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IActorService, ActorService>();
            services.AddScoped<IDirectorService, DirectorService>();
            services.AddScoped<IWriterService, WriterService>();
            services.AddScoped<ILanguageService, LanguageService>();
            services.AddScoped<ICountryService, CountryService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
