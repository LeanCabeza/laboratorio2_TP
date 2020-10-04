using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region Constructores 
        /// <summary>
        /// Constructor de Ciclomotor
        /// </summary>
        /// <param name="marca">Es la marca del ciclomotor</param>
        /// <param name="chasis">Es el chasis del ciclomotor</param>
        /// <param name="color">Es el color del ciclomotor</param>
        public Ciclomotor(Vehiculo.EMarca marca, string chasis, ConsoleColor color):base(chasis, marca, color)
        {
        }
        #endregion


        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        /// <summary>
        /// Sobreescribe el metodo heredado agregando las propiedades que tiene Ciclomotor
        /// </summary>
        /// <returns> Cadena con informacion del vehiculo</returns>

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}",this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
