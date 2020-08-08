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
    public class HomeController : Controller
    {
        private readonly ICalcularModel _calcularModel;

        public HomeController(ICalcularModel calcularModel)
        {
            _calcularModel = calcularModel;
        }

        public IActionResult Index()
        {
            return View(new CalculoViewModel());
        }

        [HttpPost]
        public JsonResult Calcular (decimal primerNumero, decimal segundoNumero, Operacion tipoOperacion)
        {
            return Json(new { result = _calcularModel.Calcular(new CalculoViewModel() { PrimerNumero =primerNumero ,SegundoNumero=segundoNumero,TipoOperacion=tipoOperacion}) });
        }
    }
}
