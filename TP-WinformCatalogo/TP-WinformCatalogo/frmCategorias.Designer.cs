
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accionesImportantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAgregarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaYListadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBuscarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListarCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVerDetalleCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionesImportantesToolStripMenuItem,
            this.busquedaYListadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accionesImportantesToolStripMenuItem
            // 
            this.accionesImportantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAgregarCategoria,
            this.tsmiEliminarCategoria,
            this.tsmiModificarCategoria});
            this.accionesImportantesToolStripMenuItem.Name = "accionesImportantesToolStripMenuItem";
            this.accionesImportantesToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.accionesImportantesToolStripMenuItem.Text = "&Acciones Importantes";
            // 
            // tsmiAgregarCategoria
            // 
            this.tsmiAgregarCategoria.Name = "tsmiAgregarCategoria";
            this.tsmiAgregarCategoria.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.tsmiAgregarCategoria.Size = new System.Drawing.Size(213, 22);
            this.tsmiAgregarCategoria.Text = "Agregar categoria";
            // 
            // tsmiEliminarCategoria
            // 
            this.tsmiEliminarCategoria.Name = "tsmiEliminarCategoria";
            this.tsmiEliminarCategoria.Size = new System.Drawing.Size(177, 22);
            this.tsmiEliminarCategoria.Text = "Eliminar categoria";
            // 
            // tsmiModificarCategoria
            // 
            this.tsmiModificarCategoria.Name = "tsmiModificarCategoria";
            this.tsmiModificarCategoria.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.tsmiModificarCategoria.Size = new System.Drawing.Size(213, 22);
            this.tsmiModificarCategoria.Text = "Modificar categoria";
            // 
            // busquedaYListadosToolStripMenuItem
            // 
            this.busquedaYListadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBuscarCategoria,
            this.tsmiListarCategorias,
            this.tsmiVerDetalleCategorias});
            this.busquedaYListadosToolStripMenuItem.Name = "busquedaYListadosToolStripMenuItem";
            this.busquedaYListadosToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.busquedaYListadosToolStripMenuItem.Text = "&Busqueda y listado";
            // 
            // tsmiBuscarCategoria
            // 
            this.tsmiBuscarCategoria.Name = "tsmiBuscarCategoria";
            this.tsmiBuscarCategoria.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.tsmiBuscarCategoria.Size = new System.Drawing.Size(201, 22);
            this.tsmiBuscarCategoria.Text = "Buscar categoria";
            // 
            // tsmiListarCategorias
            // 
            this.tsmiListarCategorias.Name = "tsmiListarCategorias";
            this.tsmiListarCategorias.Size = new System.Drawing.Size(201, 22);
            this.tsmiListarCategorias.Text = "Listar categorias";
            // 
            // tsmiVerDetalleCategorias
            // 
            this.tsmiVerDetalleCategorias.Name = "tsmiVerDetalleCategorias";
            this.tsmiVerDetalleCategorias.Size = new System.Drawing.Size(201, 22);
            this.tsmiVerDetalleCategorias.Text = "Ver detalle de categorias";
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmCategorias";
            this.Text = "Categorias";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accionesImportantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaYListadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiBuscarCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsmiListarCategorias;
        private System.Windows.Forms.ToolStripMenuItem tsmiVerDetalleCategorias;
        private System.Windows.Forms.ToolStripMenuItem tsmiAgregarCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminarCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificarCategoria;
    }
}