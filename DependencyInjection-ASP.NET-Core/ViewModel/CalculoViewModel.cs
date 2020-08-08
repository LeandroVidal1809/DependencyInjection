using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection_ASP.NET_Core.ViewModel
{
    public class CalculoViewModel
    {
        public CalculoViewModel() { }

        public decimal PrimerNumero { get; set; }
        public decimal SegundoNumero { get; set; }
        public Operacion TipoOperacion { get; set; }
        public decimal Resultado { get; set; }
    }

    public enum Operacion
    {
        sumar = 1,
        restar = 2,
        multiplicar = 3,
        dividir=4
    }
}
