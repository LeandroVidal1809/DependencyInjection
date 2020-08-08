using DependencyInjection_ASP.NET_Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace DependencyInjection_ASP.NET_Core.Models
{
    public class CalcularModel
    {
        public string Calcular(CalculoViewModel viewmodel)
        {
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
