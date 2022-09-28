namespace Ejemplo
{
    partial class PracticaHome1
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
            this.CMBProductos = new System.Windows.Forms.ComboBox();
            this.MTBPrecio = new System.Windows.Forms.MaskedTextBox();
            this.BTNCalcular = new System.Windows.Forms.Button();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTBResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CMBProductos
            // 
            this.CMBProductos.FormattingEnabled = true;
            this.CMBProductos.Items.AddRange(new object[] {
            "Cervezas",
            "Ron",
            "Tequila",
            "Wiski"});
            this.CMBProductos.Location = new System.Drawing.Point(307, 59);
            this.CMBProductos.Name = "CMBProductos";
            this.CMBProductos.Size = new System.Drawing.Size(121, 21);
            this.CMBProductos.TabIndex = 0;
            this.CMBProductos.SelectedIndexChanged += new System.EventHandler(this.CMBProductos_SelectedIndexChanged);
            // 
            // MTBPrecio
            // 
            this.MTBPrecio.Location = new System.Drawing.Point(328, 105);
            this.MTBPrecio.Mask = "99999";
            this.MTBPrecio.Name = "MTBPrecio";
            this.MTBPrecio.Size = new System.Drawing.Size(100, 20);
            this.MTBPrecio.TabIndex = 1;
            this.MTBPrecio.ValidatingType = typeof(int);
            this.MTBPrecio.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MTBPrecio_MaskInputRejected);
            // 
            // BTNCalcular
            // 
            this.BTNCalcular.Location = new System.Drawing.Point(24, 231);
            this.BTNCalcular.Name = "BTNCalcular";
            this.BTNCalcular.Size = new System.Drawing.Size(75, 23);
            this.BTNCalcular.TabIndex = 2;
            this.BTNCalcular.Text = "Calcular";
            this.BTNCalcular.UseVisualStyleBackColor = true;
            this.BTNCalcular.Click += new System.EventHandler(this.BTNCalcular_Click);
            // 
            // BTNSalir
            // 
            this.BTNSalir.Location = new System.Drawing.Point(105, 285);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(75, 23);
            this.BTNSalir.TabIndex = 3;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.Location = new System.Drawing.Point(182, 231);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BTNLimpiar.TabIndex = 4;
            this.BTNLimpiar.Text = "Limpiar";
            this.BTNLimpiar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione el producte que desee comprar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese la cantidad de producto que llevara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total a pagar es de";
            // 
            // TXTBResultado
            // 
            this.TXTBResultado.Location = new System.Drawing.Point(328, 156);
            this.TXTBResultado.Name = "TXTBResultado";
            this.TXTBResultado.Size = new System.Drawing.Size(100, 20);
            this.TXTBResultado.TabIndex = 8;
            this.TXTBResultado.TextChanged += new System.EventHandler(this.TXTBResultado_TextChanged);
            // 
            // PracticaHome1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 488);
            this.Controls.Add(this.TXTBResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.BTNCalcular);
            this.Controls.Add(this.MTBPrecio);
            this.Controls.Add(this.CMBProductos);
            this.Name = "PracticaHome1";
            this.Text = "practicaHome1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CMBProductos;
        private System.Windows.Forms.MaskedTextBox MTBPrecio;
        private System.Windows.Forms.Button BTNCalcular;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.Button BTNLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTBResultado;
    }
}