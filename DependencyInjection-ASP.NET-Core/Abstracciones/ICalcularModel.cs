using DependencyInjection_ASP.NET_Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection_ASP.NET_Core.Abstracciones
{
    public interface ICalcularModel
    {
        string Calcular(CalculoViewModel viewmodel);
    }
}
