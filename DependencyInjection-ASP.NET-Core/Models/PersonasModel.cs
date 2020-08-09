using DatosPersonas.Abstracciones;
using DependencyInjection_ASP.NET_Core.Abstracciones;
using DependencyInjection_ASP.NET_Core.ViewModel;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection_ASP.NET_Core.Models
{
    public class PersonasModel : IPersonasModel
    {
        readonly ILogger<PersonasModel> _logger;
        readonly IContextoDatosPersona _contextoDatosPersona;
        readonly IEdadModel _edadModel;
        public PersonasModel (ILogger<PersonasModel> logger ,IContextoDatosPersona contextoDatosPersonas,IEdadModel edadModel)
        {
            _logger = logger;
            _contextoDatosPersona = contextoDatosPersonas;
            _edadModel = edadModel;
        }

        public PersonaViewModel TraerPersona(string documento)
        {
            var persona =  _contextoDatosPersona.TraerPersona(documento);
            if(persona != null)
            {
                return new PersonaViewModel()
                {
                    Nombre = persona.Nombre,
                    Documento = persona.Documento,
                    FecNacimiento = string.Format("{0}/{1}/{2}", persona.FechaNacimiento.Day.ToString("00"), persona.FechaNacimiento.Month.ToString("00"), persona.FechaNacimiento.Year.ToString("0000")),
                    Sexo = persona.Sexo,
                    Edad = _edadModel.CalcularEdad(new EdadViewModel() { FechaNacimiento = persona.FechaNacimiento })
                };
            }
            return null;
        }
    }
}
