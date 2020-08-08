using DependencyInjection_ASP.NET_Core.Abstracciones;
using DependencyInjection_ASP.NET_Core.ViewModel;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection_ASP.NET_Core.Models
{
    public class EdadModel:IEdadModel
    {   
        readonly ILogger<EdadModel> _logger ;  
        public EdadModel(ILogger<EdadModel> logger)
        {
            _logger = logger;
        }
        public int CalcularEdad(EdadViewModel viewmodel)
        {
            _logger.LogInformation("Comenzamos el calculo de la edad para la fecha {Fecha}", viewmodel.FechaNacimiento);
            DateTime now = DateTime.Today;
            int edad = DateTime.Today.Year - viewmodel.FechaNacimiento.Year;

            if (DateTime.Today < viewmodel.FechaNacimiento.AddYears(edad))
                --edad;

            return edad;
        }



    }
}
