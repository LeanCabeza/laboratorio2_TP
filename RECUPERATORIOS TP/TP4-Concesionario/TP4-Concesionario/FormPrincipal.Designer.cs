namespace TP4_Concesionario
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_NroEntregados = new System.Windows.Forms.Label();
            this.lbl_NroFabricandose = new System.Windows.Forms.Label();
            this.btn_AgregarVehiculo = new System.Windows.Forms.Button();
            this.lbl_RecaudacionTotal = new System.Windows.Forms.Label();
            this.btn_ActualizarEntregados = new System.Windows.Forms.Button();
            this.btn_ActualizarFabricandose = new System.Windows.Forms.Button();
            this.dgv_Entregados = new System.Windows.Forms.DataGridView();
            this.dgv_Fabricandose = new System.Windows.Forms.DataGridView();
            this.lbl_VehiculosEntregados = new System.Windows.Forms.Label();
            this.lbl_VehiculosPorEntregar = new System.Windows.Forms.Label();
            this.btn_Pruebas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entregados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fabricandose)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NroEntregados
            // 
            this.lbl_NroEntregados.AutoSize = true;
            this.lbl_NroEntregados.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NroEntregados.Location = new System.Drawing.Point(717, 32);
            this.lbl_NroEntregados.Name = "lbl_NroEntregados";
            this.lbl_NroEntregados.Size = new System.Drawing.Size(0, 19);
            this.lbl_NroEntregados.TabIndex = 44;
            // 
            // lbl_NroFabricandose
            // 
            this.lbl_NroFabricandose.AutoSize = true;
            this.lbl_NroFabricandose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NroFabricandose.Location = new System.Drawing.Point(231, 32);
            this.lbl_NroFabricandose.Name = "lbl_NroFabricandose";
            this.lbl_NroFabricandose.Size = new System.Drawing.Size(0, 19);
            this.lbl_NroFabricandose.TabIndex = 43;
            // 
            // btn_AgregarVehiculo
            // 
            this.btn_AgregarVehiculo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarVehiculo.Location = new System.Drawing.Point(38, 357);
            this.btn_AgregarVehiculo.Name = "btn_AgregarVehiculo";
            this.btn_AgregarVehiculo.Size = new System.Drawing.Size(145, 35);
            this.btn_AgregarVehiculo.TabIndex = 42;
            this.btn_AgregarVehiculo.Text = "Agregar Pedido";
            this.btn_AgregarVehiculo.UseVisualStyleBackColor = true;
            // 
            // lbl_RecaudacionTotal
            // 
            this.lbl_RecaudacionTotal.AutoSize = true;
            this.lbl_RecaudacionTotal.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecaudacionTotal.Location = new System.Drawing.Point(524, 363);
            this.lbl_RecaudacionTotal.Name = "lbl_RecaudacionTotal";
            this.lbl_RecaudacionTotal.Size = new System.Drawing.Size(233, 29);
            this.lbl_RecaudacionTotal.TabIndex = 41;
            this.lbl_RecaudacionTotal.Text = "Recaudacion Total";
            // 
            // btn_ActualizarEntregados
            // 
            this.btn_ActualizarEntregados.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActualizarEntregados.Location = new System.Drawing.Point(676, 268);
            this.btn_ActualizarEntregados.Name = "btn_ActualizarEntregados";
            this.btn_ActualizarEntregados.Size = new System.Drawing.Size(145, 35);
            this.btn_ActualizarEntregados.TabIndex = 40;
            this.btn_ActualizarEntregados.Text = "Recargar";
            this.btn_ActualizarEntregados.UseVisualStyleBackColor = true;
            // 
            // btn_ActualizarFabricandose
            // 
            this.btn_ActualizarFabricandose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActualizarFabricandose.Location = new System.Drawing.Point(178, 268);
            this.btn_ActualizarFabricandose.Name = "btn_ActualizarFabricandose";
            this.btn_ActualizarFabricandose.Size = new System.Drawing.Size(145, 35);
            this.btn_ActualizarFabricandose.TabIndex = 39;
            this.btn_ActualizarFabricandose.Text = "Recargar";
            this.btn_ActualizarFabricandose.UseVisualStyleBackColor = true;
            // 
            // dgv_Entregados
            // 
            this.dgv_Entregados.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_Entregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Entregados.Location = new System.Drawing.Point(526, 62);
            this.dgv_Entregados.Name = "dgv_Entregados";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Entregados.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Entregados.Size = new System.Drawing.Size(460, 200);
            this.dgv_Entregados.TabIndex = 38;
            // 
            // dgv_Fabricandose
            // 
            this.dgv_Fabricandose.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dgv_Fabricandose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Fabricandose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Fabricandose.Location = new System.Drawing.Point(38, 62);
            this.dgv_Fabricandose.Name = "dgv_Fabricandose";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Fabricandose.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Fabricandose.Size = new System.Drawing.Size(460, 200);
            this.dgv_Fabricandose.TabIndex = 37;
            // 
            // lbl_VehiculosEntregados
            // 
            this.lbl_VehiculosEntregados.AutoSize = true;
            this.lbl_VehiculosEntregados.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_VehiculosEntregados.Location = new System.Drawing.Point(531, 32);
            this.lbl_VehiculosEntregados.Name = "lbl_VehiculosEntregados";
            this.lbl_VehiculosEntregados.Size = new System.Drawing.Size(199, 19);
            this.lbl_VehiculosEntregados.TabIndex = 36;
            this.lbl_VehiculosEntregados.Text = "Vehiculos Entregados : ";
            // 
            // lbl_VehiculosPorEntregar
            // 
            this.lbl_VehiculosPorEntregar.AutoSize = true;
            this.lbl_VehiculosPorEntregar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VehiculosPorEntregar.Location = new System.Drawing.Point(38, 32);
            this.lbl_VehiculosPorEntregar.Name = "lbl_VehiculosPorEntregar";
            this.lbl_VehiculosPorEntregar.Size = new System.Drawing.Size(214, 19);
            this.lbl_VehiculosPorEntregar.TabIndex = 35;
            this.lbl_VehiculosPorEntregar.Text = "Vehiculos Fabricandose : ";
            // 
            // btn_Pruebas
            // 
            this.btn_Pruebas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pruebas.Location = new System.Drawing.Point(439, 268);
            this.btn_Pruebas.Name = "btn_Pruebas";
            this.btn_Pruebas.Size = new System.Drawing.Size(145, 71);
            this.btn_Pruebas.TabIndex = 45;
            this.btn_Pruebas.Text = "BOTON DE PRUEBAS , PELIGRO!!";
            this.btn_Pruebas.UseVisualStyleBackColor = true;
            this.btn_Pruebas.Click += new System.EventHandler(this.btn_Pruebas_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 406);
            this.Controls.Add(this.btn_Pruebas);
            this.Controls.Add(this.lbl_NroEntregados);
            this.Controls.Add(this.lbl_NroFabricandose);
            this.Controls.Add(this.btn_AgregarVehiculo);
            this.Controls.Add(this.lbl_RecaudacionTotal);
            this.Controls.Add(this.btn_ActualizarEntregados);
            this.Controls.Add(this.btn_ActualizarFabricandose);
            this.Controls.Add(this.dgv_Entregados);
            this.Controls.Add(this.dgv_Fabricandose);
            this.Controls.Add(this.lbl_VehiculosEntregados);
            this.Controls.Add(this.lbl_VehiculosPorEntregar);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entregados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fabricandose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NroEntregados;
        private System.Windows.Forms.Label lbl_NroFabricandose;
        private System.Windows.Forms.Button btn_AgregarVehiculo;
        private System.Windows.Forms.Label lbl_RecaudacionTotal;
        private System.Windows.Forms.Button btn_ActualizarEntregados;
        private System.Windows.Forms.Button btn_ActualizarFabricandose;
        private System.Windows.Forms.DataGridView dgv_Entregados;
        private System.Windows.Forms.DataGridView dgv_Fabricandose;
        private System.Windows.Forms.Label lbl_VehiculosEntregados;
        private System.Windows.Forms.Label lbl_VehiculosPorEntregar;
        private System.Windows.Forms.Button btn_Pruebas;
    }
}