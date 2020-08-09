using DatosPersonas.Abstracciones;
using DatosPersonas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatosPersonas.Contextos
{
    public class ContextoDatosPersonasFake:IContextoDatosPersona
    {
        List<Persona> Lista { get; set; }
        public ContextoDatosPersonasFake()
        {
            Lista = new List<Persona>();
            Lista.Add(new Persona() { Documento = "12345678", Nombre = "Test", FechaNacimiento = new DateTime(2001, 12, 27), Sexo = 'M' });
        }

        public IList<Persona> TraerPersonas()
        {
            return Lista;
        }

        public Persona TraerPersona(string documento)
        {
            if(Lista.Any(x => x.Documento == documento))
            {
                return Lista.First(x => x.Documento == documento);
            }
            return null;
        }
    }
}
