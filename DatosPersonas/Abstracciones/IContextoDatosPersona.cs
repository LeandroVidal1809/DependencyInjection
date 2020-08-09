using DatosPersonas.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatosPersonas.Abstracciones
{
    public interface IContextoDatosPersona
    {
        IList<Persona> TraerPersonas();
        Persona TraerPersona(string documento);
    }
}
