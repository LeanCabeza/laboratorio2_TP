using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Clases_Abstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad { Argentino, Extranjero };

        private string nombre;
        private string apellido;
        private ENacionalidad nacionalidad;
        private int dni;


        #region Propiedades

        /// <summary>
        /// get: retorna el nombre.
        /// set: valida el nombre y lo asigna.
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                if (ValidarNombreApellido(value).Length > 0)
                {
                    this.nombre = value;
                }
            }
        }

        // <summary>
        /// get: retorna el apellido.
        /// set: valida el apellido y lo asigna.
        /// </summary>

        public string Apellido
        {
            get{ return this.apellido; }
            set{
                if (ValidarNombreApellido(value).Length > 0)
                {
                    this.apellido = value;
                }
            }
        }

        /// <summary>
        /// get: retorna la nacionalidadd.
        /// set: settea la nacionalidad
        /// </summary>

        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }

        /// <summary>
        /// get: retorna el DNI.
        /// set: valida el DNI y lo asigna.
        /// </summary>
        /// 
        public int Dni
        {
            get { return this.dni; }
            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);
            }
        }

        /// <summary>
        /// valida el DNI y lo asigna.
        /// </summary>
        /// 

        public string StringToDni
        {
            set { this.dni = ValidarDni(this.nacionalidad, value); }
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de persona por defecto.
        /// </summary>
        public Persona()
        {

        }

        /// <summary>
        /// Constructor de persona parametrizado.
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="apellido">Apellido de la persona.</param>
        /// <param name="nacionalidad">Nacionalidad de la persona.</param>
        /// 
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }

        /// <summary>
        /// Constructor de persona parametrizado.
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="apellido">Apellido de la persona.</param>
        /// <param name="dni">DNI de la persona.</param>
        /// <param name="nacionalidad">Nacionalidad de la persona.</param>


        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad):this(nombre, apellido, nacionalidad)
        {
            this.dni = dni;
        }

        /// <summary>
        /// Constructor de persona parametrizado.
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="apellido">Apellido de la persona.</param>
        /// <param name="dni">DNI de la persona.</param>
        /// <param name="nacionalidad">Nacionalidad de la persona.</param>

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad):this(nombre, apellido, nacionalidad)
        {
            this.StringToDni = dni;
        }

        #endregion


        #region Metodos


        /// <summary>
        /// Valida que el numero Dni este entre los valores aceptados.
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        /// <param name="dato">Dni que se va validar</param>
        /// <returns>Dni validado</returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            int retorno = dato;

            switch (nacionalidad)
            {
                case ENacionalidad.Argentino:
                    {
                        if (dato < 1 || dato > 89999999)
                        {
                            throw new NacionalidadInvalidaException();
                        }
                    }
                    break;

                case ENacionalidad.Extranjero:
                    {
                        if (dato < 90000000 || dato > 99999999)
                        {
                            throw new NacionalidadInvalidaException();
                        }
                    }
                    break;
            }

            return retorno;
        }

        /// <summary>
        /// Valida que el dni tenga la cantidad de caracteres aceptados y que sea numerico.
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        /// <param name="dato">Dni a validar</param>
        /// <returns>Dni validado</returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int retorno = 0;
            int auxValidacion = 0;

            bool cantCharsValida = dato.Length <= 8;
            bool esNumerico = int.TryParse(dato, out auxValidacion);

            if (esNumerico && cantCharsValida)
            {
                retorno = ValidarDni(nacionalidad, auxValidacion);
            }
            else
            {
                throw new DniInvalidoException();
            }
            return retorno;
        }

      /// <summary>
      /// Valida que el apellido este compuesto solo de letras.
      /// </summary>
      /// <param name="dato">Apellido a validar</param>
      /// <returns>Apellido validado</returns>
        private string ValidarNombreApellido(string dato)
        {
            string retorno = string.Empty;

            if (ValidarStringSoloLetras(dato))
            {
                retorno = dato;
            }
            return retorno;
        }

        /// <summary>
        /// Valida que una cadena de datos ingresados sea solo de string
        /// </summary>
        /// <param name="dato">String a validar</param>
        /// <returns>True : En caso de que cumpla con los requisitos , False de lo contrario</returns>

        public static bool ValidarStringSoloLetras(string dato)
        {
            char[] alfabeto = "abcdefghijklmñnopqrstuvwxyz".ToCharArray();
            bool retorno = true;
            int contador = 0;

            if (dato == string.Empty)
            {
                retorno = false;
            }
            else
            {
                foreach (char c in dato)
                {
                    for (int i = 0; i < alfabeto.Length; i++)
                    {
                        if (c.ToString().ToLower() == alfabeto[i].ToString())
                        {
                            contador++;
                        }
                    }
                }

                if (contador != dato.Length)
                {
                    retorno = false;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Formatea datos
        /// </summary>
        /// <returns>Datos Formeateados</returns>

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE COMPLETO: " + this.apellido + ", " + this.nombre);
            sb.AppendLine("NACIONALIDAD: " + this.nacionalidad);

            return sb.ToString();
        }

        #endregion
    }
}