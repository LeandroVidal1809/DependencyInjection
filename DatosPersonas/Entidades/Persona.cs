using System;

namespace DatosPersonas.Entidades
{
    public class Persona
    {

        public string Nombre { get; set; }
        public string Documento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Edad { get; set; }
        public char Sexo { get; set; }
    }

}
