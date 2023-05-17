using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Services
{
    public class PulquesServices
    {
        public List<Pulques> ObtenerPulques()
        {
            var pulques1 = new Pulques()
            {
                producto = "Pulque1",
                descripcion = "Piña Mango",
                litros = 10,
                produccion = new DateTime(2023, 12, 5)
            };

            var pulques2 = new Pulques()
            {
                producto = "Pulque2",
                descripcion = "Frutos Rojos",
                litros = 10,
                produccion = new DateTime(2023, 11, 8)
            };
            return new List<Pulques> { pulques1, pulques2 };
        }
    }
}