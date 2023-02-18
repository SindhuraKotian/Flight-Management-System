using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalCodingChallenge.Business.Repositories;
using FinalCodingChallenge.Business.Services;
using FinalCodingChallenge.DataAccess.Repositories;
using FinalCodingChallenge.DataAccess.Services;
using FinalCodingChallenge.Domain.Entities;
using FinalCodingChallenge.Domain.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace FinalCodingChallenge
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
            services.AddScoped<FlightMgmtSystemDBContext>();
            services.AddScoped<IFlightDA, FlightDA>();
            services.AddScoped<IPassengerDA, PassengerDA>();
            services.AddScoped<IFlightBA, FlightBA>();
            services.AddScoped<IPassengerBA, PassengerBA>();
            services.AddScoped<ManagerModel>();
            services.AddCors(options =>
            {
                options.AddPolicy("AllowMyOrigin",
                builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin().AllowCredentials());
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseCors("AllowMyOrigin");
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
