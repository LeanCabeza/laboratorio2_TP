using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivoException : Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mensaje"></param>
        public ArchivoException(string mensaje) : base(mensaje)
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="innerException"></param>
        public ArchivoException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }

    }
}