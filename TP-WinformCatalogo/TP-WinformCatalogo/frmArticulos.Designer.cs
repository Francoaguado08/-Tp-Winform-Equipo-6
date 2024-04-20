
namespace TP_WinformCatalogo
{
    partial class frmArticulos
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.cbListarArticulos = new System.Windows.Forms.CheckBox();
            this.cbVerDetalleArticulo = new System.Windows.Forms.CheckBox();
            this.cbBuscarArticulo = new System.Windows.Forms.CheckBox();
            this.comboBxArticulos = new System.Windows.Forms.ComboBox();
            this.lblArticulosDisponibles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(16, 124);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(729, 300);
            this.dgvArticulos.TabIndex = 1;
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(16, 452);
            this.btnAgregarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(148, 46);
            this.btnAgregarArticulo.TabIndex = 2;
            this.btnAgregarArticulo.Text = "Agregar";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarArticulo.Location = new System.Drawing.Point(197, 452);
            this.btnModificarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(148, 46);
            this.btnModificarArticulo.TabIndex = 3;
            this.btnModificarArticulo.Text = "Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(381, 452);
            this.btnEliminarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(148, 46);
            this.btnEliminarArticulo.TabIndex = 4;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            // 
            // cbListarArticulos
            // 
            this.cbListarArticulos.AutoSize = true;
            this.cbListarArticulos.Location = new System.Drawing.Point(539, 82);
            this.cbListarArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.cbListarArticulos.Name = "cbListarArticulos";
            this.cbListarArticulos.Size = new System.Drawing.Size(183, 21);
            this.cbListarArticulos.TabIndex = 15;
            this.cbListarArticulos.Text = "Listar todos los articulos";
            this.cbListarArticulos.UseVisualStyleBackColor = true;
            // 
            // cbVerDetalleArticulo
            // 
            this.cbVerDetalleArticulo.AutoSize = true;
            this.cbVerDetalleArticulo.Location = new System.Drawing.Point(539, 54);
            this.cbVerDetalleArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.cbVerDetalleArticulo.Name = "cbVerDetalleArticulo";
            this.cbVerDetalleArticulo.Size = new System.Drawing.Size(255, 21);
            this.cbVerDetalleArticulo.TabIndex = 14;
            this.cbVerDetalleArticulo.Text = "Ver detalle de articulo seleccionado";
            this.cbVerDetalleArticulo.UseVisualStyleBackColor = true;
            // 
            // cbBuscarArticulo
            // 
            this.cbBuscarArticulo.AutoSize = true;
            this.cbBuscarArticulo.Location = new System.Drawing.Point(539, 25);
            this.cbBuscarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.cbBuscarArticulo.Name = "cbBuscarArticulo";
            this.cbBuscarArticulo.Size = new System.Drawing.Size(211, 21);
            this.cbBuscarArticulo.TabIndex = 13;
            this.cbBuscarArticulo.Text = "Buscar articulo seleccionado";
            this.cbBuscarArticulo.UseVisualStyleBackColor = true;
            // 
            // comboBxArticulos
            // 
            this.comboBxArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBxArticulos.FormattingEnabled = true;
            this.comboBxArticulos.Location = new System.Drawing.Point(369, 74);
            this.comboBxArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.comboBxArticulos.Name = "comboBxArticulos";
            this.comboBxArticulos.Size = new System.Drawing.Size(160, 24);
            this.comboBxArticulos.TabIndex = 12;
            // 
            // lblArticulosDisponibles
            // 
            this.lblArticulosDisponibles.AutoSize = true;
            this.lblArticulosDisponibles.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulosDisponibles.Location = new System.Drawing.Point(16, 74);
            this.lblArticulosDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArticulosDisponibles.Name = "lblArticulosDisponibles";
            this.lblArticulosDisponibles.Size = new System.Drawing.Size(344, 32);
            this.lblArticulosDisponibles.TabIndex = 11;
            this.lblArticulosDisponibles.Text = "Articulos Disponibles:";
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 544);
            this.Controls.Add(this.cbListarArticulos);
            this.Controls.Add(this.cbVerDetalleArticulo);
            this.Controls.Add(this.cbBuscarArticulo);
            this.Controls.Add(this.comboBxArticulos);
            this.Controls.Add(this.lblArticulosDisponibles);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1082, 591);
            this.MinimumSize = new System.Drawing.Size(1082, 591);
            this.Name = "frmArticulos";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.CheckBox cbListarArticulos;
        private System.Windows.Forms.CheckBox cbVerDetalleArticulo;
        private System.Windows.Forms.CheckBox cbBuscarArticulo;
        private System.Windows.Forms.ComboBox comboBxArticulos;
        private System.Windows.Forms.Label lblArticulosDisponibles;
    }
}