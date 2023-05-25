using System.Collections.Generic;
using System.Web.Mvc;
using IDGS901_tema1.Models;
using IDGS901_tema1.Services;

namespace IDGS901_tema1.Controllers
{
    public class TraductorController : Controller
    {
        private TraductorService traductorService;

        public TraductorController()
        {
            traductorService = new TraductorService();
        }

        // GET: Traductor/Crear
        public ActionResult Crear()
        {
            List<string> traducciones = traductorService.ObtenerTraducciones();
            ViewBag.Traducciones = traducciones;
            return View();
        }

        // POST: Traductor/Guardar
        [HttpPost]
        public ActionResult Guardar(TraductorModel.PalabraTraducida palabraTraducida)
        {
            if (ModelState.IsValid)
            {
                traductorService.GuardarTraduccion(palabraTraducida.PalabraIngles, palabraTraducida.PalabraEspanol);
                TempData["SuccessMessage"] = "La palabra ha sido guardada correctamente.";
                return RedirectToAction("Crear");
            }
            else
            {
                return View(palabraTraducida);
            }
        }

        // GET: Traductor/Mostrar
        public ActionResult Mostrar()
        {
            List<string> traducciones = traductorService.ObtenerTraducciones();
            return View(traducciones);
        }

        // GET: Traductor/Traducir
        public ActionResult Traducir()
        {
            return View();
        }

        // POST: Traductor/Traducir
        [HttpPost]
        public ActionResult Traducir(string palabra, string idioma)
        {
            // Realizar la traducción utilizando el servicio correspondiente

            return View();
        }

        // GET: Traductor/Buscar
        public ActionResult Buscar()
        {
            return View();
        }

        // POST: Traductor/Buscar
        [HttpPost]
        public ActionResult Buscar(string palabra, string idioma)
        {
            if (!string.IsNullOrEmpty(palabra))
            {
                string traduccion = traductorService.ObtenerTraduccion(palabra, idioma);

                if (!string.IsNullOrEmpty(traduccion))
                {
                    ViewBag.Traduccion = traduccion;
                }
                else
                {
                    ViewBag.Mensaje = "La palabra no está en el diccionario.";
                }
            }

            return View();
        }



    }
}
