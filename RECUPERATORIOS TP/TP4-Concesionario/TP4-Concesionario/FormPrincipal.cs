using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;
using Archivo;

namespace TP4_Concesionario
{
    public delegate bool DelegadoTxTAuto(Auto auto);
    public delegate bool DelegadoTxTMoto(Moto moto);


    public partial class FormPrincipal : Form
    {

        Thread hiloRefresh;
        Thread hiloVenta;

        // Declaro el evento que va imprimir el ticket 
        public event DelegadoTxTAuto txtPrinterAuto;
        public event DelegadoTxTMoto txtPrinterMoto;

        // Acumulador de $$$ de las ventas.
        int total = 0;

        public FormPrincipal()
        {
            InitializeComponent();
            hiloRefresh = new Thread(this.AutoRefresh);
            hiloVenta = new Thread(this.AgregarAuto);
            hiloVenta.Start();

            Concesionario.SerializarPedidosMotos();
            Concesionario.SerializarPedidosAutos();

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                if (Concesionario.CargaAutosDelXml() && Concesionario.CargarMotosDelXml())
                {
                   MessageBox.Show(@"Se crearon pedidos por defecto", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(@"No se pueieron crear pedidos por defecto", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                RefreshDataGrids();

                //Le asocio el manejador al evento.
                txtPrinterAuto += GuardaString.GuardarAuto;
                txtPrinterMoto += GuardaString.GuardarMoto;


                if (!hiloRefresh.IsAlive)
                {
                    hiloRefresh.Start();
                }
                else
                {
                    hiloRefresh.Abort();
                    hiloRefresh.Start();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        /// <summary>
        /// Refresca automaticamente y en caso de que haya pedidos los processa , actualiza los data grids y suma los totales
        /// </summary>
        private void AutoRefresh()
        {
            while (true)
            {
                // Muestra Recaudacion el Total
                if (this.lbl_RecaudacionTotal.InvokeRequired)
                {
                    this.lbl_RecaudacionTotal.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.lbl_RecaudacionTotal.Text = "Recauldacion total : $ " + total.ToString();
                    });
                }

       
                if (Concesionario.AutoFabricandose.Count > 0)
                {
                    Auto autoAux;
                    autoAux = Concesionario.AutoFabricandose.Dequeue(); // Saco de preparandose
                    total = autoAux.Precio + total;
                    Concesionario.AutoEntregado.Enqueue(autoAux); // Pongo en entregado
                    ConexionBD.SubirAuto(autoAux);// Subo a la bdd lo entregado

                    RefreshDataGrids();// Refresco data grid

                    txtPrinterAuto.Invoke(autoAux);// Imprimo ticket



                    if (this.lbl_NroFabricandose.InvokeRequired && this.lbl_NroEntregados.InvokeRequired)
                    {
                        this.lbl_NroFabricandose.BeginInvoke((MethodInvoker)delegate ()
                        {
                            lbl_NroFabricandose.Text = Concesionario.Count(Concesionario.AutoFabricandose);
                        });
                        this.lbl_NroEntregados.BeginInvoke((MethodInvoker)delegate ()
                        {
                            lbl_NroEntregados.Text = Concesionario.Count(Concesionario.AutoEntregado);
                        });
                    }

                }

                if (Concesionario.MotoFabricandose.Count > 0)
                {
                    Moto motoAux;
                    motoAux = Concesionario.MotoFabricandose.Dequeue();

                    total = motoAux.Precio + total;

                    Concesionario.MotoEntregada.Enqueue(motoAux);
                    ConexionBD.SubirMoto(motoAux);

                    RefreshDataGrids();

                    txtPrinterMoto.Invoke(motoAux);


                    if (this.lbl_NroMotosFabricandose.InvokeRequired && this.lbl_NroEntregados.InvokeRequired)
                    {
                        this.lbl_NroFabricandose.BeginInvoke((MethodInvoker)delegate ()
                        {
                            lbl_NroMotosFabricandose.Text = Concesionario.Count(Concesionario.MotoFabricandose).ToString();
                        });
                        this.lbl_NroEntregados.BeginInvoke((MethodInvoker)delegate ()
                        {
                            lbl_NroMotosEntregadas.Text = Concesionario.Count(Concesionario.MotoEntregada).ToString();
                        });
                    }
                }
                Thread.Sleep(5500);
            }
        }


        /// <summary>
        /// Actualiza la data de todos los data grid 
        /// </summary>
        public void RefreshDataGrids()
        {
            if (this.dgv_AutoEntregados.InvokeRequired)
            {
                this.dgv_AutoEntregados.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.dgv_AutoEntregados.DataSource = null;
                    this.dgv_AutoEntregados.DataSource = Concesionario.AutoEntregado.ToArray();
                });
            }
            if (this.dgv_MotoEntregada.InvokeRequired )
            {
                this.dgv_MotoEntregada.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.dgv_MotoEntregada.DataSource = null;
                    this.dgv_MotoEntregada.DataSource = Concesionario.MotoEntregada.ToArray();
                });

            }
            if (this.dgv_AutoFabricandose.InvokeRequired)
            {
                this.dgv_AutoFabricandose.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.dgv_AutoFabricandose.DataSource = null;
                    this.dgv_AutoFabricandose.DataSource = Concesionario.AutoFabricandose.ToArray();
                });
            }
            if (this.dgv_MotoFabricandose.InvokeRequired)
            {
                this.dgv_MotoFabricandose.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.dgv_MotoFabricandose.DataSource = null;
                    this.dgv_MotoFabricandose.DataSource = Concesionario.MotoFabricandose.ToArray();
                });
            }
        }

        /// <summary>
        /// Muestra el formulario de agregar auto
        /// </summary>
        public void AgregarAuto()
        {
            FormAgregarAuto FormAgregarAuto = new FormAgregarAuto();
            FormAgregarAuto.ShowDialog();
        }

        /// <summary>
        /// Mustra el formulario de agregar Moto
        /// </summary>
        public void AgregarMoto()
        {
            FormAgregarMoto FormAgregarMoto = new FormAgregarMoto();
            FormAgregarMoto.ShowDialog();
        }

        private void btn_AgregarAuto_Click(object sender, EventArgs e)
        {
            AgregarAuto();
        }

        private void btn_AgregarMoto_Click(object sender, EventArgs e)
        {
            AgregarMoto();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
                hiloRefresh.Abort();
                hiloVenta.Abort();
        }
    }
}
