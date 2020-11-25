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

namespace TP4_Concesionario
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btn_Pruebas_Click(object sender, EventArgs e)
        {
            /*  Prueba para ver si sube bien a la bdd.
                Resultado : Sube Perfecto

             Auto auxAuto = new Auto("Gol Power", 380000, 2008, 145000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 90);
             Moto auxMoto = new Moto("CG Titan",160000,2020,0,EMarcaMoto.Honda,EEncendido.Carburador,150);
            ConexionBD.SubirAuto(auxAuto);
            ConexionBD.SubirMoto(auxMoto);*/
        }
    }
}
