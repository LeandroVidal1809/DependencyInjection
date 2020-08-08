using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DependencyInjection_ASP.NET_Core.Models;
using DependencyInjection_ASP.NET_Core.ViewModel;
using System.Net;
using DependencyInjection_ASP.NET_Core.Abstracciones;

namespace DependencyInjection_ASP.NET_Core.Controllers
{
    public class CalcularController : Controller
    {
        private readonly ICalcularModel _calcularModel;
        private readonly IEdadModel _edadModel;

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
