namespace zakat
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infaqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakatFitrahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakatPenghasilanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakatMaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infaqToolStripMenuItem,
            this.zakarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infaqToolStripMenuItem
            // 
            this.infaqToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donasiToolStripMenuItem});
            this.infaqToolStripMenuItem.Name = "infaqToolStripMenuItem";
            this.infaqToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.infaqToolStripMenuItem.Text = "Infaq";
            // 
            // donasiToolStripMenuItem
            // 
            this.donasiToolStripMenuItem.Name = "donasiToolStripMenuItem";
            this.donasiToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.donasiToolStripMenuItem.Text = "Donasi ";
            this.donasiToolStripMenuItem.Click += new System.EventHandler(this.donasiToolStripMenuItem_Click);
            // 
            // zakarToolStripMenuItem
            // 
            this.zakarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakatFitrahToolStripMenuItem,
            this.zakatPenghasilanToolStripMenuItem,
            this.zakatMaToolStripMenuItem});
            this.zakarToolStripMenuItem.Name = "zakarToolStripMenuItem";
            this.zakarToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.zakarToolStripMenuItem.Text = "Zakat";
            // 
            // zakatFitrahToolStripMenuItem
            // 
            this.zakatFitrahToolStripMenuItem.Name = "zakatFitrahToolStripMenuItem";
            this.zakatFitrahToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.zakatFitrahToolStripMenuItem.Text = "Zakat Fitrah";
            this.zakatFitrahToolStripMenuItem.Click += new System.EventHandler(this.zakatFitrahToolStripMenuItem_Click);
            // 
            // zakatPenghasilanToolStripMenuItem
            // 
            this.zakatPenghasilanToolStripMenuItem.Name = "zakatPenghasilanToolStripMenuItem";
            this.zakatPenghasilanToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.zakatPenghasilanToolStripMenuItem.Text = "Zakat Penghasilan";
            this.zakatPenghasilanToolStripMenuItem.Click += new System.EventHandler(this.zakatPenghasilanToolStripMenuItem_Click);
            // 
            // zakatMaToolStripMenuItem
            // 
            this.zakatMaToolStripMenuItem.Name = "zakatMaToolStripMenuItem";
            this.zakatMaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.zakatMaToolStripMenuItem.Text = "Zakat Maal";
            this.zakatMaToolStripMenuItem.Click += new System.EventHandler(this.zakatMaToolStripMenuItem_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form7";
            this.Text = "Form User";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infaqToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakatFitrahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakatPenghasilanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakatMaToolStripMenuItem;
    }
}