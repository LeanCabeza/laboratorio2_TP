using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class BaseDeDatosExeption:Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mensaje"></param>
        public BaseDeDatosExeption(string mensaje) : base(mensaje)
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="innerException"></param>
        public BaseDeDatosExeption(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }


    }
}
