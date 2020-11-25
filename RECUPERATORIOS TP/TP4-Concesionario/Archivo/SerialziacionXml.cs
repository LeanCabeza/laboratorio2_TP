using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Excepciones;

namespace Archivo
{
    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Guarda Xml
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>True si lo guardo , sino false</returns>
        public bool Guardar(string archivo, T datos)
        {
            try
            {
                if (archivo != null)
                {
                    using (XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(T));
                        ser.Serialize(writer, datos);
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                throw new ArchivoException("Error al intentar guardar archivo xml", e);
            }
            return false;
        }

        /// <summary>
        /// Lee Xml
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>True si lo leyo ,sino false</returns>
        public bool Leer(string archivo, out T datos)
        {
            datos = default(T);

            try
            {
                if (File.Exists(archivo))
                {
                    using (XmlTextReader reader = new XmlTextReader(archivo))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(T));
                        datos = (T)ser.Deserialize(reader);
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                throw new ArchivoException("Error al intentar leer archivo xml", e);
            }
            return false;
        }
    }
}
