using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Models
{
    public class TrianguloModel
    {
        public PuntoModel PuntoA { get; set; }
        public PuntoModel PuntoB { get; set; }
        public PuntoModel PuntoC { get; set; }
        public bool EsTriangulo { get; set; }
        public string TipoTriangulo { get; set; }
        public double Area { get; set; }
        public double ladoAB { get; set; } 
        public double ladoBC { get; set; }
        public double ladoCA { get; set; }



    }
    public class PuntoModel
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}