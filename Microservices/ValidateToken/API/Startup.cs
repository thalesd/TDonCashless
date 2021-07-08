using System;
using IOCLayer;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using TDonCashless.Domain.Core.Bus;
using TDonCashless.Microservices.ValidateToken.Data.Context;
using TDonCashless.Microservices.ValidateToken.Domain.EventHandlers;
using TDonCashless.Microservices.ValidateToken.Domain.Events;

namespace TDonCashless.Microservices.ValidateToken.API
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
            services.AddDbContext<ValidatedTokenDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("ValidateTokenDbConnection"), optionsBuilder => optionsBuilder.MigrationsAssembly("TDonCashless.Microservices.ValidateToken.API"));
            });

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "TDonCashless.Microservices.ValidateToken.API",
                    Version = "v1",
                    Description = "A Microservice approach to log authentication attempts using recursive right circular rotation as the token encryption.",
                    Contact = new OpenApiContact
                    {
                        Name = "Thales Donizetti Marukawa de Oliveira",
                        Email = "tdonizetti@tdonsoft.com",
                        Url = new Uri("https://github.com/thalesd")
                    }
                });
            });

            services.AddCors();

            services.AddMediatR(typeof(Startup));

            RegisterServices(services);
        }

        private void RegisterServices(IServiceCollection services)
        {
            DependencyContainer.RegisterServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "TDonCashless.Microservices.ValidateToken.API v1");
                    c.RoutePrefix = string.Empty;
                });
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            ConfigureEventBus(app);
        }

        private void ConfigureEventBus(IApplicationBuilder app)
        {
            var eventBus = app.ApplicationServices.GetRequiredService<IEventBus>();

            eventBus.Subscribe<InsertValidatedTokenInitiatedEvent, InsertValidatedTokenEventHandler>();
        }
    }
}
