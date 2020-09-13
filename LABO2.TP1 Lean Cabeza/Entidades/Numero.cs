using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Inicializa el tipo Numero en 0.
        /// </summary>
        public Numero() : this(0)
        {

        }

        /// <summary>
        /// Inicializara un tipo Numero segun el parametro indicado como string.
        /// </summary>
        /// <param name="strNumero">El numero recibido por parametro como string</param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        /// <summary>
        /// Inicializara un tipo Numero segun el parametro indicado.
        /// </summary>
        /// <param name="numero">El valor con el que se inicia</param>
        public Numero(double numero):this(numero.ToString())
        {

        }

        /// <summary>
        /// Asigna a un tipo Numero el parametro que fue pasado como string, lo validara y guardara en tipo Numero.
        /// </summary>
        /// <param name="strNumero">String a validar y guardar</param>
        public String SetNumero
        {
            set { this.numero = ValidarNumero(value); }
        }

        /// <summary>
        /// Valida que el string que nos pasen por parametro sea un numero y devolvera como double de ser posible, sino como 0.
        /// </summary>
        /// <param name="strNumero">El numero recibido como string.</param>
        /// <returns>El numero validado y pasado a double.</returns>
        private static double ValidarNumero(string strNumero)
        {
            double numero;

            // Si no puede hacer el tryparse , dara false y como esta negado ( va ser true) y entra en el if y hara num = 0 .
            if (!double.TryParse(strNumero, out numero))
            {
                numero = 0;
            }
            return numero;
        }

        /// <summary>
        /// Convierte el numero binario pasado como string en un decimal y lo retorna como string.
        /// </summary>
        /// <param name="binario">String a convertir.</param>
        /// <returns>String convertido a decimal.</returns>
        public static string BinarioDecimal(string binario)
        {
            double numero = 0;
            string retorno;

            if (EsBinario(binario))
            {
                for (int i = binario.Length - 1, j = 0; i >= 0; i--, j++)
                {
                    numero += (double)(double.Parse(binario[i].ToString()) * Math.Pow(2, j));
                }
                retorno = numero.ToString();
            }
            else
            {
                retorno = "Valor Invalido.";
            }

            return retorno;
        }

        /// <summary>
        /// Convierte el numero decimal pasado (tipo string) por parametro  a binario y lo retornara.
        /// </summary>
        /// <param name="numero">String a convertir</param>
        /// <returns>String ya convertido a binario</returns>
        public static string DecimalBinario(string numero)
        {
            return DecimalBinario(double.Parse(numero));
        }

        /// <summary>
        /// Convierte el numero decimal pasado (tipo double) por parametro  a binario y lo retornara.
        /// </summary>
        /// <param name="numero">Double a convertir</param>
        /// <returns>String ya convertido a binario</returns>
        public static string DecimalBinario(double numero)
        {
            string rta = "";
            string aux = "";
            long numeroAux = (long)numero;

            if (numeroAux != 1)
            {
                long i;

                for (i = numeroAux; i != 0 && i != 1; i /= 2)
                {
                    rta = (i % 2) + rta;
                }

                if (i == 0)
                {
                    aux += "0";
                }
                else
                {
                    rta = 1 + rta;
                    aux += rta;
                }
            }
            else
            {
                aux += "1";
            }

            return aux;
        }

        /// <summary>
        /// Crea la operacion "sumar" de tipo "Numero" y devuelve el resultado como double.
        /// </summary>
        /// <param name="num1">Primer numero a sumar</param>
        /// <param name="num2">Segundo numero a sumar</param>
        /// <returns>Resultado de la suma como double</returns>
        public static double operator + (Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }

        /// <summary>
        /// Crea la operacion "restar" de tipo "Numero" y devuelve el resultado como double.
        /// </summary>
        /// <param name="num1">Primero numero a restar</param>
        /// <param name="num2">Segundo numero a restar</param>
        /// <returns>Resultado de la resta como double</returns>
        public static double operator - (Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }

        /// <summary>
        /// Crea la operacion "multiplicar" de tipo "Numero" y devuelve el resultado como double.
        /// </summary>
        /// <param name="num1">Primer numero a multiplicar</param>
        /// <param name="num2">Segundo numero a multiplicar</param>
        /// <returns>Resultado de la multiplicacion como double</returns>
        public static double operator * (Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }

        /// <summary>
        /// Crea la operacion "dividir" de tipo "Numero" y devuelve el resultado como double.
        /// y devuelve el resultado como double.
        /// </summary>
        /// <param name="num1">Dividendo de la división</param>
        /// <param name="num2">Divisor de la división</param>
        /// <returns>Resultado de la division como double</returns>
        public static double operator / (Numero num1, Numero num2)
        {
            double retorno = 0;

            if (num2.numero == 0)
            {
                // Como pide en el enunciado , si se divide por 0 retorna el double.MinValue ( menor valor posible de un double)
                retorno = double.MinValue;
            }
            else
            {
                // Division standard en caso de que todo salga bien.
                retorno = num1.numero / num2.numero;
            }

            return retorno;
        }

        private static bool EsBinario(string binario)
        {
            bool retorno = true;

            foreach (char x in binario)
            {
                // Con foreach por cada elemento que tenga el string "binario" ,lo comparare mediante Equals a 0 o 1 , de no ser 0 o 1 , retornara false.

                if (!(x.Equals('1') || x.Equals('0')))
                {
                    retorno = false;
                }
            }

            return retorno;
        }
    }
}