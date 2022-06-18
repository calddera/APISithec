using Core.Sithec.Interfaces;
using Core.Sithec.Models.Automapper;
using Core.Sithec.Services;
using Data.Sithec.Entities;
using Data.Sithec.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISithec
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
            services.AddDbContext<SithecContext>(options =>
                options.UseMySQL(
                    Configuration.GetConnectionString("SithecConnection")));
            services.AddControllers();
            services.AddAutoMapper(typeof(AutoMapping));
            services.AddSingleton<IHumanMockService, HumanMockService>();
            services.AddSingleton<ICalcService, CalcService>();
            services.AddScoped(typeof(IHumanService), typeof(HumanService));
            services.AddScoped(typeof(IHumanoRepo), typeof(HumanoRepo));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
