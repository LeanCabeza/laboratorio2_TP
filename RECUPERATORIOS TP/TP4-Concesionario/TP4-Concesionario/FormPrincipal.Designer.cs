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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_NroEntregados = new System.Windows.Forms.Label();
            this.lbl_NroFabricandose = new System.Windows.Forms.Label();
            this.btn_AgregarMoto = new System.Windows.Forms.Button();
            this.lbl_RecaudacionTotal = new System.Windows.Forms.Label();
            this.dgv_AutoEntregados = new System.Windows.Forms.DataGridView();
            this.dgv_AutoFabricandose = new System.Windows.Forms.DataGridView();
            this.lbl_VehiculosEntregados = new System.Windows.Forms.Label();
            this.lbl_AutosPorEntregar = new System.Windows.Forms.Label();
            this.btn_Pruebas = new System.Windows.Forms.Button();
            this.dgv_MotoFabricandose = new System.Windows.Forms.DataGridView();
            this.dgv_MotoEntregada = new System.Windows.Forms.DataGridView();
            this.lbl_NroMotosEntregadas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_NroMotosFabricandose = new System.Windows.Forms.Label();
            this.lbl_MotosFabricandose = new System.Windows.Forms.Label();
            this.btn_AgregarAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AutoEntregados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AutoFabricandose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MotoFabricandose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MotoEntregada)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NroEntregados
            // 
            this.lbl_NroEntregados.AutoSize = true;
            this.lbl_NroEntregados.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NroEntregados.Location = new System.Drawing.Point(851, 32);
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
            // btn_AgregarMoto
            // 
            this.btn_AgregarMoto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarMoto.Location = new System.Drawing.Point(38, 556);
            this.btn_AgregarMoto.Name = "btn_AgregarMoto";
            this.btn_AgregarMoto.Size = new System.Drawing.Size(219, 35);
            this.btn_AgregarMoto.TabIndex = 42;
            this.btn_AgregarMoto.Text = "Agregar Pedido Moto";
            this.btn_AgregarMoto.UseVisualStyleBackColor = true;
            this.btn_AgregarMoto.Click += new System.EventHandler(this.btn_AgregarMoto_Click);
            // 
            // lbl_RecaudacionTotal
            // 
            this.lbl_RecaudacionTotal.AutoSize = true;
            this.lbl_RecaudacionTotal.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecaudacionTotal.Location = new System.Drawing.Point(727, 583);
            this.lbl_RecaudacionTotal.Name = "lbl_RecaudacionTotal";
            this.lbl_RecaudacionTotal.Size = new System.Drawing.Size(233, 29);
            this.lbl_RecaudacionTotal.TabIndex = 41;
            this.lbl_RecaudacionTotal.Text = "Recaudacion Total";
            // 
            // dgv_AutoEntregados
            // 
            this.dgv_AutoEntregados.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_AutoEntregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AutoEntregados.Location = new System.Drawing.Point(660, 62);
            this.dgv_AutoEntregados.Name = "dgv_AutoEntregados";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_AutoEntregados.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_AutoEntregados.Size = new System.Drawing.Size(593, 200);
            this.dgv_AutoEntregados.TabIndex = 38;
            // 
            // dgv_AutoFabricandose
            // 
            this.dgv_AutoFabricandose.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dgv_AutoFabricandose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_AutoFabricandose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AutoFabricandose.Location = new System.Drawing.Point(38, 62);
            this.dgv_AutoFabricandose.Name = "dgv_AutoFabricandose";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_AutoFabricandose.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_AutoFabricandose.Size = new System.Drawing.Size(593, 200);
            this.dgv_AutoFabricandose.TabIndex = 37;
            // 
            // lbl_VehiculosEntregados
            // 
            this.lbl_VehiculosEntregados.AutoSize = true;
            this.lbl_VehiculosEntregados.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_VehiculosEntregados.Location = new System.Drawing.Point(656, 32);
            this.lbl_VehiculosEntregados.Name = "lbl_VehiculosEntregados";
            this.lbl_VehiculosEntregados.Size = new System.Drawing.Size(169, 19);
            this.lbl_VehiculosEntregados.TabIndex = 36;
            this.lbl_VehiculosEntregados.Text = "Autos Entregados : ";
            // 
            // lbl_AutosPorEntregar
            // 
            this.lbl_AutosPorEntregar.AutoSize = true;
            this.lbl_AutosPorEntregar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AutosPorEntregar.Location = new System.Drawing.Point(41, 32);
            this.lbl_AutosPorEntregar.Name = "lbl_AutosPorEntregar";
            this.lbl_AutosPorEntregar.Size = new System.Drawing.Size(184, 19);
            this.lbl_AutosPorEntregar.TabIndex = 35;
            this.lbl_AutosPorEntregar.Text = "Autos Fabricandose : ";
            // 
            // btn_Pruebas
            // 
            this.btn_Pruebas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pruebas.Location = new System.Drawing.Point(372, 484);
            this.btn_Pruebas.Name = "btn_Pruebas";
            this.btn_Pruebas.Size = new System.Drawing.Size(345, 28);
            this.btn_Pruebas.TabIndex = 45;
            this.btn_Pruebas.Text = "BOTON DE PRUEBAS , PELIGRO!!";
            this.btn_Pruebas.UseVisualStyleBackColor = true;
            this.btn_Pruebas.Click += new System.EventHandler(this.btn_Pruebas_Click);
            // 
            // dgv_MotoFabricandose
            // 
            this.dgv_MotoFabricandose.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dgv_MotoFabricandose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_MotoFabricandose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MotoFabricandose.Location = new System.Drawing.Point(38, 317);
            this.dgv_MotoFabricandose.Name = "dgv_MotoFabricandose";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_MotoFabricandose.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_MotoFabricandose.Size = new System.Drawing.Size(593, 161);
            this.dgv_MotoFabricandose.TabIndex = 46;
            // 
            // dgv_MotoEntregada
            // 
            this.dgv_MotoEntregada.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_MotoEntregada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MotoEntregada.Location = new System.Drawing.Point(660, 317);
            this.dgv_MotoEntregada.Name = "dgv_MotoEntregada";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_MotoEntregada.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_MotoEntregada.Size = new System.Drawing.Size(593, 161);
            this.dgv_MotoEntregada.TabIndex = 47;
            // 
            // lbl_NroMotosEntregadas
            // 
            this.lbl_NroMotosEntregadas.AutoSize = true;
            this.lbl_NroMotosEntregadas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NroMotosEntregadas.Location = new System.Drawing.Point(851, 282);
            this.lbl_NroMotosEntregadas.Name = "lbl_NroMotosEntregadas";
            this.lbl_NroMotosEntregadas.Size = new System.Drawing.Size(0, 19);
            this.lbl_NroMotosEntregadas.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(656, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "Motos Entregadas : ";
            // 
            // lbl_NroMotosFabricandose
            // 
            this.lbl_NroMotosFabricandose.AutoSize = true;
            this.lbl_NroMotosFabricandose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NroMotosFabricandose.Location = new System.Drawing.Point(242, 282);
            this.lbl_NroMotosFabricandose.Name = "lbl_NroMotosFabricandose";
            this.lbl_NroMotosFabricandose.Size = new System.Drawing.Size(0, 19);
            this.lbl_NroMotosFabricandose.TabIndex = 51;
            // 
            // lbl_MotosFabricandose
            // 
            this.lbl_MotosFabricandose.AutoSize = true;
            this.lbl_MotosFabricandose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MotosFabricandose.Location = new System.Drawing.Point(39, 282);
            this.lbl_MotosFabricandose.Name = "lbl_MotosFabricandose";
            this.lbl_MotosFabricandose.Size = new System.Drawing.Size(186, 19);
            this.lbl_MotosFabricandose.TabIndex = 50;
            this.lbl_MotosFabricandose.Text = "Motos Fabricandose : ";
            // 
            // btn_AgregarAuto
            // 
            this.btn_AgregarAuto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarAuto.Location = new System.Drawing.Point(38, 597);
            this.btn_AgregarAuto.Name = "btn_AgregarAuto";
            this.btn_AgregarAuto.Size = new System.Drawing.Size(219, 35);
            this.btn_AgregarAuto.TabIndex = 52;
            this.btn_AgregarAuto.Text = "Agregar Pedido Auto";
            this.btn_AgregarAuto.UseVisualStyleBackColor = true;
            this.btn_AgregarAuto.Click += new System.EventHandler(this.btn_AgregarAuto_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 644);
            this.Controls.Add(this.btn_AgregarAuto);
            this.Controls.Add(this.lbl_NroMotosFabricandose);
            this.Controls.Add(this.lbl_MotosFabricandose);
            this.Controls.Add(this.lbl_NroMotosEntregadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_MotoEntregada);
            this.Controls.Add(this.dgv_MotoFabricandose);
            this.Controls.Add(this.btn_Pruebas);
            this.Controls.Add(this.lbl_NroEntregados);
            this.Controls.Add(this.lbl_NroFabricandose);
            this.Controls.Add(this.btn_AgregarMoto);
            this.Controls.Add(this.lbl_RecaudacionTotal);
            this.Controls.Add(this.dgv_AutoEntregados);
            this.Controls.Add(this.dgv_AutoFabricandose);
            this.Controls.Add(this.lbl_VehiculosEntregados);
            this.Controls.Add(this.lbl_AutosPorEntregar);
            this.Name = "FormPrincipal";
            this.Text = "Concesionario de Leandro Cabeza 2ºD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AutoEntregados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AutoFabricandose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MotoFabricandose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MotoEntregada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NroEntregados;
        private System.Windows.Forms.Label lbl_NroFabricandose;
        private System.Windows.Forms.Button btn_AgregarMoto;
        private System.Windows.Forms.Label lbl_RecaudacionTotal;
        private System.Windows.Forms.DataGridView dgv_AutoEntregados;
        private System.Windows.Forms.DataGridView dgv_AutoFabricandose;
        private System.Windows.Forms.Label lbl_VehiculosEntregados;
        private System.Windows.Forms.Label lbl_AutosPorEntregar;
        private System.Windows.Forms.Button btn_Pruebas;
        private System.Windows.Forms.DataGridView dgv_MotoFabricandose;
        private System.Windows.Forms.DataGridView dgv_MotoEntregada;
        private System.Windows.Forms.Label lbl_NroMotosEntregadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_NroMotosFabricandose;
        private System.Windows.Forms.Label lbl_MotosFabricandose;
        private System.Windows.Forms.Button btn_AgregarAuto;
    }
}