using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection_ASP.NET_Core.ViewModel
{
    public class PersonaViewModel
    {
        public PersonaViewModel()
        {
            Documento = "";
            Nombre = "";
            Edad = 0;
            FecNacimiento = "";
            Sexo = ' ';
        }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string FecNacimiento { get; set; }
        public char Sexo { get; set; }
    }
}
