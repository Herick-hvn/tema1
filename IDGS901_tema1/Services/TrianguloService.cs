using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Services
{
    public class TrianguloService
    {
        public double CalcularDistancia(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        public double CalcularArea(double ladoAB, double ladoBC, double ladoCA)
        {
            double semiperimetro = (ladoAB + ladoBC + ladoCA) / 2;
            return Math.Sqrt(semiperimetro * (semiperimetro - ladoAB) * (semiperimetro - ladoBC) * (semiperimetro - ladoCA));
        }

        public bool EsTriangulo(double ladoAB, double ladoBC, double ladoCA)
        {
            return ladoAB + ladoBC > ladoCA && ladoBC + ladoCA > ladoAB && ladoCA + ladoAB > ladoBC;
        }

        public string ObtenerTipoTriangulo(double ladoAB, double ladoBC, double ladoCA)
        {
            if (ladoAB == ladoBC && ladoBC == ladoCA)
            {
                return "Equilátero";
            }
            else if (ladoAB == ladoBC || ladoBC == ladoCA || ladoCA == ladoAB)
            {
                return "Isósceles";
            }
            else
            {
                return "Escaleno";
            }
        }


    }
}