using System;
using Microsoft.AspNetCore.Mvc;
using DependencyInjection_ASP.NET_Core.ViewModel;
using DependencyInjection_ASP.NET_Core.Abstracciones;

namespace DependencyInjection_ASP.NET_Core.Controllers
{
    public class CalcularController : Controller
    {
        private readonly ICalcularModel _calcularModel;
        private readonly IEdadModel _edadModel;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="calcularModel">Dependencia Inyectada</param>
        /// <param name="edadModel">Dependencia Inyectada</param>
        public CalcularController(ICalcularModel calcularModel,IEdadModel edadModel)
        {
            _calcularModel = calcularModel;
            _edadModel = edadModel;
        }

        public IActionResult Index()
        {
            return View(new CalculoViewModel());
        }

        public IActionResult IndexEdad()
        {
            return View(new EdadViewModel());
        }

        [HttpPost]
        public JsonResult CalcularOperacion (decimal primerNumero, decimal segundoNumero, Operacion tipoOperacion)
        {
            return Json(new { result = _calcularModel.Calcular(new CalculoViewModel() { PrimerNumero =primerNumero ,SegundoNumero=segundoNumero,TipoOperacion=tipoOperacion}) });
        }

        [HttpPost]
        public JsonResult CalcularEdad(DateTime fechanacimiento)
        {
            return Json(new { result = _edadModel.CalcularEdad(new EdadViewModel() { FechaNacimiento = fechanacimiento}) });
        }
    }
}
