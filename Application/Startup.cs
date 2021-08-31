using Infra.Data.Contexts;
using Infra.Data.Interfaces;
using Infra.Data.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Service.Adapter;
using Service.Interfaces;
using Service.Services;
using System.IO;

namespace Application
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
            services.AddDbContext<Context>(options => options.UseSqlServer(Configuration.GetConnectionString("DbConnection")));
            services.AddScoped<IWeatherRepository, WeatherRepository>();
            services.AddScoped<IWeatherService, WeatherService>();
            services.AddScoped<IWeatherForecastAdapter, WeatherForecastAdapter>();
            services.AddSpaStaticFiles(diretorio => { diretorio.RootPath = "ControleFinanceiro-UI"; });
            services.AddCors();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(opcoes => opcoes.AllowAnyOrigin().AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            
            app.UseStaticFiles();

            app.UseSpaStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

           app.UseSpa(spa =>
           {
                spa.Options.SourcePath = Path.Combine(Directory.GetCurrentDirectory(), "SistemaPrevisaoClima-UI");

                if (env.IsDevelopment())
                    spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
           });
        }
    }
}
