
namespace TP_WinformCatalogo
{
    partial class frmCategorias
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
            this.cbListarCategorias = new System.Windows.Forms.CheckBox();
            this.cbVerDetalleCategorias = new System.Windows.Forms.CheckBox();
            this.cbBuscarCategoria = new System.Windows.Forms.CheckBox();
            this.cmbxMarcas = new System.Windows.Forms.ComboBox();
            this.lblCategoriasDisponibles = new System.Windows.Forms.Label();
            this.btnEliminarCategorias = new System.Windows.Forms.Button();
            this.btnModificarCategorias = new System.Windows.Forms.Button();
            this.btnAgregarCategorias = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // cbListarCategorias
            // 
            this.cbListarCategorias.AutoSize = true;
            this.cbListarCategorias.Location = new System.Drawing.Point(555, 82);
            this.cbListarCategorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbListarCategorias.Name = "cbListarCategorias";
            this.cbListarCategorias.Size = new System.Drawing.Size(196, 21);
            this.cbListarCategorias.TabIndex = 24;
            this.cbListarCategorias.Text = "Listar todos las categorias";
            this.cbListarCategorias.UseVisualStyleBackColor = true;
            // 
            // cbVerDetalleCategorias
            // 
            this.cbVerDetalleCategorias.AutoSize = true;
            this.cbVerDetalleCategorias.Location = new System.Drawing.Point(555, 54);
            this.cbVerDetalleCategorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbVerDetalleCategorias.Name = "cbVerDetalleCategorias";
            this.cbVerDetalleCategorias.Size = new System.Drawing.Size(268, 21);
            this.cbVerDetalleCategorias.TabIndex = 23;
            this.cbVerDetalleCategorias.Text = "Ver detalle de categoria seleccionada";
            this.cbVerDetalleCategorias.UseVisualStyleBackColor = true;
            // 
            // cbBuscarCategoria
            // 
            this.cbBuscarCategoria.AutoSize = true;
            this.cbBuscarCategoria.Location = new System.Drawing.Point(555, 25);
            this.cbBuscarCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbBuscarCategoria.Name = "cbBuscarCategoria";
            this.cbBuscarCategoria.Size = new System.Drawing.Size(224, 21);
            this.cbBuscarCategoria.TabIndex = 22;
            this.cbBuscarCategoria.Text = "Buscar categoria seleccionado";
            this.cbBuscarCategoria.UseVisualStyleBackColor = true;
            // 
            // cmbxMarcas
            // 
            this.cmbxMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxMarcas.FormattingEnabled = true;
            this.cmbxMarcas.Location = new System.Drawing.Point(385, 74);
            this.cmbxMarcas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxMarcas.Name = "cmbxMarcas";
            this.cmbxMarcas.Size = new System.Drawing.Size(160, 24);
            this.cmbxMarcas.TabIndex = 21;
            // 
            // lblCategoriasDisponibles
            // 
            this.lblCategoriasDisponibles.AutoSize = true;
            this.lblCategoriasDisponibles.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriasDisponibles.Location = new System.Drawing.Point(16, 74);
            this.lblCategoriasDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoriasDisponibles.Name = "lblCategoriasDisponibles";
            this.lblCategoriasDisponibles.Size = new System.Drawing.Size(362, 32);
            this.lblCategoriasDisponibles.TabIndex = 20;
            this.lblCategoriasDisponibles.Text = "Categorias Disponibles:";
            // 
            // btnEliminarCategorias
            // 
            this.btnEliminarCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCategorias.Location = new System.Drawing.Point(381, 452);
            this.btnEliminarCategorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarCategorias.Name = "btnEliminarCategorias";
            this.btnEliminarCategorias.Size = new System.Drawing.Size(148, 46);
            this.btnEliminarCategorias.TabIndex = 19;
            this.btnEliminarCategorias.Text = "Eliminar";
            this.btnEliminarCategorias.UseVisualStyleBackColor = true;
            // 
            // btnModificarCategorias
            // 
            this.btnModificarCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarCategorias.Location = new System.Drawing.Point(197, 452);
            this.btnModificarCategorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarCategorias.Name = "btnModificarCategorias";
            this.btnModificarCategorias.Size = new System.Drawing.Size(148, 46);
            this.btnModificarCategorias.TabIndex = 18;
            this.btnModificarCategorias.Text = "Modificar";
            this.btnModificarCategorias.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCategorias
            // 
            this.btnAgregarCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCategorias.Location = new System.Drawing.Point(16, 452);
            this.btnAgregarCategorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarCategorias.Name = "btnAgregarCategorias";
            this.btnAgregarCategorias.Size = new System.Drawing.Size(148, 46);
            this.btnAgregarCategorias.TabIndex = 17;
            this.btnAgregarCategorias.Text = "Agregar";
            this.btnAgregarCategorias.UseVisualStyleBackColor = true;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(16, 124);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.Size = new System.Drawing.Size(729, 300);
            this.dgvCategorias.TabIndex = 16;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 544);
            this.Controls.Add(this.cbListarCategorias);
            this.Controls.Add(this.cbVerDetalleCategorias);
            this.Controls.Add(this.cbBuscarCategoria);
            this.Controls.Add(this.cmbxMarcas);
            this.Controls.Add(this.lblCategoriasDisponibles);
            this.Controls.Add(this.btnEliminarCategorias);
            this.Controls.Add(this.btnModificarCategorias);
            this.Controls.Add(this.btnAgregarCategorias);
            this.Controls.Add(this.dgvCategorias);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1082, 591);
            this.MinimumSize = new System.Drawing.Size(1082, 591);
            this.Name = "frmCategorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbListarCategorias;
        private System.Windows.Forms.CheckBox cbVerDetalleCategorias;
        private System.Windows.Forms.CheckBox cbBuscarCategoria;
        private System.Windows.Forms.ComboBox cmbxMarcas;
        private System.Windows.Forms.Label lblCategoriasDisponibles;
        private System.Windows.Forms.Button btnEliminarCategorias;
        private System.Windows.Forms.Button btnModificarCategorias;
        private System.Windows.Forms.Button btnAgregarCategorias;
        private System.Windows.Forms.DataGridView dgvCategorias;
    }
}