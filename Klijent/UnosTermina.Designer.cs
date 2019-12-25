namespace Klijent
{
    partial class UnosTermina
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.gbTermin = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.cmbPacijent = new System.Windows.Forms.ComboBox();
            this.cmbIntervencija = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBelska = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVreme = new System.Windows.Forms.MaskedTextBox();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.gbTermin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TerminaID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(87, 17);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(140, 20);
            this.txtID.TabIndex = 1;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(267, 15);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(200, 23);
            this.btnKreiraj.TabIndex = 2;
            this.btnKreiraj.Text = "Kreiraj termin";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // gbTermin
            // 
            this.gbTermin.Controls.Add(this.button3);
            this.gbTermin.Controls.Add(this.dgvGrid);
            this.gbTermin.Controls.Add(this.txtVreme);
            this.gbTermin.Controls.Add(this.txtBelska);
            this.gbTermin.Controls.Add(this.label7);
            this.gbTermin.Controls.Add(this.button2);
            this.gbTermin.Controls.Add(this.button1);
            this.gbTermin.Controls.Add(this.label6);
            this.gbTermin.Controls.Add(this.cmbIntervencija);
            this.gbTermin.Controls.Add(this.label5);
            this.gbTermin.Controls.Add(this.cmbPacijent);
            this.gbTermin.Controls.Add(this.dtpDatum);
            this.gbTermin.Controls.Add(this.label4);
            this.gbTermin.Controls.Add(this.label3);
            this.gbTermin.Controls.Add(this.label2);
            this.gbTermin.Enabled = false;
            this.gbTermin.Location = new System.Drawing.Point(25, 52);
            this.gbTermin.Name = "gbTermin";
            this.gbTermin.Size = new System.Drawing.Size(462, 517);
            this.gbTermin.TabIndex = 3;
            this.gbTermin.TabStop = false;
            this.gbTermin.Text = "Podaci o terminu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vreme (HH:mm):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pacijent:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(105, 35);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(337, 20);
            this.dtpDatum.TabIndex = 7;
            // 
            // cmbPacijent
            // 
            this.cmbPacijent.FormattingEnabled = true;
            this.cmbPacijent.Location = new System.Drawing.Point(105, 103);
            this.cmbPacijent.Name = "cmbPacijent";
            this.cmbPacijent.Size = new System.Drawing.Size(337, 21);
            this.cmbPacijent.TabIndex = 8;
            // 
            // cmbIntervencija
            // 
            this.cmbIntervencija.FormattingEnabled = true;
            this.cmbIntervencija.Location = new System.Drawing.Point(105, 178);
            this.cmbIntervencija.Name = "cmbIntervencija";
            this.cmbIntervencija.Size = new System.Drawing.Size(337, 21);
            this.cmbIntervencija.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(16, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Intervencija:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Unos stavki termina";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dodaj stavku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Obrisi stavku";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBelska
            // 
            this.txtBelska.Location = new System.Drawing.Point(105, 205);
            this.txtBelska.Multiline = true;
            this.txtBelska.Name = "txtBelska";
            this.txtBelska.Size = new System.Drawing.Size(337, 65);
            this.txtBelska.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Beleska:";
            // 
            // txtVreme
            // 
            this.txtVreme.Location = new System.Drawing.Point(105, 67);
            this.txtVreme.Mask = "00:00";
            this.txtVreme.Name = "txtVreme";
            this.txtVreme.Size = new System.Drawing.Size(100, 20);
            this.txtVreme.TabIndex = 15;
            this.txtVreme.ValidatingType = typeof(System.DateTime);
            // 
            // dgvGrid
            // 
            this.dgvGrid.AllowUserToAddRows = false;
            this.dgvGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Location = new System.Drawing.Point(20, 305);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.Size = new System.Drawing.Size(422, 150);
            this.dgvGrid.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 470);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(422, 34);
            this.button3.TabIndex = 17;
            this.button3.Text = "Sacuvaj termin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UnosTermina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 575);
            this.Controls.Add(this.gbTermin);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "UnosTermina";
            this.Text = "UnosTermina";
            this.gbTermin.ResumeLayout(false);
            this.gbTermin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.GroupBox gbTermin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvGrid;
        private System.Windows.Forms.MaskedTextBox txtVreme;
        private System.Windows.Forms.TextBox txtBelska;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbIntervencija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPacijent;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}