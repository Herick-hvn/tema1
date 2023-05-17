using System.Web.Mvc;
using IDGS901_tema1.Models;

namespace IDGS901_tema1.Controllers
{
    public class DistanciaController : Controller
    {
        // GET: Distancia
        public ActionResult DistanciaDosPuntos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calcular(DistanciaDosPuntos modelo)
        {
            if (ModelState.IsValid)
            {
                modelo.CalcularDistancia();
                return View("ResultadosDistanciaEntre2Puntos", modelo);
            }

            // Si el modelo no es válido, vuelve a la vista del formulario
            return View("DistanciaDosPuntos", modelo);
        }   
    }
}
