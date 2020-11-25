namespace TP4_Concesionario
{
    partial class FormAgregarAuto
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
            this.cb_Tipo = new System.Windows.Forms.ComboBox();
            this.btn_AgregarPedido = new System.Windows.Forms.Button();
            this.tb_precio = new System.Windows.Forms.TextBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Pedido = new System.Windows.Forms.Label();
            this.tb_pedido = new System.Windows.Forms.TextBox();
            this.lbl_ModeloDelAuto = new System.Windows.Forms.Label();
            this.lbl_Clase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_Tipo
            // 
            this.cb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Tipo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Tipo.FormattingEnabled = true;
            this.cb_Tipo.Items.AddRange(new object[] {
            "Comida Rapida",
            "Comida Gurmet",
            "Postre",
            "Indefinido"});
            this.cb_Tipo.Location = new System.Drawing.Point(273, 226);
            this.cb_Tipo.Name = "cb_Tipo";
            this.cb_Tipo.Size = new System.Drawing.Size(212, 27);
            this.cb_Tipo.TabIndex = 54;
            // 
            // btn_AgregarPedido
            // 
            this.btn_AgregarPedido.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarPedido.Location = new System.Drawing.Point(312, 331);
            this.btn_AgregarPedido.Name = "btn_AgregarPedido";
            this.btn_AgregarPedido.Size = new System.Drawing.Size(137, 36);
            this.btn_AgregarPedido.TabIndex = 53;
            this.btn_AgregarPedido.Text = "Agregar Pedido";
            this.btn_AgregarPedido.UseVisualStyleBackColor = true;
            // 
            // tb_precio
            // 
            this.tb_precio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_precio.Location = new System.Drawing.Point(274, 283);
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.Size = new System.Drawing.Size(211, 27);
            this.tb_precio.TabIndex = 52;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Precio.Location = new System.Drawing.Point(270, 261);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(52, 19);
            this.lbl_Precio.TabIndex = 51;
            this.lbl_Precio.Text = "Precio";
            // 
            // lbl_Pedido
            // 
            this.lbl_Pedido.AutoSize = true;
            this.lbl_Pedido.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pedido.Location = new System.Drawing.Point(308, 83);
            this.lbl_Pedido.Name = "lbl_Pedido";
            this.lbl_Pedido.Size = new System.Drawing.Size(156, 23);
            this.lbl_Pedido.TabIndex = 50;
            this.lbl_Pedido.Text = "Agregar Pedido";
            // 
            // tb_pedido
            // 
            this.tb_pedido.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pedido.Location = new System.Drawing.Point(273, 161);
            this.tb_pedido.Name = "tb_pedido";
            this.tb_pedido.Size = new System.Drawing.Size(213, 27);
            this.tb_pedido.TabIndex = 49;
            // 
            // lbl_ModeloDelAuto
            // 
            this.lbl_ModeloDelAuto.AutoSize = true;
            this.lbl_ModeloDelAuto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ModeloDelAuto.Location = new System.Drawing.Point(270, 139);
            this.lbl_ModeloDelAuto.Name = "lbl_ModeloDelAuto";
            this.lbl_ModeloDelAuto.Size = new System.Drawing.Size(125, 19);
            this.lbl_ModeloDelAuto.TabIndex = 48;
            this.lbl_ModeloDelAuto.Text = "Modelo del Auto";
            // 
            // lbl_Clase
            // 
            this.lbl_Clase.AutoSize = true;
            this.lbl_Clase.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clase.Location = new System.Drawing.Point(269, 203);
            this.lbl_Clase.Name = "lbl_Clase";
            this.lbl_Clase.Size = new System.Drawing.Size(263, 19);
            this.lbl_Clase.TabIndex = 47;
            this.lbl_Clase.Text = "Clase a la que pertenece el pedido ?";
            // 
            // FormAgregarAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_Tipo);
            this.Controls.Add(this.btn_AgregarPedido);
            this.Controls.Add(this.tb_precio);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.lbl_Pedido);
            this.Controls.Add(this.tb_pedido);
            this.Controls.Add(this.lbl_ModeloDelAuto);
            this.Controls.Add(this.lbl_Clase);
            this.Name = "FormAgregarAuto";
            this.Text = "FormAgregarAuto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Tipo;
        private System.Windows.Forms.Button btn_AgregarPedido;
        private System.Windows.Forms.TextBox tb_precio;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_Pedido;
        private System.Windows.Forms.TextBox tb_pedido;
        private System.Windows.Forms.Label lbl_ModeloDelAuto;
        private System.Windows.Forms.Label lbl_Clase;
    }
}