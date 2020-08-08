using DependencyInjection_ASP.NET_Core.Abstracciones;
using DependencyInjection_ASP.NET_Core.ViewModel;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using System.Xml;

namespace DependencyInjection_ASP.NET_Core.Models
{
    public class CalcularModel :ICalcularModel
    {
        private readonly ILogger<CalcularModel> _logger;
        public CalcularModel(ILogger<CalcularModel> logger)
        {
            _logger = logger;
        }
        public string Calcular(CalculoViewModel viewmodel)
        {
            _logger.LogInformation("Comienza a {Operacion} entre {PrimerNumero} y {SegundoNumero}",viewmodel.TipoOperacion.ToString(), viewmodel.PrimerNumero, viewmodel.SegundoNumero);
            switch (viewmodel.TipoOperacion)
            {
                case Operacion.sumar:
                    return (viewmodel.PrimerNumero + viewmodel.SegundoNumero).ToString();
                case Operacion.restar:
                    return (viewmodel.PrimerNumero - viewmodel.SegundoNumero).ToString();
                case Operacion.multiplicar:
                    return (viewmodel.PrimerNumero * viewmodel.SegundoNumero).ToString();
                case Operacion.dividir:
                    {
                        if (viewmodel.SegundoNumero != 0)
                        return (viewmodel.PrimerNumero + viewmodel.SegundoNumero).ToString();
                        else
                        return "No se puede dividir por cero";
                    }
                default:
                    return string.Empty;
            }
        }
    }
}
