﻿
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accionesImportantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAgregarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaYListadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBuscarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListarArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVerDetalleArticulos = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsmiAgregarArticulo,
            this.tsmiEliminarArticulo,
            this.tsmiModificarArticulo});
            this.accionesImportantesToolStripMenuItem.Name = "accionesImportantesToolStripMenuItem";
            this.accionesImportantesToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.accionesImportantesToolStripMenuItem.Text = "&Acciones Importantes";
            // 
            // tsmiAgregarArticulo
            // 
            this.tsmiAgregarArticulo.Name = "tsmiAgregarArticulo";
            this.tsmiAgregarArticulo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.tsmiAgregarArticulo.Size = new System.Drawing.Size(204, 22);
            this.tsmiAgregarArticulo.Text = "Agregar articulo";
            // 
            // tsmiEliminarArticulo
            // 
            this.tsmiEliminarArticulo.Name = "tsmiEliminarArticulo";
            this.tsmiEliminarArticulo.Size = new System.Drawing.Size(204, 22);
            this.tsmiEliminarArticulo.Text = "Eliminar articulo";
            // 
            // tsmiModificarArticulo
            // 
            this.tsmiModificarArticulo.Name = "tsmiModificarArticulo";
            this.tsmiModificarArticulo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.tsmiModificarArticulo.Size = new System.Drawing.Size(204, 22);
            this.tsmiModificarArticulo.Text = "Modificar articulo";
            // 
            // busquedaYListadoToolStripMenuItem
            // 
            this.busquedaYListadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBuscarArticulo,
            this.tsmiListarArticulos,
            this.tsmiVerDetalleArticulos});
            this.busquedaYListadoToolStripMenuItem.Name = "busquedaYListadoToolStripMenuItem";
            this.busquedaYListadoToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.busquedaYListadoToolStripMenuItem.Text = "&Busqueda y listado";
            // 
            // tsmiBuscarArticulo
            // 
            this.tsmiBuscarArticulo.Name = "tsmiBuscarArticulo";
            this.tsmiBuscarArticulo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.tsmiBuscarArticulo.Size = new System.Drawing.Size(197, 22);
            this.tsmiBuscarArticulo.Text = "Buscar articulo";
            // 
            // tsmiListarArticulos
            // 
            this.tsmiListarArticulos.Name = "tsmiListarArticulos";
            this.tsmiListarArticulos.Size = new System.Drawing.Size(197, 22);
            this.tsmiListarArticulos.Text = "Listar articulos";
            // 
            // tsmiVerDetalleArticulos
            // 
            this.tsmiVerDetalleArticulos.Name = "tsmiVerDetalleArticulos";
            this.tsmiVerDetalleArticulos.Size = new System.Drawing.Size(197, 22);
            this.tsmiVerDetalleArticulos.Text = "Ver detalles de articulos";
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmArticulos";
            this.Text = "Articulos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accionesImportantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAgregarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificarArticulo;
        private System.Windows.Forms.ToolStripMenuItem busquedaYListadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiBuscarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tsmiListarArticulos;
        private System.Windows.Forms.ToolStripMenuItem tsmiVerDetalleArticulos;
    }
}