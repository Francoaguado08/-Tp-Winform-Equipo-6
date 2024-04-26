
namespace TP_WinformCatalogo
{
    partial class frmMarcas
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
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.lblMarcasDisponibles = new System.Windows.Forms.Label();
            this.btnAgregarMarcas = new System.Windows.Forms.Button();
            this.btnModificarMarcas = new System.Windows.Forms.Button();
            this.btnEliminarMarcas = new System.Windows.Forms.Button();
            this.comboBxMarcas = new System.Windows.Forms.ComboBox();
            this.pictureBoxMarcas = new System.Windows.Forms.PictureBox();
            this.cbBuscarMarca = new System.Windows.Forms.CheckBox();
            this.cbVerDetalleMarcas = new System.Windows.Forms.CheckBox();
            this.cbListarMarcas = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(6, 100);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 51;
            this.dgvMarcas.Size = new System.Drawing.Size(547, 244);
            this.dgvMarcas.TabIndex = 1;
            // 
            // lblMarcasDisponibles
            // 
            this.lblMarcasDisponibles.AutoSize = true;
            this.lblMarcasDisponibles.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcasDisponibles.Location = new System.Drawing.Point(6, 60);
            this.lblMarcasDisponibles.Name = "lblMarcasDisponibles";
            this.lblMarcasDisponibles.Size = new System.Drawing.Size(236, 25);
            this.lblMarcasDisponibles.TabIndex = 2;
            this.lblMarcasDisponibles.Text = "Marcas Disponibles:";
            // 
            // btnAgregarMarcas
            // 
            this.btnAgregarMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMarcas.Location = new System.Drawing.Point(18, 367);
            this.btnAgregarMarcas.Name = "btnAgregarMarcas";
            this.btnAgregarMarcas.Size = new System.Drawing.Size(111, 37);
            this.btnAgregarMarcas.TabIndex = 3;
            this.btnAgregarMarcas.Text = "Agregar";
            this.btnAgregarMarcas.UseVisualStyleBackColor = true;
            this.btnAgregarMarcas.Click += new System.EventHandler(this.btnAgregarMarcas_Click);
            // 
            // btnModificarMarcas
            // 
            this.btnModificarMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarMarcas.Location = new System.Drawing.Point(148, 367);
            this.btnModificarMarcas.Name = "btnModificarMarcas";
            this.btnModificarMarcas.Size = new System.Drawing.Size(111, 37);
            this.btnModificarMarcas.TabIndex = 4;
            this.btnModificarMarcas.Text = "Modificar";
            this.btnModificarMarcas.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMarcas
            // 
            this.btnEliminarMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarMarcas.Location = new System.Drawing.Point(286, 367);
            this.btnEliminarMarcas.Name = "btnEliminarMarcas";
            this.btnEliminarMarcas.Size = new System.Drawing.Size(111, 37);
            this.btnEliminarMarcas.TabIndex = 5;
            this.btnEliminarMarcas.Text = "Eliminar";
            this.btnEliminarMarcas.UseVisualStyleBackColor = true;
            this.btnEliminarMarcas.Click += new System.EventHandler(this.btnEliminarMarcas_Click);
            // 
            // comboBxMarcas
            // 
            this.comboBxMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBxMarcas.FormattingEnabled = true;
            this.comboBxMarcas.Location = new System.Drawing.Point(245, 60);
            this.comboBxMarcas.Name = "comboBxMarcas";
            this.comboBxMarcas.Size = new System.Drawing.Size(121, 21);
            this.comboBxMarcas.TabIndex = 6;
            // 
            // pictureBoxMarcas
            // 
            this.pictureBoxMarcas.Location = new System.Drawing.Point(572, 100);
            this.pictureBoxMarcas.Name = "pictureBoxMarcas";
            this.pictureBoxMarcas.Size = new System.Drawing.Size(222, 244);
            this.pictureBoxMarcas.TabIndex = 7;
            this.pictureBoxMarcas.TabStop = false;
            // 
            // cbBuscarMarca
            // 
            this.cbBuscarMarca.AutoSize = true;
            this.cbBuscarMarca.Location = new System.Drawing.Point(373, 19);
            this.cbBuscarMarca.Name = "cbBuscarMarca";
            this.cbBuscarMarca.Size = new System.Drawing.Size(157, 17);
            this.cbBuscarMarca.TabIndex = 8;
            this.cbBuscarMarca.Text = "Buscar marca seleccionada";
            this.cbBuscarMarca.UseVisualStyleBackColor = true;
            // 
            // cbVerDetalleMarcas
            // 
            this.cbVerDetalleMarcas.AutoSize = true;
            this.cbVerDetalleMarcas.Location = new System.Drawing.Point(373, 43);
            this.cbVerDetalleMarcas.Name = "cbVerDetalleMarcas";
            this.cbVerDetalleMarcas.Size = new System.Drawing.Size(189, 17);
            this.cbVerDetalleMarcas.TabIndex = 9;
            this.cbVerDetalleMarcas.Text = "Ver detalle de marca seleccionada";
            this.cbVerDetalleMarcas.UseVisualStyleBackColor = true;
            // 
            // cbListarMarcas
            // 
            this.cbListarMarcas.AutoSize = true;
            this.cbListarMarcas.Location = new System.Drawing.Point(373, 66);
            this.cbListarMarcas.Name = "cbListarMarcas";
            this.cbListarMarcas.Size = new System.Drawing.Size(133, 17);
            this.cbListarMarcas.TabIndex = 10;
            this.cbListarMarcas.Text = "Listar todas las marcas";
            this.cbListarMarcas.UseVisualStyleBackColor = true;
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.cbListarMarcas);
            this.Controls.Add(this.cbVerDetalleMarcas);
            this.Controls.Add(this.cbBuscarMarca);
            this.Controls.Add(this.pictureBoxMarcas);
            this.Controls.Add(this.comboBxMarcas);
            this.Controls.Add(this.btnEliminarMarcas);
            this.Controls.Add(this.btnModificarMarcas);
            this.Controls.Add(this.btnAgregarMarcas);
            this.Controls.Add(this.lblMarcasDisponibles);
            this.Controls.Add(this.dgvMarcas);
            this.MaximumSize = new System.Drawing.Size(816, 487);
            this.MinimumSize = new System.Drawing.Size(816, 487);
            this.Name = "frmMarcas";
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.frmMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Label lblMarcasDisponibles;
        private System.Windows.Forms.Button btnAgregarMarcas;
        private System.Windows.Forms.Button btnModificarMarcas;
        private System.Windows.Forms.Button btnEliminarMarcas;
        private System.Windows.Forms.ComboBox comboBxMarcas;
        private System.Windows.Forms.PictureBox pictureBoxMarcas;
        private System.Windows.Forms.CheckBox cbBuscarMarca;
        private System.Windows.Forms.CheckBox cbVerDetalleMarcas;
        private System.Windows.Forms.CheckBox cbListarMarcas;
    }
}