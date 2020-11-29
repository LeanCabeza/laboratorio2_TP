using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class BaseDeDatosExeption:Exception
    {

        public BaseDeDatosExeption(string mensaje) : base(mensaje)
        {

        }


        public BaseDeDatosExeption(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }


    }
}
