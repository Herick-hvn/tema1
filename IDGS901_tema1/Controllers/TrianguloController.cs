using IDGS901_tema1.Models;
using IDGS901_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class TrianguloController : Controller
    {
        private TrianguloService trianguloService;

        public TrianguloController()
        {
            trianguloService = new TrianguloService();
        }

        // GET: Triangulo
        public ActionResult Triangulo()
        {
            TrianguloModel trianguloModel = new TrianguloModel();
            return View();
        }

        // POST: Triangulo/Verificar
        [HttpPost]
        public ActionResult Verificar(TrianguloModel trianguloModel)
        {
            double ladoAB = trianguloService.CalcularDistancia(trianguloModel.PuntoA.X, trianguloModel.PuntoA.Y, trianguloModel.PuntoB.X, trianguloModel.PuntoB.Y);
            double ladoBC = trianguloService.CalcularDistancia(trianguloModel.PuntoB.X, trianguloModel.PuntoB.Y, trianguloModel.PuntoC.X, trianguloModel.PuntoC.Y);
            double ladoCA = trianguloService.CalcularDistancia(trianguloModel.PuntoC.X, trianguloModel.PuntoC.Y, trianguloModel.PuntoA.X, trianguloModel.PuntoA.Y);

            trianguloModel.EsTriangulo = trianguloService.EsTriangulo(ladoAB, ladoBC, ladoCA);

            if (trianguloModel.EsTriangulo)
            {
                trianguloModel.TipoTriangulo = trianguloService.ObtenerTipoTriangulo(ladoAB, ladoBC, ladoCA);
                trianguloModel.Area = trianguloService.CalcularArea(ladoAB, ladoBC, ladoCA);
                trianguloModel.ladoAB = ladoAB;
                trianguloModel.ladoBC = ladoBC;
                trianguloModel.ladoCA = ladoCA;



            }

            return View("Triangulo",trianguloModel);
        }
    }
}