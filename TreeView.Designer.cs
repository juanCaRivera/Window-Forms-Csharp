namespace Ejemplo
{
    partial class TreeView
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.btnAdicionaNodo = new System.Windows.Forms.Button();
            this.btnAdicionaElemento = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.treeView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.treeView1.Location = new System.Drawing.Point(24, 7);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(288, 290);
            this.treeView1.TabIndex = 0;
            // 
            // txtNodo
            // 
            this.txtNodo.Location = new System.Drawing.Point(346, 39);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(100, 20);
            this.txtNodo.TabIndex = 1;
            // 
            // btnAdicionaNodo
            // 
            this.btnAdicionaNodo.Location = new System.Drawing.Point(452, 36);
            this.btnAdicionaNodo.Name = "btnAdicionaNodo";
            this.btnAdicionaNodo.Size = new System.Drawing.Size(118, 23);
            this.btnAdicionaNodo.TabIndex = 2;
            this.btnAdicionaNodo.Text = "Adiciona Nodo";
            this.btnAdicionaNodo.UseVisualStyleBackColor = true;
            this.btnAdicionaNodo.Click += new System.EventHandler(this.btnAdicionaNodo_Click);
            // 
            // btnAdicionaElemento
            // 
            this.btnAdicionaElemento.Location = new System.Drawing.Point(452, 65);
            this.btnAdicionaElemento.Name = "btnAdicionaElemento";
            this.btnAdicionaElemento.Size = new System.Drawing.Size(118, 23);
            this.btnAdicionaElemento.TabIndex = 3;
            this.btnAdicionaElemento.Text = "Adiciona Elemento";
            this.btnAdicionaElemento.UseVisualStyleBackColor = true;
            this.btnAdicionaElemento.Click += new System.EventHandler(this.btnAdicionaElemento_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(452, 94);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(118, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar Arbol";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(452, 123);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar Nodo";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(346, 68);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(100, 20);
            this.txtElemento.TabIndex = 6;
            // 
            // TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(643, 309);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAdicionaElemento);
            this.Controls.Add(this.btnAdicionaNodo);
            this.Controls.Add(this.txtNodo);
            this.Controls.Add(this.treeView1);
            this.Name = "TreeView";
            this.Text = "TreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.Button btnAdicionaNodo;
        private System.Windows.Forms.Button btnAdicionaElemento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtElemento;
    }
}