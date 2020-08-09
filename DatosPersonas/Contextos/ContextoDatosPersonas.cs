using DatosPersonas.Abstracciones;
using DatosPersonas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatosPersonas.Contextos
{
    public class ContextoDatosPersonas:IContextoDatosPersona
    {
        List<Persona> Lista { get; set; }
        public ContextoDatosPersonas()
        {
            Lista = new List<Persona>();
            Lista.Add(new Persona() { Documento = "37120122", Nombre = "Leandro", FechaNacimiento = new DateTime(1992, 09, 18), Sexo = 'M' });
            Lista.Add(new Persona() { Documento = "34072280", Nombre = "Florencia", FechaNacimiento = new DateTime(1988, 08, 29), Sexo = 'F' });
            Lista.Add(new Persona() { Documento = "40006243", Nombre = "Federico", FechaNacimiento = new DateTime(1992, 11, 19), Sexo = 'M' });
            Lista.Add(new Persona() { Documento = "25061548", Nombre = "Juan", FechaNacimiento = new DateTime(1980, 03, 11), Sexo = 'M' });
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
