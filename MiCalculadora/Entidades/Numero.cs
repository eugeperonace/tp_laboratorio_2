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

        Numero()
        {
            this.numero = 0;
        }

        Numero(double numero)
        {
            this.numero = numero;
        }

        Numero(string numero)
        {

        }

        public double ValidarNumero(string strNumero)
        {
            double retorno;
            retorno = 0;

            return retorno;
        }

        public string SetNumero
        {
            //previa validación con método ValidarNumero
            set { }
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

        private bool EsBinario(string binario)
        {

        }
    }
}
