namespace TP_WinformCatalogo
{
    partial class Form1
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
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArticulos
            // 
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos.Location = new System.Drawing.Point(12, 173);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(201, 71);
            this.btnArticulos.TabIndex = 0;
            this.btnArticulos.Text = "Articulos";
            this.btnArticulos.UseVisualStyleBackColor = true;
            // 
            // btnMarcas
            // 
            this.btnMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.Location = new System.Drawing.Point(301, 173);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(201, 71);
            this.btnMarcas.TabIndex = 1;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = true;
            // 
            // btnCategorias
            // 
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.Location = new System.Drawing.Point(601, 173);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(201, 71);
            this.btnCategorias.TabIndex = 2;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 527);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.btnArticulos);
            this.Name = "Form1";
            this.Text = "TpWinform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnCategorias;
    }
}

