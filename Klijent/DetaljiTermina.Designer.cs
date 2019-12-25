namespace Klijent
{
    partial class DetaljiTermina
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
            this.gbTermin = new System.Windows.Forms.GroupBox();
            this.cmbPacijent = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.txtVreme = new System.Windows.Forms.MaskedTextBox();
            this.txtBelska = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbIntervencija = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTermin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTermin
            // 
            this.gbTermin.Controls.Add(this.cmbPacijent);
            this.gbTermin.Controls.Add(this.button4);
            this.gbTermin.Controls.Add(this.dgvGrid);
            this.gbTermin.Controls.Add(this.txtVreme);
            this.gbTermin.Controls.Add(this.txtBelska);
            this.gbTermin.Controls.Add(this.label7);
            this.gbTermin.Controls.Add(this.button2);
            this.gbTermin.Controls.Add(this.button1);
            this.gbTermin.Controls.Add(this.label6);
            this.gbTermin.Controls.Add(this.cmbIntervencija);
            this.gbTermin.Controls.Add(this.label5);
            this.gbTermin.Controls.Add(this.dtpDatum);
            this.gbTermin.Controls.Add(this.label4);
            this.gbTermin.Controls.Add(this.label3);
            this.gbTermin.Controls.Add(this.label2);
            this.gbTermin.Location = new System.Drawing.Point(16, 15);
            this.gbTermin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTermin.Name = "gbTermin";
            this.gbTermin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTermin.Size = new System.Drawing.Size(616, 636);
            this.gbTermin.TabIndex = 4;
            this.gbTermin.TabStop = false;
            this.gbTermin.Text = "Podaci o terminu";
            // 
            // cmbPacijent
            // 
            this.cmbPacijent.FormattingEnabled = true;
            this.cmbPacijent.Location = new System.Drawing.Point(140, 127);
            this.cmbPacijent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPacijent.Name = "cmbPacijent";
            this.cmbPacijent.Size = new System.Drawing.Size(448, 24);
            this.cmbPacijent.TabIndex = 19;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 578);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(563, 42);
            this.button4.TabIndex = 18;
            this.button4.Text = "Otkazi termin";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvGrid
            // 
            this.dgvGrid.AllowUserToAddRows = false;
            this.dgvGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Location = new System.Drawing.Point(27, 375);
            this.dgvGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.RowHeadersWidth = 51;
            this.dgvGrid.Size = new System.Drawing.Size(563, 185);
            this.dgvGrid.TabIndex = 16;
            // 
            // txtVreme
            // 
            this.txtVreme.Location = new System.Drawing.Point(140, 82);
            this.txtVreme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVreme.Mask = "00:00";
            this.txtVreme.Name = "txtVreme";
            this.txtVreme.Size = new System.Drawing.Size(132, 22);
            this.txtVreme.TabIndex = 15;
            this.txtVreme.ValidatingType = typeof(System.DateTime);
            // 
            // txtBelska
            // 
            this.txtBelska.Location = new System.Drawing.Point(140, 252);
            this.txtBelska.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBelska.Multiline = true;
            this.txtBelska.Name = "txtBelska";
            this.txtBelska.Size = new System.Drawing.Size(448, 79);
            this.txtBelska.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Beleska:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 340);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Obrisi stavku";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 340);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dodaj stavku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Unos stavki termina";
            // 
            // cmbIntervencija
            // 
            this.cmbIntervencija.FormattingEnabled = true;
            this.cmbIntervencija.Location = new System.Drawing.Point(140, 219);
            this.cmbIntervencija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbIntervencija.Name = "cmbIntervencija";
            this.cmbIntervencija.Size = new System.Drawing.Size(448, 24);
            this.cmbIntervencija.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(21, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Intervencija:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(140, 43);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(448, 22);
            this.dtpDatum.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pacijent:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vreme (HH:mm):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum:";
            // 
            // DetaljiTermina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 671);
            this.Controls.Add(this.gbTermin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DetaljiTermina";
            this.Text = "DetaljiTermina";
            this.Load += new System.EventHandler(this.DetaljiTermina_Load);
            this.gbTermin.ResumeLayout(false);
            this.gbTermin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTermin;
        private System.Windows.Forms.DataGridView dgvGrid;
        private System.Windows.Forms.MaskedTextBox txtVreme;
        private System.Windows.Forms.TextBox txtBelska;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbIntervencija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cmbPacijent;
    }
}