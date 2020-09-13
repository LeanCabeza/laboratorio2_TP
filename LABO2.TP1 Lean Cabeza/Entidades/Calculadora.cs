using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    /// <summary>
    /// Valida que el operador seleccionado este entre las opciones, sino devuelve "+".
    /// </summary>
    /// <param name="operador">El operador seleccionado por comboBox</param>
    /// <returns>El operador validado</returns>
    public static class Calculadora
        {
        private static string ValidarOperador(string operador)
        {

            if (operador != "+" && operador != "-" && operador != "*" && operador != "/")
            {
                operador = "+";
            }

            return operador;
        }

        /// <summary>
        /// Realiza la operación con los parametros recibidos.
        /// </summary>
        /// <param name="num1">Primer numero a operar</param>
        /// <param name="num2">Segundo numero a operar</param>
        /// <param name="oper">Operador indicado para la operacion</param>
        /// <returns>El resultado de la operacion como string</returns>
        /// 
        public static double Operar(Numero num1, Numero num2, string operador)
            {

                double rta = 0;

                switch (ValidarOperador(operador))
                {
                    case "+":
                        rta = (num1 + num2);
                        break;

                    case "-":
                        rta = (num1 - num2);
                        break;

                    case "*":
                        rta = (num1 * num2);
                        break;

                    case "/":
                        rta = num1 / num2;
                        break;
                }
                return rta;
            }
        }
    }
