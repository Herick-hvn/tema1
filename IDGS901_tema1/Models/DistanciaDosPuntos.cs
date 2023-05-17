using System;

namespace IDGS901_tema1.Models
{
    public class DistanciaDosPuntos
    {
        public double Punto1X { get; set; }
        public double Punto1Y { get; set; }
        public double Punto2X { get; set; }
        public double Punto2Y { get; set; }
        public double Resultado { get; set; }

        public void CalcularDistancia()
        {
            // Fórmula para calcular la distancia entre dos puntos
            double deltaX = Punto2X - Punto1X;
            double deltaY = Punto2Y - Punto1Y;
            Resultado = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}
