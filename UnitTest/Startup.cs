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
using Xunit;
using Xunit.Abstractions;
using Xunit.DependencyInjection;

namespace UnitTest
{
    public class Startup 
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IPersonasModel, PersonasModel>();
            services.AddScoped<IEdadModel, EdadModel>();
            services.AddScoped<IContextoDatosPersona, ContextoDatosPersonasFake>();
        }

    }
}
