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

    }
}
