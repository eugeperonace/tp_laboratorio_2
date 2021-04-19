using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza la operación correspondiente entre ambos números recibidos por parámetro.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns> retorna el valor de la operación realizada.
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;

            char operadorChar = Convert.ToChar(operador);
            string operadorValidado = ValidarOperador(operadorChar);

                switch (operadorValidado)
                {
                    case "+":
                        resultado = num1 + num2;
                        break;
                    case "-":
                        resultado = num1 - num2;
                        break;
                    case "*":
                        resultado = num1 * num2;
                        break;
                    case "/":
                        resultado = num1 / num2;
                        break;
                    default:
                        break;
                }

            return resultado;
        }


        /// <summary>
        /// Valida que el operador recibido sea +,-,*,/
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns> retorna el caracter correspondiente si logró validarlo.
        private static string ValidarOperador(char operador)
        {
            string retorno = "+";
            if (operador == '/' || operador == '*' || operador == '-' || operador == '+')
            {
                retorno = operador.ToString();
            }
            return retorno;
        }
    }
}
