using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TdonCashless.Microservices.Gateway.API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace TdonCashless.Microservices.Gateway.API
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "TDonCashless.Microservices.Gateway.API",
                    Version = "v1",
                    Description = "A proxy gateway to consume a microservice approach to cashless authentication using recursive right circular rotation as the token encryption.",
                    Contact = new OpenApiContact
                    {
                        Name = "Thales Donizetti Marukawa de Oliveira",
                        Email = "tdonizetti@tdonsoft.com",
                        Url = new Uri("https://github.com/thalesd"),
                    }
                });
            });

            services.AddHttpClient<ICreateCustomerCardService, CreateCustomerCardService>();
            services.AddHttpClient<IValidatedTokenService, ValidatedTokenService>();
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
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "TdonCashless.Microservices.Gateway.API v1");
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
        }
    }
}
