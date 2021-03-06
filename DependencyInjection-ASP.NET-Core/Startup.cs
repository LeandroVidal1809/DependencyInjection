using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatosPersonas.Abstracciones;
using DatosPersonas.Contextos;
using DependencyInjection_ASP.NET_Core.Abstracciones;
using DependencyInjection_ASP.NET_Core.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DependencyInjection_ASP.NET_Core
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
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            
            //Usandro Scoped crea una instancia por cada request
            services.AddScoped<ICalcularModel, CalcularModel>();
            services.AddScoped<IEdadModel, EdadModel>();
            services.AddScoped<IPersonasModel, PersonasModel>();
            services.AddScoped<IContextoDatosPersona,ContextoDatosPersonas>();

            //Si usara singleton seria una instancia unica para todos los controller y request que la consuman
            //services.AddSingleton<ICalcularModel, CalcularModel>();

            //si usara transient seria una instacia por CADA controller y Request realizado
            //services.AddTransient<ICalcularModel, CalcularModel>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Calcular/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Calcular}/{action=Index}/{id?}");
            });
        }
    }
}
