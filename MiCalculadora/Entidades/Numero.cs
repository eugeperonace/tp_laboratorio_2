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

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        public double ValidarNumero(string strNumero)
        {
            double numero, retorno;

            if (double.TryParse(strNumero, out numero))
            {
                retorno = numero;
            }
            else
            {
                retorno = 0;
            }
            return retorno;
        }

        public string SetNumero
        {
            //previa validación con método ValidarNumero
            set { numero = ValidarNumero(value); }
        }

        private bool EsBinario(string binario)
        {
            bool retorno = true;   //recorro los caracteres del string llamado binario y si encuentro un caracter distinto a 1 o 0, devuelvo false.  

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario.ToCharArray()[i] != '0' && binario.ToCharArray()[i] != '1')
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }

        public string BinarioDecimal(string binario)
        {
            int resto = 0, exponente = 0, resultado = 0;

            if (EsBinario(binario))
            {
                int numero = int.Parse(binario);
                do
                {
                    resto = numero % 10; //guardo en la variable el resto entre el numero ingresado y 10111
                    numero = numero / 10;
                    resultado += (int)(resto * Math.Pow(2, exponente)); //resultado es igual al resto multiplicado por 2 elevado al exponente 
                    exponente++; //incremento el exponente (el cual inicia en cero)
                }while (numero > 0);
            }
            else
            {
                Console.WriteLine("Valor inválido.\n");
            }
            return resultado.ToString();
        }

        public string DecimalBinario(double numero) 
        {
            string retorno;

            string numeroString = Convert.ToString(numero);

            retorno = DecimalBinario(numeroString);

            return retorno;
        }

        public string DecimalBinario(string numero)
        {
            int numeroDecimal = int.Parse(numero);
            string binario = " ";

            if (numeroDecimal <= 0)
            {
                Console.WriteLine("Valor inválido.\n");
            }

            while (numeroDecimal > 0)
            {
                if (numeroDecimal % 2 == 0) //si el resto entre dividir el núm. ingresado y 2 es "0",
                    binario = "0" + binario; //entonces agrego un núm. "0" al inicio de la cadena,
                else
                    binario = "1" + binario; //encambio si el resto es "1", agrego un "1" al inicio de la cadena

                numeroDecimal = numeroDecimal / 2; //divido por 2 el núm. ingresado y me guardo el resultado en la misma variable para, en la próxima vuelta, poder dividir ese resultado por 2
            }
            return binario.ToString();
        }

        public static double operator -(Numero n1, Numero n2)
        {
            double resultado = n1.numero - n2.numero;
            return resultado;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            double resultado = n1.numero * n2.numero;
            return resultado;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            double resultado;

            if (n2.numero == 0)
                resultado = double.MinValue;
            
            else
                resultado = n1 / n2;
            
            return resultado;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            double resultado = n1 + n2;
            return resultado;
        }
    }
}
