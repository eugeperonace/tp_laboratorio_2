using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
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

        private static string ValidarOperador(char operador)
        {
            string retorno;

            if (operador != '+' || operador != '-' || operador != '*' || operador != '/')
                retorno = "+";

            else
                retorno = Convert.ToString(operador);

            return retorno;
        }
    }
}
