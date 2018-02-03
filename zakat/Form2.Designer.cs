namespace zakat
{
    partial class Form2
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
            this.mENU1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mENU2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saldoZakatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saldoInfaqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENU1ToolStripMenuItem,
            this.mENU2ToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENU1ToolStripMenuItem
            // 
            this.mENU1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrasiToolStripMenuItem});
            this.mENU1ToolStripMenuItem.Name = "mENU1ToolStripMenuItem";
            this.mENU1ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.mENU1ToolStripMenuItem.Text = "MENU 1";
            // 
            // registrasiToolStripMenuItem
            // 
            this.registrasiToolStripMenuItem.Name = "registrasiToolStripMenuItem";
            this.registrasiToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.registrasiToolStripMenuItem.Text = "Form Data User";
            this.registrasiToolStripMenuItem.Click += new System.EventHandler(this.registrasiToolStripMenuItem_Click);
            // 
            // mENU2ToolStripMenuItem
            // 
            this.mENU2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daftarUserToolStripMenuItem,
            this.saldoZakatToolStripMenuItem,
            this.saldoInfaqToolStripMenuItem});
            this.mENU2ToolStripMenuItem.Name = "mENU2ToolStripMenuItem";
            this.mENU2ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.mENU2ToolStripMenuItem.Text = "MENU2";
            // 
            // daftarUserToolStripMenuItem
            // 
            this.daftarUserToolStripMenuItem.Name = "daftarUserToolStripMenuItem";
            this.daftarUserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.daftarUserToolStripMenuItem.Text = "Daftar User";
            this.daftarUserToolStripMenuItem.Click += new System.EventHandler(this.daftarUserToolStripMenuItem_Click);
            // 
            // saldoZakatToolStripMenuItem
            // 
            this.saldoZakatToolStripMenuItem.Name = "saldoZakatToolStripMenuItem";
            this.saldoZakatToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saldoZakatToolStripMenuItem.Text = "Saldo Zakat";
            this.saldoZakatToolStripMenuItem.Click += new System.EventHandler(this.saldoZakatToolStripMenuItem_Click);
            // 
            // saldoInfaqToolStripMenuItem
            // 
            this.saldoInfaqToolStripMenuItem.Name = "saldoInfaqToolStripMenuItem";
            this.saldoInfaqToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saldoInfaqToolStripMenuItem.Text = "Saldo Infaq";
            this.saldoInfaqToolStripMenuItem.Click += new System.EventHandler(this.saldoInfaqToolStripMenuItem_Click);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 461);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form2";
            this.Text = "Menu Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENU1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mENU2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daftarUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saldoZakatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saldoInfaqToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
    }
}