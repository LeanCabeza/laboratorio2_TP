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
using Validaciones;

namespace TP4_Concesionario
{
    public partial class FormAgregarAuto : Form
    {
        public FormAgregarAuto()
        {
            InitializeComponent();
        }
        
        private void btn_AgregarPedidoAuto_Click(object sender, EventArgs e)
        {
            bool nombreOk = false;
            bool precioOk = false;
            bool anioFabricacionOk = false;
            bool kilometrajeOk = false;
            bool marcaAutoOk = false;
            bool tipoMotorOk = false;
            bool caballosFuerzaOk = false;

            int precioAux;
            int anioFabricacionAux;
            int kilometrajeAux;
            int caballosFuerzaAux;

            StringBuilder mensajeError = new StringBuilder();

            // Modelo  
            if (!(ValidacionesTexto.ValidarStringSoloLetrasNumerosEspacios(this.tb_modeloAuto.Text)))
            {
                mensajeError.AppendLine("Ocurrio un error con el modelo del auto pedido");
            }
            else
            {
                nombreOk = true;
            }

            // Precio

            if (!(int.TryParse(this.tb_precioAuto.Text, out precioAux)))
            {
                mensajeError.AppendLine("Ocurrio un error con el precio del auto");
            }
            else
            {
                precioOk = true;
            }

            //Año Fabricacion 

            if (!(int.TryParse(this.tb_anioAuto.Text, out anioFabricacionAux)))
            {
                mensajeError.AppendLine("Ocurrio un error con el año de fabricacion del auto");
            }
            else
            {
                anioFabricacionOk = true;
            }

            // Kilometraje 

            if (!(int.TryParse(this.tb_KilometrajeAuto.Text, out kilometrajeAux)))
            {
                mensajeError.AppendLine("Ocurrio un error con el kilometraje del auto");
            }
            else
            {
                kilometrajeOk = true;
            }

            // Marca 

            if ((this.cb_marcaAuto.SelectedIndex == -1))
            {
                mensajeError.AppendLine("Debe elegir una Marca");
            }
            else
            {
                marcaAutoOk = true;
            }

            // Tipo Motor 

            if ((this.cb_TipoMotorAuto.SelectedIndex == -1))
            {
                mensajeError.AppendLine("Debe elegir un tipo de combustible");
            }
            else
            {
                tipoMotorOk = true;
            }

            // Cilindrada

            if (!(int.TryParse(this.tb_caballosFuerzaAuto.Text, out caballosFuerzaAux)))
            {
                mensajeError.AppendLine("Ocurrio un error col los caballos de fuerza del auto");
            }
            else
            {
                caballosFuerzaOk = true;
            }

            // Si se pasan las validadciones procedo a crecar

            if (nombreOk && precioOk && anioFabricacionOk && kilometrajeOk && marcaAutoOk && tipoMotorOk && caballosFuerzaOk)
            {
                Auto auto = new Auto(tb_modeloAuto.Text, int.Parse(tb_precioAuto.Text), int.Parse(tb_anioAuto.Text), int.Parse(tb_KilometrajeAuto.Text), MapeoStringEMarcaAuto(cb_marcaAuto.SelectedItem.ToString()), MapeoStringETipoMotor(cb_TipoMotorAuto.SelectedItem.ToString()), int.Parse(tb_caballosFuerzaAuto.Text));
                Concesionario.AutoFabricandose.Enqueue(auto);
                MessageBox.Show("Auto cargada con exito");
            }
            else
            {
                MessageBox.Show(mensajeError.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }



        public static EMarcaAuto MapeoStringEMarcaAuto(string aux)
        {
            switch (aux)
            {
                case "Volkswagen":
                    return EMarcaAuto.Volkswagen;
                case "Ford":
                    return EMarcaAuto.Ford;
                case "Peugeot":
                    return EMarcaAuto.Peugeot;
                case "Toyota":
                    return EMarcaAuto.Toyota;
                default:
                    return EMarcaAuto.Indefinido;
            }
        }


        public static ETipoMotor MapeoStringETipoMotor(string aux)
        {
            switch (aux)
            {
                case "Nafta":
                    return ETipoMotor.Nafta;
                case "Diesel":
                    return ETipoMotor.Diesel;
                default:
                    return ETipoMotor.Indefinido;
            }
        }

    }
}

