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
        Numero num1 = new Numero();
        Numero num2 = new Numero();
        string oper;
        bool flag; // Para controlar los pasajes a bin y decimal

        public FormCalculadora()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Iniciar();
        }


        private void btn_Operar_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = Calculadora.Operar(num1, num2, oper).ToString();
            flag = false;

        /* Intento de alerta en el front end que fallo , la idea era que al poner un punto en txtBox , tire un msje de alerta.
         * 
         
            foreach (var x in num1.ToString())
            {
                if (x.Equals('.'))
                {
                  MessageBox.Show("Recorda que para ingresar numeros decimales se usa la (,) , no el punto (.)", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }
            }

         */
        }
        
        /// <summary>
        /// Reinicia los textbox, combobox y label a su origen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        /// <summary>
        /// Finaliza el programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// En caso de ser false flag, convierte el lblResultado
        /// en binario y lo muestra por el mismo. Pone a flag en true.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ConvABin_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                lbl_Resultado.Text = Numero.DecimalBinario(lbl_Resultado.Text);

                flag = true;
            }
        }

        /// <summary>
        /// En caso de ser true flag, convierte el lblResultado
        /// en decimal y lo muestra por el mismo. Pone a flag en false.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ConvADec_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                lbl_Resultado.Text = Numero.BinarioDecimal(lbl_Resultado.Text);

                flag = false;
            }
        }

        /// <summary>
        /// Guarda el numero escrito en num1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            num1 = new Numero(this.txtNum1.Text);
        }

        /// <summary>
        /// Guarda el numero escrito en num2.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            num2 = new Numero(this.txtNum2.Text);
        }


        /// <summary>
        /// Guarda el operador seleccionado en oper.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cb_Operador_SelectedIndexChanged(object sender, EventArgs e)
        {
            oper = Cb_Operador.Text;
        }

        /// <summary>
        /// Se borra lo que este en txtNum1 y txtNum2.
        /// Se pone el lblResultado en 0.
        /// </summary>
        private void Iniciar()
        {
            flag = false;

            lbl_Resultado.Text = "0";
            txtNum1.Text = "";
            txtNum2.Text = "";
            Cb_Operador.SelectedIndex = -1;
        }
    }
}
      
