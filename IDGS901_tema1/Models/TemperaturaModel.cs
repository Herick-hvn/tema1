using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IDGS901_tema1.Models
{
    public class TemperaturaModel
    {
        [Required]
        [Display(Name = "Temperatura")]
        public double Temperatura { get; set; }

        [Required]
        [Display(Name = "Escala")]
        public string Escala { get; set; }

        [Display(Name = "Resultado")]
        public double Resultado { get; set; }

        public void CalcularConversion()
        {
            if (Escala == "Celsius")
            {
                Resultado = (Temperatura * 9 / 5) + 32;
            }
            else if (Escala == "Fahrenheit")
            {
                Resultado = (Temperatura - 32) * 5 / 9;
            }
        }
    }
}