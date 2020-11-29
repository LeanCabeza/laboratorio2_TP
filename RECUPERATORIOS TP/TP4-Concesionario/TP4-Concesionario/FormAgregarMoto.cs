using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validaciones;
using Entidades;

namespace TP4_Concesionario
{
    public partial class FormAgregarMoto : Form
    {
        public FormAgregarMoto()
        {
            InitializeComponent();
        }

        private void btn_AgregarPedido_Click(object sender, EventArgs e)
        {
            bool nombreOk = false;
            bool precioOk = false;
            bool anioFabricacionOk = false;
            bool kilometrajeOk = false;
            bool marcaMotoOk = false;
            bool tipoEncendidoOk = false;
            bool cilindradaOk = false;

            int precioAux;
            int anioFabricacionAux;
            int kilometrajeAux;
            int cilindradaAux;

            StringBuilder mensajeError = new StringBuilder();

            // Modelo  
            if (!(ValidacionesTexto.ValidarStringSoloLetrasNumerosEspacios(this.tb_modeloMoto.Text)))
            {
                mensajeError.AppendLine("Ocurrio un error con el modelo de la moto pedida");
            }
            else
            {
                nombreOk = true;
            }

            // Precio

            if (!(int.TryParse(this.tb_precioMoto.Text, out precioAux)))
            {
                mensajeError.AppendLine("Ocurrio un error con el precio de la moto");
            }
            else
            {
                precioOk = true;
            }

            //Año Fabricacion 

            if (!(int.TryParse(this.tb_AniomMoto.Text, out anioFabricacionAux)))
            {
                mensajeError.AppendLine("Ocurrio un error con el año de fabricacion de la moto");
            }
            else
            {
                anioFabricacionOk = true;
            }

            // Kilometraje 

            if (!(int.TryParse(this.tb_KilometrajeMoto.Text, out kilometrajeAux)))
            {
                mensajeError.AppendLine("Ocurrio un error con el kilometraje de la moto");
            }
            else
            {
                kilometrajeOk = true;
            }

            // Marca 

            if ((this.cb_MarcaMoto.SelectedIndex == -1))
            {
                mensajeError.AppendLine("Debe elegir una Marca");
            }
            else
            {
                marcaMotoOk = true;
            }

            // Encendido 

            if ((this.cb_TipoEncendidoMoto.SelectedIndex == -1))
            {
                mensajeError.AppendLine("Debe elegir un tipo encedido");
            }
            else
            {
                tipoEncendidoOk = true;
            }

            // Cilindrada

            if (!(int.TryParse(this.tb_CilindradaMoto.Text, out cilindradaAux)))
            {
                mensajeError.AppendLine("Ocurrio un error con la cilindrada de la moto");
            }
            else
            {
                cilindradaOk = true;
            }

            // Si se pasan las validadciones procedo a crear

            if (nombreOk && precioOk && anioFabricacionOk && kilometrajeOk && marcaMotoOk && tipoEncendidoOk && cilindradaOk)
            {
                Moto moto = new Moto(tb_modeloMoto.Text,int.Parse(tb_precioMoto.Text),int.Parse(tb_AniomMoto.Text),int.Parse(tb_KilometrajeMoto.Text),MapeoStringEMarcaMoto(cb_MarcaMoto.SelectedItem.ToString()), MapeoStringEEncedido(cb_TipoEncendidoMoto.SelectedItem.ToString()), int.Parse(tb_CilindradaMoto.Text));
                Concesionario.MotoFabricandose.Enqueue(moto);
                MessageBox.Show("Moto cargada con exito");
            }
            else
            {
                MessageBox.Show(mensajeError.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        /// <summary>
        /// Si le ingresas una marca en string , la retorna en EMarcaMoto
        /// </summary>
        /// <param name="aux"></param>
        /// <returns>Retorna lo ingresado en string como EMarcaMoto</returns></returns>
        public static EMarcaMoto MapeoStringEMarcaMoto(string aux)
        {
            switch (aux)
            {
                case "Honda":
                    return EMarcaMoto.Honda;
                case "Yamaha":
                    return EMarcaMoto.Yamaha;
                case "Suzuki":
                    return EMarcaMoto.Suzuki;
                default:
                    return EMarcaMoto.Indefinido;
            }
        }

        /// <summary>
        /// Si le ingresas un tipo de encedido en string , la retorna en EEncendido
        /// </summary>
        /// <param name="aux"></param>
        /// <returns>Retorna lo ingresado en string como EEncendido</returns></returns>
        public static EEncendido MapeoStringEEncedido(string aux)
        {
            switch (aux)
            {
                case "Carburador":
                    return EEncendido.Carburador;
                case "InyeccionElectronica":
                    return EEncendido.InyeccionElectronica;
                default:
                    return EEncendido.Indefinido;
            }
        }

    }
}
