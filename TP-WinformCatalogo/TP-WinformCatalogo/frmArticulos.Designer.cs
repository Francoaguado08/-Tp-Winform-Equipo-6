
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
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 101);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(547, 244);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged_1);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(12, 367);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(111, 37);
            this.btnAgregarArticulo.TabIndex = 2;
            this.btnAgregarArticulo.Text = "Agregar";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarArticulo.Location = new System.Drawing.Point(148, 367);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(111, 37);
            this.btnModificarArticulo.TabIndex = 3;
            this.btnModificarArticulo.Text = "Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(286, 367);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(111, 37);
            this.btnEliminarArticulo.TabIndex = 4;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            // 
            // cbListarArticulos
            // 
            this.cbListarArticulos.AutoSize = true;
            this.cbListarArticulos.Location = new System.Drawing.Point(404, 67);
            this.cbListarArticulos.Name = "cbListarArticulos";
            this.cbListarArticulos.Size = new System.Drawing.Size(138, 17);
            this.cbListarArticulos.TabIndex = 15;
            this.cbListarArticulos.Text = "Listar todos los articulos";
            this.cbListarArticulos.UseVisualStyleBackColor = true;
            // 
            // cbVerDetalleArticulo
            // 
            this.cbVerDetalleArticulo.AutoSize = true;
            this.cbVerDetalleArticulo.Location = new System.Drawing.Point(404, 44);
            this.cbVerDetalleArticulo.Name = "cbVerDetalleArticulo";
            this.cbVerDetalleArticulo.Size = new System.Drawing.Size(194, 17);
            this.cbVerDetalleArticulo.TabIndex = 14;
            this.cbVerDetalleArticulo.Text = "Ver detalle de articulo seleccionado";
            this.cbVerDetalleArticulo.UseVisualStyleBackColor = true;
            // 
            // cbBuscarArticulo
            // 
            this.cbBuscarArticulo.AutoSize = true;
            this.cbBuscarArticulo.Location = new System.Drawing.Point(404, 20);
            this.cbBuscarArticulo.Name = "cbBuscarArticulo";
            this.cbBuscarArticulo.Size = new System.Drawing.Size(162, 17);
            this.cbBuscarArticulo.TabIndex = 13;
            this.cbBuscarArticulo.Text = "Buscar articulo seleccionado";
            this.cbBuscarArticulo.UseVisualStyleBackColor = true;
            // 
            // comboBxArticulos
            // 
            this.comboBxArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBxArticulos.FormattingEnabled = true;
            this.comboBxArticulos.Location = new System.Drawing.Point(277, 60);
            this.comboBxArticulos.Name = "comboBxArticulos";
            this.comboBxArticulos.Size = new System.Drawing.Size(121, 21);
            this.comboBxArticulos.TabIndex = 12;
            // 
            // lblArticulosDisponibles
            // 
            this.lblArticulosDisponibles.AutoSize = true;
            this.lblArticulosDisponibles.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulosDisponibles.Location = new System.Drawing.Point(12, 60);
            this.lblArticulosDisponibles.Name = "lblArticulosDisponibles";
            this.lblArticulosDisponibles.Size = new System.Drawing.Size(265, 25);
            this.lblArticulosDisponibles.TabIndex = 11;
            this.lblArticulosDisponibles.Text = "Articulos Disponibles:";
            // 
            // pbArticulo
            // 
            this.pbArticulo.Location = new System.Drawing.Point(565, 101);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(233, 244);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulo.TabIndex = 16;
            this.pbArticulo.TabStop = false;
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.cbListarArticulos);
            this.Controls.Add(this.cbVerDetalleArticulo);
            this.Controls.Add(this.cbBuscarArticulo);
            this.Controls.Add(this.comboBxArticulos);
            this.Controls.Add(this.lblArticulosDisponibles);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.MaximumSize = new System.Drawing.Size(816, 487);
            this.MinimumSize = new System.Drawing.Size(816, 487);
            this.Name = "frmArticulos";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
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
        private System.Windows.Forms.PictureBox pbArticulo;
    }
}