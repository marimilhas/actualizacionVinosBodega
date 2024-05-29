namespace actualizacionVinosBodega.Pantalla
{
    partial class Inicio
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.registrarbodega = new FontAwesome.Sharp.IconMenuItem();
            this.registrarvarietal = new FontAwesome.Sharp.IconMenuItem();
            this.importaractualizacion = new FontAwesome.Sharp.IconMenuItem();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Gainsboro;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarbodega,
            this.registrarvarietal,
            this.importaractualizacion});
            this.menu.Location = new System.Drawing.Point(0, 67);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(884, 74);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // registrarbodega
            // 
            this.registrarbodega.AutoSize = false;
            this.registrarbodega.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.registrarbodega.IconColor = System.Drawing.Color.Black;
            this.registrarbodega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registrarbodega.IconSize = 50;
            this.registrarbodega.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.registrarbodega.Name = "registrarbodega";
            this.registrarbodega.Size = new System.Drawing.Size(122, 70);
            this.registrarbodega.Text = "Registrar Bodega";
            this.registrarbodega.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // registrarvarietal
            // 
            this.registrarvarietal.AutoSize = false;
            this.registrarvarietal.IconChar = FontAwesome.Sharp.IconChar.WineGlass;
            this.registrarvarietal.IconColor = System.Drawing.Color.Black;
            this.registrarvarietal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registrarvarietal.IconSize = 50;
            this.registrarvarietal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.registrarvarietal.Name = "registrarvarietal";
            this.registrarvarietal.Size = new System.Drawing.Size(122, 70);
            this.registrarvarietal.Text = "Registrar Varietal";
            this.registrarvarietal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // importaractualizacion
            // 
            this.importaractualizacion.AutoSize = false;
            this.importaractualizacion.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.importaractualizacion.IconColor = System.Drawing.Color.Black;
            this.importaractualizacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.importaractualizacion.IconSize = 50;
            this.importaractualizacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.importaractualizacion.Name = "importaractualizacion";
            this.importaractualizacion.Size = new System.Drawing.Size(180, 70);
            this.importaractualizacion.Text = "Importar Actualización Bodegas";
            this.importaractualizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.importaractualizacion.Click += new System.EventHandler(this.opcionImportarActualizacionBodega);
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.Brown;
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(884, 67);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "BONVINO";
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.White;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 141);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(884, 520);
            this.contenedor.TabIndex = 3;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem registrarbodega;
        private FontAwesome.Sharp.IconMenuItem registrarvarietal;
        private FontAwesome.Sharp.IconMenuItem importaractualizacion;
        private System.Windows.Forms.Panel contenedor;
    }
}