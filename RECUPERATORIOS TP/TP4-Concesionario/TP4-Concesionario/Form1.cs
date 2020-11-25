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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_Prueba_Click(object sender, EventArgs e)
        {
            // DESESTIMAR  --> Hardcodeando pedidos en un xml.
            // Concesionario.SerializarPedidosAutos();
               Concesionario.SerializarPedidosMotos();

        }
    }
}
