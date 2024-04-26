
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
            this.cbListarCategorias.Location = new System.Drawing.Point(416, 67);
            this.cbListarCategorias.Name = "cbListarCategorias";
            this.cbListarCategorias.Size = new System.Drawing.Size(148, 17);
            this.cbListarCategorias.TabIndex = 24;
            this.cbListarCategorias.Text = "Listar todos las categorias";
            this.cbListarCategorias.UseVisualStyleBackColor = true;
            // 
            // cbVerDetalleCategorias
            // 
            this.cbVerDetalleCategorias.AutoSize = true;
            this.cbVerDetalleCategorias.Location = new System.Drawing.Point(416, 44);
            this.cbVerDetalleCategorias.Name = "cbVerDetalleCategorias";
            this.cbVerDetalleCategorias.Size = new System.Drawing.Size(204, 17);
            this.cbVerDetalleCategorias.TabIndex = 23;
            this.cbVerDetalleCategorias.Text = "Ver detalle de categoria seleccionada";
            this.cbVerDetalleCategorias.UseVisualStyleBackColor = true;
            // 
            // cbBuscarCategoria
            // 
            this.cbBuscarCategoria.AutoSize = true;
            this.cbBuscarCategoria.Location = new System.Drawing.Point(416, 20);
            this.cbBuscarCategoria.Name = "cbBuscarCategoria";
            this.cbBuscarCategoria.Size = new System.Drawing.Size(172, 17);
            this.cbBuscarCategoria.TabIndex = 22;
            this.cbBuscarCategoria.Text = "Buscar categoria seleccionado";
            this.cbBuscarCategoria.UseVisualStyleBackColor = true;
            // 
            // cmbxMarcas
            // 
            this.cmbxMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxMarcas.FormattingEnabled = true;
            this.cmbxMarcas.Location = new System.Drawing.Point(289, 60);
            this.cmbxMarcas.Name = "cmbxMarcas";
            this.cmbxMarcas.Size = new System.Drawing.Size(121, 21);
            this.cmbxMarcas.TabIndex = 21;
            // 
            // lblCategoriasDisponibles
            // 
            this.lblCategoriasDisponibles.AutoSize = true;
            this.lblCategoriasDisponibles.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriasDisponibles.Location = new System.Drawing.Point(12, 60);
            this.lblCategoriasDisponibles.Name = "lblCategoriasDisponibles";
            this.lblCategoriasDisponibles.Size = new System.Drawing.Size(278, 25);
            this.lblCategoriasDisponibles.TabIndex = 20;
            this.lblCategoriasDisponibles.Text = "Categorias Disponibles:";
            // 
            // btnEliminarCategorias
            // 
            this.btnEliminarCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCategorias.Location = new System.Drawing.Point(286, 367);
            this.btnEliminarCategorias.Name = "btnEliminarCategorias";
            this.btnEliminarCategorias.Size = new System.Drawing.Size(111, 37);
            this.btnEliminarCategorias.TabIndex = 19;
            this.btnEliminarCategorias.Text = "Eliminar";
            this.btnEliminarCategorias.UseVisualStyleBackColor = true;
            // 
            // btnModificarCategorias
            // 
            this.btnModificarCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarCategorias.Location = new System.Drawing.Point(148, 367);
            this.btnModificarCategorias.Name = "btnModificarCategorias";
            this.btnModificarCategorias.Size = new System.Drawing.Size(111, 37);
            this.btnModificarCategorias.TabIndex = 18;
            this.btnModificarCategorias.Text = "Modificar";
            this.btnModificarCategorias.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCategorias
            // 
            this.btnAgregarCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCategorias.Location = new System.Drawing.Point(12, 367);
            this.btnAgregarCategorias.Name = "btnAgregarCategorias";
            this.btnAgregarCategorias.Size = new System.Drawing.Size(111, 37);
            this.btnAgregarCategorias.TabIndex = 17;
            this.btnAgregarCategorias.Text = "Agregar";
            this.btnAgregarCategorias.UseVisualStyleBackColor = true;
            this.btnAgregarCategorias.Click += new System.EventHandler(this.btnAgregarCategorias_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(12, 101);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.Size = new System.Drawing.Size(547, 244);
            this.dgvCategorias.TabIndex = 16;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.cbListarCategorias);
            this.Controls.Add(this.cbVerDetalleCategorias);
            this.Controls.Add(this.cbBuscarCategoria);
            this.Controls.Add(this.cmbxMarcas);
            this.Controls.Add(this.lblCategoriasDisponibles);
            this.Controls.Add(this.btnEliminarCategorias);
            this.Controls.Add(this.btnModificarCategorias);
            this.Controls.Add(this.btnAgregarCategorias);
            this.Controls.Add(this.dgvCategorias);
            this.MaximumSize = new System.Drawing.Size(816, 487);
            this.MinimumSize = new System.Drawing.Size(816, 487);
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