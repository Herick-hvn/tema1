using IDGS901_tema1.Models;
using IDGS901_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace IDGS901_tema1.Controllers
{
    public class NuevoController : Controller
    {
        // GET: Nuevo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OperasBas(String n1, String n2, String name)
        {
            int op = Convert.ToInt16(name);
            int res = 0;
            switch (op)
            {
                case 1:
                    res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
                    break;
                case 2:
                    res = Convert.ToInt16(n1) - Convert.ToInt16(n2);
                    break;
                case 3:
                    res = Convert.ToInt16(n1) * Convert.ToInt16(n2);
                    break;
                case 4:
                    res = Convert.ToInt16(n1) / Convert.ToInt16(n2);
                    break;
            }
            
            ViewBag.Res = res;
            return View();
        }

        public ActionResult MuestraPulques()
        {
            var pulquesServices = new PulquesServices();
            var model = pulquesServices.ObtenerPulques();
            return View(model);
        }

        public ActionResult Calculos(OperasBas op, String name)
        {
            
            
            op.opcion(name);
            return View(op);
        }

    }
}