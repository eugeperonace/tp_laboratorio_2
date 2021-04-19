using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// Constructor del formulario.
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            lblResultado.Text = resultado.ToString();
        }

        /// <summary>
        /// Evento que se ejecuta cuando el usuario hace click en el botón Cerrar. Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento que se ejecuta cuando el usuario hace click en el botón Limpiar. Limpia el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Evento que se ejecuta cuando el usuario hace click en el botón Convertir A Binario. Convierte un decimal a binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero();
            lblResultado.Text = numero.DecimalBinario(lblResultado.Text);
        }

        /// <summary>
        /// Evento que se ejecuta cuando el usuario hace click en el botón Convertir A Decimal. Convierte un binario a decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero();

            if (EsBinario(lblResultado.Text))
                lblResultado.Text = numero.BinarioDecimal(lblResultado.Text);
        }

        /// <summary>
        /// Método que valida si el string ingresado es un numero binario.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns> retorna true si es binario y false si no lo es.
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
        /// Método encargado de realizar la operacion correspondiente entre dos numeros.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns> retorna el resultado.
        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado;

            Numero n1 = new Numero(numero1);
            Numero n2 = new Numero(numero2);

            resultado = Calculadora.Operar(n1,n2,operador);

            return resultado;
        }

        /// <summary>
        /// Método que limpia el formulario.
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "";
            lblResultado.Text = "";
        }

    }
}
