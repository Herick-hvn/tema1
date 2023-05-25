using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;


namespace IDGS901_tema1.Services
{
    public class TraductorService
    {
        private string archivoTraductor;

        public TraductorService()
        {
            archivoTraductor = HttpContext.Current.Server.MapPath("~/App_Data/Traductor.txt");
        }

        public void GuardarTraduccion(string palabraIngles, string palabraEspanol)
        {
            string nuevaLinea = $"{palabraIngles},{palabraEspanol}";
            File.AppendAllText(archivoTraductor, nuevaLinea + "\n");
        }

        public List<string> ObtenerTraducciones()
        {
            if (File.Exists(archivoTraductor))
            {
                return File.ReadAllLines(archivoTraductor).ToList();
            }
            else
            {
                return new List<string>();
            }
        }

        public string ObtenerTraduccion(string palabra, string idioma)
        {
            if (File.Exists(archivoTraductor))
            {
                List<string> traducciones = File.ReadAllLines(archivoTraductor).ToList();

                foreach (string traduccion in traducciones)
                {
                    string[] palabras = traduccion.Split(',');

                    if (palabras[0].Equals(palabra) && idioma.Equals("ingles", StringComparison.OrdinalIgnoreCase))
                    {
                        return palabras[1];
                    }
                    else if (palabras[1].Equals(palabra) && idioma.Equals("espanol", StringComparison.OrdinalIgnoreCase))
                    {
                        return palabras[0];
                    }
                }
            }

            return null;
        }


    }
}
