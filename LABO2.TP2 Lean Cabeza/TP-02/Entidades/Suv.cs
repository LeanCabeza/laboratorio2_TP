using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv:Vehiculo
    {
        #region Constructores
        /// <summary>
        /// Constructor de SUV
        /// </summary>
        /// <param name="marca">Marca de la suv</param>
        /// <param name="chasis">Chasis de la suv</param>
        /// <param name="color">Color de la suv</param>
        public Suv(Vehiculo.EMarca marca, string chasis, ConsoleColor color): base(chasis, marca, color)
        {
        }

        #endregion

        #region Propiedades 
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get { return ETamanio.Grande; }
        }
        #endregion
        #region "Metodos"
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}",this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
