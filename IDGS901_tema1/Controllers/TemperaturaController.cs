using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDGS901_tema1.Models;

namespace IDGS901_tema1.Controllers
{
    public class TemperaturaController : Controller
    {
        // GET: Temperatura
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Temperatura()
        {
            var temperatura = new TemperaturaModel();
            return View(temperatura);
        }

        [HttpPost]
        public ActionResult Calcular(TemperaturaModel model)
        {
            if (ModelState.IsValid)
            {
                model.CalcularConversion();
                return View("Resultado", model);
            }

            return View("Temperatura", model);
        }
    }
}