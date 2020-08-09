using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection_ASP.NET_Core.Abstracciones;
using DependencyInjection_ASP.NET_Core.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection_ASP.NET_Core.Controllers
{
    public class PersonasController : Controller
    {
        readonly IPersonasModel _personasModel;
        public PersonasController(IPersonasModel personasModel)
        {
            _personasModel = personasModel;
        }
        public IActionResult Index()
        {
            return View(new PersonaViewModel()) ;
        }

        [HttpPost]
        public JsonResult TraerDatosPersona(string documento)
        {
            return Json(new { result = _personasModel.TraerPersona(documento)});
        }
    }
}
