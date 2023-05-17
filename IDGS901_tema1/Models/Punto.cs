using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace IDGS901_tema1.Models
{
    public class Punto
    {
        public int num1 {  get; set; }
        public int num2 { get; set; }
        public int res { get; set; } 

        public void Suma()
        {
            this.res = this.num1 + this.num2;
        }

        public void Resta()
        {
            this.res = this.num1 - this.num2;
        }

        public void Multiplicacion()
        {
            this.res = this.num1 * this.num2;
        }

        public void Division()
        {
            this.res = this.num1 / this.num2;
        }

        public void opcion(String name)
        {
            int opcion = Convert.ToInt16(name);
            switch (opcion)
            {
                case 1:
                    Suma();
                    break;
                case 2:
                    Resta();
                    break;
                case 3:
                    Multiplicacion();
                    break;
                case 4:
                    Division();
                    break;
            }
        }
    }
}