namespace MiCalculadora
{
    partial class FormCalculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.Cb_Operador = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_ConvADec = new System.Windows.Forms.Button();
            this.btn_ConvABin = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Operar = new System.Windows.Forms.Button();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(261, 23);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(0, 13);
            this.lbl_Resultado.TabIndex = 8;
            // 
            // Cb_Operador
            // 
            this.Cb_Operador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Operador.FormattingEnabled = true;
            this.Cb_Operador.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.Cb_Operador.Location = new System.Drawing.Point(141, 58);
            this.Cb_Operador.Name = "Cb_Operador";
            this.Cb_Operador.Size = new System.Drawing.Size(57, 21);
            this.Cb_Operador.TabIndex = 1;
            this.Cb_Operador.SelectedIndexChanged += new System.EventHandler(this.Cb_Operador_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(51, 50);
            this.txtNum1.Multiline = true;
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(84, 30);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.TextChanged += new System.EventHandler(this.btn_Operar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(132, 96);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 38);
            this.btn_Limpiar.TabIndex = 4;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_ConvADec
            // 
            this.btn_ConvADec.Location = new System.Drawing.Point(167, 140);
            this.btn_ConvADec.Name = "btn_ConvADec";
            this.btn_ConvADec.Size = new System.Drawing.Size(140, 38);
            this.btn_ConvADec.TabIndex = 7;
            this.btn_ConvADec.Text = "Convertir a Decimal";
            this.btn_ConvADec.UseVisualStyleBackColor = true;
            this.btn_ConvADec.Click += new System.EventHandler(this.btn_ConvADec_Click);
            // 
            // btn_ConvABin
            // 
            this.btn_ConvABin.Location = new System.Drawing.Point(21, 140);
            this.btn_ConvABin.Name = "btn_ConvABin";
            this.btn_ConvABin.Size = new System.Drawing.Size(140, 38);
            this.btn_ConvABin.TabIndex = 6;
            this.btn_ConvABin.Text = "Convertir a Binario";
            this.btn_ConvABin.UseVisualStyleBackColor = true;
            this.btn_ConvABin.Click += new System.EventHandler(this.btn_ConvABin_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(213, 96);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(75, 38);
            this.btn_Cerrar.TabIndex = 5;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Operar
            // 
            this.btn_Operar.AccessibleDescription = "";
            this.btn_Operar.Location = new System.Drawing.Point(51, 96);
            this.btn_Operar.Name = "btn_Operar";
            this.btn_Operar.Size = new System.Drawing.Size(75, 38);
            this.btn_Operar.TabIndex = 3;
            this.btn_Operar.Text = "Operar";
            this.btn_Operar.UseVisualStyleBackColor = true;
            this.btn_Operar.Click += new System.EventHandler(this.btn_Operar_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(204, 50);
            this.txtNum2.Multiline = true;
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(84, 29);
            this.txtNum2.TabIndex = 2;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 201);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.btn_Operar);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_ConvABin);
            this.Controls.Add(this.btn_ConvADec);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.Cb_Operador);
            this.Controls.Add(this.lbl_Resultado);
            this.Name = "FormCalculadora";
            this.Text = "Calculadora de Leandro Cabeza curso_2ºD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.ComboBox Cb_Operador;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_ConvADec;
        private System.Windows.Forms.Button btn_ConvABin;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Operar;
        private System.Windows.Forms.TextBox txtNum2;
    }
}

