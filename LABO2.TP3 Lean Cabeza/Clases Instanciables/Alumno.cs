using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    public sealed class Alumno : Universitario
    {
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        #region Constructores
        /// <summary>
        /// Constructor por defecto de Alumno
        /// </summary>
        public Alumno()
        {

        }

        /// <summary>
        /// Constructor de Alumno parametrizado
        /// </summary>
        /// <param name="id">Id del Alumno</param>
        /// <param name="nombre">Nombre del Alumno</param>
        /// <param name="apellido">Apellido del Alumno</param>
        /// <param name="dni">Dni dell Alumno</param>
        /// <param name="nacionalidad">Nacionalidad del Alumno</param>
        /// <param name="claseQueToma"> Clase que toma el Alumno</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        /// <summary>
        /// Constructor de Alumno parametrizado
        /// </summary>
        /// <param name="id">Id del Alumno</param>
        /// <param name="nombre">Nombre del Alumno</param>
        /// <param name="apellido">Apellido del Alumno</param>
        /// <param name="dni">Dni dell Alumno</param>
        /// <param name="nacionalidad">Nacionalidad del Alumno</param>
        /// <param name="claseQueToma"> Clase que toma el Alumno</param>
        /// <param name="estadoCuenta">Estado de cuenta d</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Retorna un string con los datos del alumno
        /// </summary>
        /// <returns>cadena con la informacion del alumno</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            string auxiliar = "";
            sb.AppendLine(base.MostrarDatos());
            switch (this.estadoCuenta)
            {
                case EEstadoCuenta.AlDia:
                    auxiliar = "Cuota al día";
                    break;
                case EEstadoCuenta.Becado:
                    auxiliar = "Becado";
                    break;
                case EEstadoCuenta.Deudor:
                    auxiliar = "Deudor";
                    break;
            }

            sb.AppendLine("ESTADO DE LA CUENTA : " +auxiliar);
            sb.AppendLine(this.ParticiparEnClase());

            return sb.ToString();
        }

        /// <summary>
        /// Se encarga de hacer publica la informacion del alumno llamando a MostrarDatos
        /// </summary>
        /// <returns>cadena con la informacion del alumno</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        /// <summary>
        /// Retorna una cadena con el nombre de la clase que toma el alumno
        /// </summary>
        /// <returns>cadena con la informacion de la clase</returns>
        protected override string ParticiparEnClase()
        {
            return String.Format($"TOMA CLASE DE  {this.claseQueToma}");
        }

        #endregion

        #region Sobrecarga Operadores
        /// <summary>
        /// Verfiica si un alumno participa en una clase especifica ingresada por parametro
        /// </summary>
        /// <param name="a">alumno a comparar</param>
        /// <param name="clase">clase a comparar</param>
        /// <returns>true si toma la clase, false caso contrario
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            bool retorno = false;

            if (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                retorno = true;
            }

            return retorno;
        }
        /// <summary>
        /// Verifica si un alumno NO participa en una clase espeicifica
        /// </summary>
        /// <param name="a">alumno a comparar</param>
        /// <param name="clase">clase a comparar</param>
        /// <returns>true si NO toma la clase, false en caso de que SI tome la clase</returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
                return (!(a == clase));
        }

        #endregion
    }
}
