using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;



namespace Clases_Instanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        #region Constructores

        static Profesor()
        {
            random = new Random();
        }

        public Profesor()
        {

        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
            this._randomClases();
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Asinga una clase aleatoria al profesor
        /// </summary>
        private void _randomClases()
        {
            switch (random.Next(4))
            {
                case ((int)Universidad.EClases.Programacion):
                    {
                        this.clasesDelDia.Enqueue(Universidad.EClases.Programacion);
                    }
                    break;

                case ((int)Universidad.EClases.Laboratorio):
                    {
                        this.clasesDelDia.Enqueue(Universidad.EClases.Laboratorio);
                    }
                    break;

                case ((int)Universidad.EClases.Legislacion):
                    {
                        this.clasesDelDia.Enqueue(Universidad.EClases.Legislacion);
                    }
                    break;

                case ((int)Universidad.EClases.SPD):
                    {
                        this.clasesDelDia.Enqueue(Universidad.EClases.SPD);
                    }
                    break;
            }
        }

        /// <summary>
        /// Devuelve en string con todas las clases que dicta el profesor
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASES DEL DIA: ");

            foreach (Universidad.EClases item in this.clasesDelDia)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Retorna un string con los datos del profesor
        /// </summary>
        /// <returns>cadena con la informacion del profesor</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }

        /// <summary>
        /// Muestra la informacion del profesor llamando a MostrarDatos
        /// </summary>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion

        #region Comparadores

        /// <summary>
        /// Verifica si un profesor da una clase indicada por parametro 
        /// </summary>
        /// <param name="i">profesor</param>
        /// <param name="clase">clase en la que queremos averiguar si esta el profe</param>
        /// <returns>true si el profesor da la clase, de lo contrario retorna false</returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            bool retorno = false;

            foreach (Universidad.EClases item in i.clasesDelDia)
            {
                if (item == clase)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Verifica si un profesor NO DA  una clase indicada por parametro 
        /// </summary>
        /// <param name="i">profesor</param>
        /// <param name="clase">clase en la que queremos averiguar si esta el profe</param>
        /// <returns>true si el profesor NO da la clase, de lo contrario retorna false</returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return (!(i == clase));
        }

        #endregion
    }
}
