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
            this.numero = double.Parse(strNumero);
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
            bool retorno = true;   //recorro los caracteres del string llamado binario y si                                      encuentro un caracter distinto a 1 o 0, devuelvo false.  

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

            
        }

        public string DecimalBinario(double decimal) 
        { 
        }

        public string DecimalBinario(string decimal)
        {

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
