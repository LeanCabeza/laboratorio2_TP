using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class GuardaString
    {

        /// <summary>
        /// Genero un archivo de texto y guarda el objeto ingresado por parametro, si no existe el archivo de texto lo crea y si existe lo escribe a lo ultimo 
        /// </summary>
        /// <param name="obj">Objeto a guardar en el txt</param>
        /// <returns> true si se pudo guardar , false sino</returns>
        public static bool Guardar(Vehiculo obj)
        {
            if (obj != null)
            {
                StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath
                (Environment.SpecialFolder.Desktop) + @"\" + "Ventas" + ".txt", true);
                using (streamWriter)
                {
                    streamWriter.Write(string.Format("\n -------------------------------------\n"
                                                    + DateTime.Now.ToString()
                                                    + "\n El pedido fue de : " + obj.NombreVehiculo.ToString() + "\n Tipo : " + obj.Precio.ToString()
                                                    + "\n Precio $" + obj.Precio.ToString()));
                }
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
