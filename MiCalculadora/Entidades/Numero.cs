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
        /// Constructor que inicializa el atributo "numero" con 0.
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor que recibe un numero en formato double e inicializa al atributo numero de la class Numero.
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor que recibe un numero en formato string e inicializa al atributo numero de la class Numero.
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        /// <summary>
        /// Valida que el string ingresado sea un numero
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns> devuelve el numero validado en formato double, si no retorna 0.
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

        /// <summary>
        /// Es una propiedad que setea el numero recibido por parámetro al atributo número.
        /// </summary>
        public string SetNumero
        {
            //previa validación con método ValidarNumero
            set { this.numero = ValidarNumero(value); }
        }

        private bool EsBinario(string binario)
        {
            bool retorno = true; //recorro los caracteres del string llamado binario y si encuentro un caracter distinto a 1 o 0, devuelvo false.  

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

        /// <summary>
        /// Convierte un numero binario, recibido en formato string, a decimal.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns> devuelve el numero convertido a decimal, en formato string.
        public string BinarioDecimal(string binario)
        {
            int resto = 0, exponente = 0, resultado = 0;

            if (EsBinario(binario))
            {
                int numero = Convert.ToInt32(binario); //int.Parse(binario);
                do
                {
                    resto = numero % 10; //guardo en la variable el resto entre el numero ingresado y 10
                    numero = numero / 10;
                    resultado += (int)(resto * Math.Pow(2, exponente)); //resultado es igual al resto multiplicado por 2 elevado al exponente 
                    exponente++; //incremento el exponente (el cual inicia en cero)
                } while (numero > 0);
            }
            else
            {
                Console.WriteLine("Valor inválido.\n");
            }
            return resultado.ToString();

        }

        /// <summary>
        /// Convierte un numero decimal, recibido en formato double, a binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns> devuelve el numero convertido a binario, en formato string.
        public string DecimalBinario(double numero) 
        {
            string retorno;

            string numeroString = Convert.ToString(numero);

            retorno = DecimalBinario(numeroString);

            return retorno;
        }

        /// <summary>
        /// Convierte un numero decimal, recibido en formato string, a binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns> devuelve el numero convertido a binario, en formato string.
        public string DecimalBinario(string numero)
        {
            int numeroDecimal = Convert.ToInt32(numero);
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

        /// <summary>
        /// Sobrecarga de operador "-". Realiza la resta entre los numeros pasados por parámetro.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns> devuelve el resultado obtenido.
        public static double operator -(Numero n1, Numero n2)
        {
            double resultado = n1.numero - n2.numero;
            return resultado;
        }

        /// <summary>
        /// Sobrecarga de operador "*". Realiza la multiplicacion entre los numeros pasados por parámetro.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns> devuelve el resultado obtenido.
        public static double operator *(Numero n1, Numero n2)
        {
            double resultado = n1.numero * n2.numero;
            return resultado;
        }

        /// <summary>
        /// Sobrecarga de operador "/". Realiza la división entre los numeros pasados por parámetro.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns> devuelve el resultado obtenido.
        public static double operator /(Numero n1, Numero n2)
        {
            double resultado;

            if (n2.numero == 0)
                resultado = double.MinValue;
            
            else
                resultado = n1.numero / n2.numero;
            
            return resultado;
        }

        /// <summary>
        /// Sobrecarga de operador "+". Realiza la suma entre los numeros pasados por parámetro.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns> devuelve el resultado obtenido.
        public static double operator +(Numero n1, Numero n2)
        {
            double resultado = 0;
            resultado = n1.numero + n2.numero;
            return resultado;
        }
    }
}
