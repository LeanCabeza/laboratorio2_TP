using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;// Para validar los email

namespace Validaciones
{
    public class ValidacionesTexto
    {
        #region ValidarStringSoloLetras

        //Valida que el string NO este vacio y que SOLO contenga numeros

        public static bool ValidarStringSoloLetras(string cadena)
        {
            char[] alfabeto = "abcdefghijklmñnopqrstuvwxyz".ToCharArray();
            bool retorno = true;
            int contador = 0;

            //Verifico que la cadena NO este vacia.

            if (cadena == string.Empty)
            {
                retorno = false;
            }
            else
            {

                foreach (char c in cadena)
                {
                    for (int i = 0; i < alfabeto.Length; i++)
                    {
                        //Verifico que la cadena SOLO contenga letras

                        if (c.ToString().ToLower() == alfabeto[i].ToString())
                        {
                            contador++;
                        }
                    }
                }

                //Si estos 2 parametros NO coinciden es porque algun caracter de la cadena NO era una letra.

                if (contador != cadena.Length)
                {
                    retorno = false;
                }
            }

            return retorno;
        }

        #endregion

        #region ValidarStringSoloNumeros

        //Valida que el string NO este vacio y que SOLO contenga numeros

        public static bool ValidarStringSoloNumeros(string cadena)
        {
            char[] numeros = "0123456789".ToCharArray();
            bool retorno = true;
            int contador = 0;

            //Verifico que la cadena NO este vacia.

            if (cadena == string.Empty)
            {
                retorno = false;
            }
            else
            {

                foreach (char c in cadena)
                {
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        //Verifico que la cadena SOLO contenga numeros

                        if (c.ToString().ToLower() == numeros[i].ToString())
                        {
                            contador++;
                        }
                    }
                }

                //Si estos 2 parametros NO coinciden es porque algun caracter de la cadena NO era un numero.

                if (contador != cadena.Length)
                {
                    retorno = false;
                }
            }

            return retorno;
        }

        #endregion

        #region ValidarStringSoloLetras/Numeros

        //Valida que el string NO este vacio y que SOLO contenga numeros

        public static bool ValidarStringSoloLetrasNumeros(string cadena)
        {
            char[] alfabeto_numeros = "abcdefghijklmñnopqrstuvwxyz0123456789".ToCharArray();
            bool retorno = true;
            int contador = 0;

            //Verifico que la cadena NO este vacia.

            if (cadena == string.Empty)
            {
                retorno = false;
            }
            else
            {

                foreach (char c in cadena)
                {
                    for (int i = 0; i < alfabeto_numeros.Length; i++)
                    {
                        //Verifico que la cadena SOLO contenga letras Y numeros.

                        if (c.ToString().ToLower() == alfabeto_numeros[i].ToString())
                        {
                            contador++;
                        }
                    }
                }

                //Si estos 2 parametros NO coinciden es porque algun caracter de la cadena no era una letra o un numero.

                if (contador != cadena.Length)
                {
                    retorno = false;
                }
            }

            return retorno;
        }

        #endregion

        #region ValidarStringSoloLetras/Numeros/Espacios

        //Valida que el string NO este vacio y que SOLO contenga numeros, letras o espacios

        public static bool ValidarStringSoloLetrasNumerosEspacios(string cadena)
        {
            char[] alfabeto_numeros_espacio = "abcdefghijklmñnopqrstuvwxyz0123456789 ".ToCharArray();
            bool retorno = true;
            int contador_espacios = 0;
            int contador = 0;

            //Verifico que la cadena no contega SOLAMENTE espacios

            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == ' ')
                {
                    contador_espacios++;
                }
            }

            if (contador_espacios == cadena.Length)
            {
                retorno = false;
            }

            //Verifico que la cadena NO este vacia.

            if (cadena == string.Empty)
            {
                retorno = false;
            }
            else
            {
                foreach (char c in cadena)
                {
                    for (int i = 0; i < alfabeto_numeros_espacio.Length; i++)
                    {
                        //Verifico que la cadena SOLO contenga letras , numeros, espacios.

                        if (c.ToString().ToLower() == alfabeto_numeros_espacio[i].ToString())
                        {
                            contador++;
                        }
                    }
                }

                //Si estos 2 parametros NO coinciden es porque algun caracter de la cadena NO era un numero o una letra o espacio.

                if (contador != cadena.Length)
                {
                    retorno = false;
                }
            }

            return retorno;
        }

        #endregion

        #region Validar_Email
        public static Boolean Validar_Email(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion

    }
}
