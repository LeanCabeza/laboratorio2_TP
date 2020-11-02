using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {

        public bool Guardar(string archivo, T datos)
        {
            bool retorno = false;

            try
            {
                XmlSerializer s = new XmlSerializer(typeof(T));
                TextWriter w = new StreamWriter(archivo);
                s.Serialize(w, datos);
                w.Close();
                retorno = true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }

            return retorno;
        }


        public bool Leer(string archivo, out T datos)
        {
            bool retorno = false;

            try
            {
                XmlSerializer s = new XmlSerializer(typeof(T));
                TextReader r = new StreamReader(archivo);
                datos = (T)s.Deserialize(r);
                r.Close();
                retorno = true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }

            return retorno;
        }
    }
}