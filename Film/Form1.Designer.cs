namespace Film
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decidereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpricerca = new System.Windows.Forms.TabPage();
            this.lblTPRicerca = new System.Windows.Forms.Label();
            this.lsbTPInserisci = new System.Windows.Forms.ListBox();
            this.tbpinserisci = new System.Windows.Forms.TabPage();
            this.txbTPRicerca = new System.Windows.Forms.TextBox();
            this.rbTPInserisciDvd = new System.Windows.Forms.RadioButton();
            this.rbTPInserisciBluRay = new System.Windows.Forms.RadioButton();
            this.btnTPInserisciRicerca = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpricerca.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.decidereToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caricaToolStripMenuItem,
            this.salvaToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // caricaToolStripMenuItem
            // 
            this.caricaToolStripMenuItem.Name = "caricaToolStripMenuItem";
            this.caricaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.caricaToolStripMenuItem.Text = "carica";
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvaToolStripMenuItem.Text = "salva";
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.esciToolStripMenuItem.Text = "esci";
            // 
            // decidereToolStripMenuItem
            // 
            this.decidereToolStripMenuItem.Name = "decidereToolStripMenuItem";
            this.decidereToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.decidereToolStripMenuItem.Text = "decidere";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.aboutToolStripMenuItem.Text = "about";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpricerca);
            this.tabControl1.Controls.Add(this.tbpinserisci);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tbpricerca
            // 
            this.tbpricerca.Controls.Add(this.btnTPInserisciRicerca);
            this.tbpricerca.Controls.Add(this.rbTPInserisciBluRay);
            this.tbpricerca.Controls.Add(this.rbTPInserisciDvd);
            this.tbpricerca.Controls.Add(this.txbTPRicerca);
            this.tbpricerca.Controls.Add(this.lblTPRicerca);
            this.tbpricerca.Controls.Add(this.lsbTPInserisci);
            this.tbpricerca.Location = new System.Drawing.Point(4, 22);
            this.tbpricerca.Name = "tbpricerca";
            this.tbpricerca.Padding = new System.Windows.Forms.Padding(3);
            this.tbpricerca.Size = new System.Drawing.Size(792, 400);
            this.tbpricerca.TabIndex = 0;
            this.tbpricerca.Text = "Ricerca";
            this.tbpricerca.UseVisualStyleBackColor = true;
            // 
            // lblTPRicerca
            // 
            this.lblTPRicerca.AutoSize = true;
            this.lblTPRicerca.Location = new System.Drawing.Point(30, 54);
            this.lblTPRicerca.Name = "lblTPRicerca";
            this.lblTPRicerca.Size = new System.Drawing.Size(33, 13);
            this.lblTPRicerca.TabIndex = 1;
            this.lblTPRicerca.Text = "Titolo";
            this.lblTPRicerca.Click += new System.EventHandler(this.label1_Click);
            // 
            // lsbTPInserisci
            // 
            this.lsbTPInserisci.FormattingEnabled = true;
            this.lsbTPInserisci.Location = new System.Drawing.Point(46, 107);
            this.lsbTPInserisci.Name = "lsbTPInserisci";
            this.lsbTPInserisci.Size = new System.Drawing.Size(120, 95);
            this.lsbTPInserisci.TabIndex = 0;
            // 
            // tbpinserisci
            // 
            this.tbpinserisci.Location = new System.Drawing.Point(4, 22);
            this.tbpinserisci.Name = "tbpinserisci";
            this.tbpinserisci.Padding = new System.Windows.Forms.Padding(3);
            this.tbpinserisci.Size = new System.Drawing.Size(792, 400);
            this.tbpinserisci.TabIndex = 1;
            this.tbpinserisci.Text = "Inserisci";
            this.tbpinserisci.UseVisualStyleBackColor = true;
            // 
            // txbTPRicerca
            // 
            this.txbTPRicerca.Location = new System.Drawing.Point(98, 47);
            this.txbTPRicerca.Name = "txbTPRicerca";
            this.txbTPRicerca.Size = new System.Drawing.Size(100, 20);
            this.txbTPRicerca.TabIndex = 2;
            // 
            // rbTPInserisciDvd
            // 
            this.rbTPInserisciDvd.AutoSize = true;
            this.rbTPInserisciDvd.Location = new System.Drawing.Point(223, 50);
            this.rbTPInserisciDvd.Name = "rbTPInserisciDvd";
            this.rbTPInserisciDvd.Size = new System.Drawing.Size(48, 17);
            this.rbTPInserisciDvd.TabIndex = 3;
            this.rbTPInserisciDvd.Text = "DVD";
            this.rbTPInserisciDvd.UseVisualStyleBackColor = true;
            // 
            // rbTPInserisciBluRay
            // 
            this.rbTPInserisciBluRay.AutoSize = true;
            this.rbTPInserisciBluRay.Checked = true;
            this.rbTPInserisciBluRay.Location = new System.Drawing.Point(335, 47);
            this.rbTPInserisciBluRay.Name = "rbTPInserisciBluRay";
            this.rbTPInserisciBluRay.Size = new System.Drawing.Size(59, 17);
            this.rbTPInserisciBluRay.TabIndex = 4;
            this.rbTPInserisciBluRay.TabStop = true;
            this.rbTPInserisciBluRay.Text = "BluRay";
            this.rbTPInserisciBluRay.UseVisualStyleBackColor = true;
            // 
            // btnTPInserisciRicerca
            // 
            this.btnTPInserisciRicerca.Location = new System.Drawing.Point(290, 107);
            this.btnTPInserisciRicerca.Name = "btnTPInserisciRicerca";
            this.btnTPInserisciRicerca.Size = new System.Drawing.Size(75, 23);
            this.btnTPInserisciRicerca.TabIndex = 5;
            this.btnTPInserisciRicerca.Text = "Ricerca";
            this.btnTPInserisciRicerca.UseVisualStyleBackColor = true;
            this.btnTPInserisciRicerca.Click += new System.EventHandler(this.btnTPInserisciRicerca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Film";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbpricerca.ResumeLayout(false);
            this.tbpricerca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caricaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decidereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpricerca;
        private System.Windows.Forms.ListBox lsbTPInserisci;
        private System.Windows.Forms.TabPage tbpinserisci;
        private System.Windows.Forms.Label lblTPRicerca;
        private System.Windows.Forms.TextBox txbTPRicerca;
        private System.Windows.Forms.RadioButton rbTPInserisciBluRay;
        private System.Windows.Forms.RadioButton rbTPInserisciDvd;
        private System.Windows.Forms.Button btnTPInserisciRicerca;
    }
}

