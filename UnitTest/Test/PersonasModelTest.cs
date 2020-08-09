using DependencyInjection_ASP.NET_Core.Abstracciones;
using Moq;
using System;
using Xunit;

namespace UnitTest
{
    public class PersonasModelTest
    {
        readonly IPersonasModel _personasModelFake;
        public PersonasModelTest(IPersonasModel personasModel)
        {
            _personasModelFake = personasModel;
        }
        [Fact]
        public void TraerPersona()
        {            
            var persona = _personasModelFake.TraerPersona("12345678");
            Assert.Equal("12345678", persona.Documento);
        }
    }
}
