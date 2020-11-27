namespace TP4_Concesionario
{
    partial class FormAgregarMoto
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
            this.tb_CilindradaMoto = new System.Windows.Forms.TextBox();
            this.lbl_CilindradaMoto = new System.Windows.Forms.Label();
            this.cb_TipoEncendidoMoto = new System.Windows.Forms.ComboBox();
            this.lbl_EncendidoMoto = new System.Windows.Forms.Label();
            this.cb_MarcaMoto = new System.Windows.Forms.ComboBox();
            this.lbl_MarcaMoto = new System.Windows.Forms.Label();
            this.tb_KilometrajeMoto = new System.Windows.Forms.TextBox();
            this.lbl_KilometrajeMoto = new System.Windows.Forms.Label();
            this.tb_AniomMoto = new System.Windows.Forms.TextBox();
            this.lbl_anioMoto = new System.Windows.Forms.Label();
            this.btn_AgregarPedido = new System.Windows.Forms.Button();
            this.tb_precioMoto = new System.Windows.Forms.TextBox();
            this.lbl_PrecioMoto = new System.Windows.Forms.Label();
            this.lbl_Pedido = new System.Windows.Forms.Label();
            this.tb_modeloMoto = new System.Windows.Forms.TextBox();
            this.lbl_ModeloMoto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_CilindradaMoto
            // 
            this.tb_CilindradaMoto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CilindradaMoto.Location = new System.Drawing.Point(339, 215);
            this.tb_CilindradaMoto.Name = "tb_CilindradaMoto";
            this.tb_CilindradaMoto.Size = new System.Drawing.Size(211, 27);
            this.tb_CilindradaMoto.TabIndex = 80;
            // 
            // lbl_CilindradaMoto
            // 
            this.lbl_CilindradaMoto.AutoSize = true;
            this.lbl_CilindradaMoto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CilindradaMoto.Location = new System.Drawing.Point(333, 193);
            this.lbl_CilindradaMoto.Name = "lbl_CilindradaMoto";
            this.lbl_CilindradaMoto.Size = new System.Drawing.Size(80, 19);
            this.lbl_CilindradaMoto.TabIndex = 79;
            this.lbl_CilindradaMoto.Text = "Cilindrada";
            // 
            // cb_TipoEncendidoMoto
            // 
            this.cb_TipoEncendidoMoto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TipoEncendidoMoto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TipoEncendidoMoto.FormattingEnabled = true;
            this.cb_TipoEncendidoMoto.Items.AddRange(new object[] {
            "Carburador",
            "InyeccionElectronica",
            "Indefinido"});
            this.cb_TipoEncendidoMoto.Location = new System.Drawing.Point(337, 163);
            this.cb_TipoEncendidoMoto.Name = "cb_TipoEncendidoMoto";
            this.cb_TipoEncendidoMoto.Size = new System.Drawing.Size(212, 27);
            this.cb_TipoEncendidoMoto.TabIndex = 78;
            // 
            // lbl_EncendidoMoto
            // 
            this.lbl_EncendidoMoto.AutoSize = true;
            this.lbl_EncendidoMoto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EncendidoMoto.Location = new System.Drawing.Point(333, 141);
            this.lbl_EncendidoMoto.Name = "lbl_EncendidoMoto";
            this.lbl_EncendidoMoto.Size = new System.Drawing.Size(141, 19);
            this.lbl_EncendidoMoto.TabIndex = 77;
            this.lbl_EncendidoMoto.Text = "Tipo de Encendido";
            // 
            // cb_MarcaMoto
            // 
            this.cb_MarcaMoto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MarcaMoto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MarcaMoto.FormattingEnabled = true;
            this.cb_MarcaMoto.Items.AddRange(new object[] {
            "Honda",
            "Yamaha",
            "Suzuki",
            "Indefinido"});
            this.cb_MarcaMoto.Location = new System.Drawing.Point(338, 111);
            this.cb_MarcaMoto.Name = "cb_MarcaMoto";
            this.cb_MarcaMoto.Size = new System.Drawing.Size(212, 27);
            this.cb_MarcaMoto.TabIndex = 76;
            // 
            // lbl_MarcaMoto
            // 
            this.lbl_MarcaMoto.AutoSize = true;
            this.lbl_MarcaMoto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MarcaMoto.Location = new System.Drawing.Point(334, 89);
            this.lbl_MarcaMoto.Name = "lbl_MarcaMoto";
            this.lbl_MarcaMoto.Size = new System.Drawing.Size(129, 19);
            this.lbl_MarcaMoto.TabIndex = 75;
            this.lbl_MarcaMoto.Text = "Marca de la Moto";
            // 
            // tb_KilometrajeMoto
            // 
            this.tb_KilometrajeMoto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_KilometrajeMoto.Location = new System.Drawing.Point(60, 267);
            this.tb_KilometrajeMoto.Name = "tb_KilometrajeMoto";
            this.tb_KilometrajeMoto.Size = new System.Drawing.Size(211, 27);
            this.tb_KilometrajeMoto.TabIndex = 74;
            // 
            // lbl_KilometrajeMoto
            // 
            this.lbl_KilometrajeMoto.AutoSize = true;
            this.lbl_KilometrajeMoto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KilometrajeMoto.Location = new System.Drawing.Point(60, 245);
            this.lbl_KilometrajeMoto.Name = "lbl_KilometrajeMoto";
            this.lbl_KilometrajeMoto.Size = new System.Drawing.Size(89, 19);
            this.lbl_KilometrajeMoto.TabIndex = 73;
            this.lbl_KilometrajeMoto.Text = "Kilometraje";
            // 
            // tb_AniomMoto
            // 
            this.tb_AniomMoto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AniomMoto.Location = new System.Drawing.Point(60, 215);
            this.tb_AniomMoto.Name = "tb_AniomMoto";
            this.tb_AniomMoto.Size = new System.Drawing.Size(211, 27);
            this.tb_AniomMoto.TabIndex = 72;
            // 
            // lbl_anioMoto
            // 
            this.lbl_anioMoto.AutoSize = true;
            this.lbl_anioMoto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anioMoto.Location = new System.Drawing.Point(60, 193);
            this.lbl_anioMoto.Name = "lbl_anioMoto";
            this.lbl_anioMoto.Size = new System.Drawing.Size(122, 19);
            this.lbl_anioMoto.TabIndex = 71;
            this.lbl_anioMoto.Text = "Año Fabricacion";
            // 
            // btn_AgregarPedido
            // 
            this.btn_AgregarPedido.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.btn_AgregarPedido.Location = new System.Drawing.Point(402, 299);
            this.btn_AgregarPedido.Name = "btn_AgregarPedido";
            this.btn_AgregarPedido.Size = new System.Drawing.Size(196, 36);
            this.btn_AgregarPedido.TabIndex = 70;
            this.btn_AgregarPedido.Text = "Agregar Pedido";
            this.btn_AgregarPedido.UseVisualStyleBackColor = true;
            this.btn_AgregarPedido.Click += new System.EventHandler(this.btn_AgregarPedido_Click);
            // 
            // tb_precioMoto
            // 
            this.tb_precioMoto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_precioMoto.Location = new System.Drawing.Point(60, 163);
            this.tb_precioMoto.Name = "tb_precioMoto";
            this.tb_precioMoto.Size = new System.Drawing.Size(211, 27);
            this.tb_precioMoto.TabIndex = 69;
            // 
            // lbl_PrecioMoto
            // 
            this.lbl_PrecioMoto.AutoSize = true;
            this.lbl_PrecioMoto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrecioMoto.Location = new System.Drawing.Point(56, 141);
            this.lbl_PrecioMoto.Name = "lbl_PrecioMoto";
            this.lbl_PrecioMoto.Size = new System.Drawing.Size(52, 19);
            this.lbl_PrecioMoto.TabIndex = 68;
            this.lbl_PrecioMoto.Text = "Precio";
            // 
            // lbl_Pedido
            // 
            this.lbl_Pedido.AutoSize = true;
            this.lbl_Pedido.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pedido.Location = new System.Drawing.Point(35, 23);
            this.lbl_Pedido.Name = "lbl_Pedido";
            this.lbl_Pedido.Size = new System.Drawing.Size(276, 23);
            this.lbl_Pedido.TabIndex = 67;
            this.lbl_Pedido.Text = "Formulario de compra moto";
            // 
            // tb_modeloMoto
            // 
            this.tb_modeloMoto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_modeloMoto.Location = new System.Drawing.Point(59, 111);
            this.tb_modeloMoto.Name = "tb_modeloMoto";
            this.tb_modeloMoto.Size = new System.Drawing.Size(213, 27);
            this.tb_modeloMoto.TabIndex = 66;
            // 
            // lbl_ModeloMoto
            // 
            this.lbl_ModeloMoto.AutoSize = true;
            this.lbl_ModeloMoto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ModeloMoto.Location = new System.Drawing.Point(56, 89);
            this.lbl_ModeloMoto.Name = "lbl_ModeloMoto";
            this.lbl_ModeloMoto.Size = new System.Drawing.Size(141, 19);
            this.lbl_ModeloMoto.TabIndex = 65;
            this.lbl_ModeloMoto.Text = "Modelo de la moto";
            // 
            // FormAgregarMoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 352);
            this.Controls.Add(this.tb_CilindradaMoto);
            this.Controls.Add(this.lbl_CilindradaMoto);
            this.Controls.Add(this.cb_TipoEncendidoMoto);
            this.Controls.Add(this.lbl_EncendidoMoto);
            this.Controls.Add(this.cb_MarcaMoto);
            this.Controls.Add(this.lbl_MarcaMoto);
            this.Controls.Add(this.tb_KilometrajeMoto);
            this.Controls.Add(this.lbl_KilometrajeMoto);
            this.Controls.Add(this.tb_AniomMoto);
            this.Controls.Add(this.lbl_anioMoto);
            this.Controls.Add(this.btn_AgregarPedido);
            this.Controls.Add(this.tb_precioMoto);
            this.Controls.Add(this.lbl_PrecioMoto);
            this.Controls.Add(this.lbl_Pedido);
            this.Controls.Add(this.tb_modeloMoto);
            this.Controls.Add(this.lbl_ModeloMoto);
            this.Name = "FormAgregarMoto";
            this.Text = "Comprar Moto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_CilindradaMoto;
        private System.Windows.Forms.Label lbl_CilindradaMoto;
        private System.Windows.Forms.ComboBox cb_TipoEncendidoMoto;
        private System.Windows.Forms.Label lbl_EncendidoMoto;
        private System.Windows.Forms.ComboBox cb_MarcaMoto;
        private System.Windows.Forms.Label lbl_MarcaMoto;
        private System.Windows.Forms.TextBox tb_KilometrajeMoto;
        private System.Windows.Forms.Label lbl_KilometrajeMoto;
        private System.Windows.Forms.TextBox tb_AniomMoto;
        private System.Windows.Forms.Label lbl_anioMoto;
        private System.Windows.Forms.Button btn_AgregarPedido;
        private System.Windows.Forms.TextBox tb_precioMoto;
        private System.Windows.Forms.Label lbl_PrecioMoto;
        private System.Windows.Forms.Label lbl_Pedido;
        private System.Windows.Forms.TextBox tb_modeloMoto;
        private System.Windows.Forms.Label lbl_ModeloMoto;
    }
}