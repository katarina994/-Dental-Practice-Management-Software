namespace Klijent
{
    partial class GlavnaForma
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
            this.pacijentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intervencijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosTerminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaTerminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosIntervencijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacijentToolStripMenuItem,
            this.intervencijaToolStripMenuItem,
            this.terminaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacijentToolStripMenuItem
            // 
            this.pacijentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.pretragaToolStripMenuItem});
            this.pacijentToolStripMenuItem.Name = "pacijentToolStripMenuItem";
            this.pacijentToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pacijentToolStripMenuItem.Text = "Pacijent";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.unosToolStripMenuItem.Text = "Unos";
            this.unosToolStripMenuItem.Click += new System.EventHandler(this.unosToolStripMenuItem_Click);
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // intervencijaToolStripMenuItem
            // 
            this.intervencijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosIntervencijeToolStripMenuItem});
            this.intervencijaToolStripMenuItem.Name = "intervencijaToolStripMenuItem";
            this.intervencijaToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.intervencijaToolStripMenuItem.Text = "Intervencija";
            // 
            // terminaToolStripMenuItem
            // 
            this.terminaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosTerminaToolStripMenuItem,
            this.pretragaTerminaToolStripMenuItem});
            this.terminaToolStripMenuItem.Name = "terminaToolStripMenuItem";
            this.terminaToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.terminaToolStripMenuItem.Text = "Termina";
            // 
            // unosTerminaToolStripMenuItem
            // 
            this.unosTerminaToolStripMenuItem.Name = "unosTerminaToolStripMenuItem";
            this.unosTerminaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.unosTerminaToolStripMenuItem.Text = "Unos termina";
            this.unosTerminaToolStripMenuItem.Click += new System.EventHandler(this.unosTerminaToolStripMenuItem_Click);
            // 
            // pretragaTerminaToolStripMenuItem
            // 
            this.pretragaTerminaToolStripMenuItem.Name = "pretragaTerminaToolStripMenuItem";
            this.pretragaTerminaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.pretragaTerminaToolStripMenuItem.Text = "Pretraga termina";
            this.pretragaTerminaToolStripMenuItem.Click += new System.EventHandler(this.pretragaTerminaToolStripMenuItem_Click);
            // 
            // unosIntervencijeToolStripMenuItem
            // 
            this.unosIntervencijeToolStripMenuItem.Name = "unosIntervencijeToolStripMenuItem";
            this.unosIntervencijeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unosIntervencijeToolStripMenuItem.Text = "Unos intervencije";
            this.unosIntervencijeToolStripMenuItem.Click += new System.EventHandler(this.unosIntervencijeToolStripMenuItem_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GlavnaForma";
            this.Text = "GlavnaForma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GlavnaForma_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacijentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intervencijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosTerminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaTerminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosIntervencijeToolStripMenuItem;
    }
}