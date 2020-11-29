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
        /// Guarda auto en txt
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True si se pudo guardar correctamente , false de lo contrario </returns>
        public static bool GuardarAuto(Auto obj)
        {
            if (obj != null)
            {
                StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath
                (Environment.SpecialFolder.Desktop) + @"\" + "VentasAutos" + ".txt", true);
                using (streamWriter)
                {
                   // Auto auxAuto = new Auto("Gol Power", 380000, 2008, 145000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 90);
                   // Moto auxMoto = new Moto("CG Titan", 160000, 2020, 0, EMarcaMoto.Honda, EEncendido.Carburador, 150);

                    streamWriter.Write(string.Format("\n -------------------------------------\n"
                                                    + DateTime.Now.ToString()
                                                    + "\n Modelo del auto : " + obj.NombreVehiculo.ToString() 
                                                    + "\n Precio  : $" + obj.Precio.ToString()
                                                    + "\n Año fabricacion: " + obj.AnioDeFabricacion.ToString()
                                                    + "\n Kilometraje: " + obj.Kilometraje.ToString()
                                                    + "\n Marca: " + obj.MarcaAuto.ToString()
                                                    + "\n Tipo Combustible: " + obj.TipoMotor.ToString()
                                                    + "\n Caballos de Fuerza: " + obj.CaballosDeFuerza.ToString()
                                                    ));
                }
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// Guarda moto en txt
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True si se pudo guardar correctamente , false de lo contrario </returns>
        public static bool GuardarMoto(Moto obj)
        {
            if (obj != null)
            {
                StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath
                (Environment.SpecialFolder.Desktop) + @"\" + "VentasMotos" + ".txt", true);
                using (streamWriter)
                {
                    streamWriter.Write(string.Format("\n ----------------------------------------------\n"
                                                    + DateTime.Now.ToString()
                                                    + "\n Modelo de la Moto : " + obj.NombreVehiculo.ToString()
                                                    + "\n Precio  : $" + obj.Precio.ToString()
                                                    + "\n Año fabricacion: " + obj.AnioDeFabricacion.ToString()
                                                    + "\n Kilometraje: " + obj.Kilometraje.ToString()
                                                    + "\n Marca: " + obj.MarcaMoto.ToString()
                                                    + "\n Tipo Encendido: " + obj.TipoEncendido.ToString()
                                                    + "\n Cilindrada: " + obj.Cilindrada.ToString()
                                                    ));
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
