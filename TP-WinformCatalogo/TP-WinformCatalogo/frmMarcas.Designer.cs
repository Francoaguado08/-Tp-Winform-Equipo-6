
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accionesImportantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAgregarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaYListadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBuscarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListarMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVerDetalleMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionesImportantesToolStripMenuItem,
            this.busquedaYListadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accionesImportantesToolStripMenuItem
            // 
            this.accionesImportantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAgregarMarca,
            this.tsmiEliminarMarca,
            this.tsmiModificarMarca});
            this.accionesImportantesToolStripMenuItem.Name = "accionesImportantesToolStripMenuItem";
            this.accionesImportantesToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.accionesImportantesToolStripMenuItem.Text = "&Acciones Importantes";
            // 
            // tsmiAgregarMarca
            // 
            this.tsmiAgregarMarca.Name = "tsmiAgregarMarca";
            this.tsmiAgregarMarca.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.tsmiAgregarMarca.Size = new System.Drawing.Size(197, 22);
            this.tsmiAgregarMarca.Text = "Agregar marca";
            // 
            // tsmiEliminarMarca
            // 
            this.tsmiEliminarMarca.Name = "tsmiEliminarMarca";
            this.tsmiEliminarMarca.Size = new System.Drawing.Size(180, 22);
            this.tsmiEliminarMarca.Text = "Eliminar marca";
            // 
            // tsmiModificarMarca
            // 
            this.tsmiModificarMarca.Name = "tsmiModificarMarca";
            this.tsmiModificarMarca.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.tsmiModificarMarca.Size = new System.Drawing.Size(197, 22);
            this.tsmiModificarMarca.Text = "Modificar marca";
            // 
            // busquedaYListadoToolStripMenuItem
            // 
            this.busquedaYListadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBuscarMarca,
            this.tsmiListarMarcas,
            this.tsmiVerDetalleMarcas});
            this.busquedaYListadoToolStripMenuItem.Name = "busquedaYListadoToolStripMenuItem";
            this.busquedaYListadoToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.busquedaYListadoToolStripMenuItem.Text = "&Busqueda y listado";
            // 
            // tsmiBuscarMarca
            // 
            this.tsmiBuscarMarca.Name = "tsmiBuscarMarca";
            this.tsmiBuscarMarca.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.tsmiBuscarMarca.Size = new System.Drawing.Size(185, 22);
            this.tsmiBuscarMarca.Text = "Buscar marca";
            // 
            // tsmiListarMarcas
            // 
            this.tsmiListarMarcas.Name = "tsmiListarMarcas";
            this.tsmiListarMarcas.Size = new System.Drawing.Size(185, 22);
            this.tsmiListarMarcas.Text = "Listar marcas";
            // 
            // tsmiVerDetalleMarcas
            // 
            this.tsmiVerDetalleMarcas.Name = "tsmiVerDetalleMarcas";
            this.tsmiVerDetalleMarcas.Size = new System.Drawing.Size(185, 22);
            this.tsmiVerDetalleMarcas.Text = "Ver detalle de marcas";
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMarcas";
            this.Text = "Marcas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accionesImportantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaYListadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAgregarMarca;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminarMarca;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificarMarca;
        private System.Windows.Forms.ToolStripMenuItem tsmiBuscarMarca;
        private System.Windows.Forms.ToolStripMenuItem tsmiListarMarcas;
        private System.Windows.Forms.ToolStripMenuItem tsmiVerDetalleMarcas;
    }
}