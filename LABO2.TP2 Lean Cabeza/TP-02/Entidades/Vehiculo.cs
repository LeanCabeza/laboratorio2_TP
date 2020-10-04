using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        #region Atributos 

        private EMarca marca;
        private string chasis;
        private ConsoleColor color;
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson,
        }
        public enum ETamanio
        {
            Chico, Mediano, Grande,
        }
        #endregion

        #region Constructores 

        /// <summary>
        /// Constructor vehiculos gral
        /// </summary>
        /// <param name="chasis">Chasis vehiculo</param>
        /// <param name="marca">Marca vehiculo</param>
        /// <param name="color">Color Vehiculo</param>

        public Vehiculo(string chasis, Vehiculo.EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }
        #endregion

        #region Propiedades 


        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract Vehiculo.ETamanio Tamanio { get;}

        #endregion

        #region Metodos

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        #endregion

        #region Sobrecargas

        public static explicit operator string (Vehiculo vehiculo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", vehiculo.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", vehiculo.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", vehiculo.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion

        #region Operadores 
        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return (!(v1.chasis == v2.chasis));
        }

        #endregion
    }
}
