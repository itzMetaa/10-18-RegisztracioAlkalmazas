namespace RegisztracioAlkalmazas
{
    partial class Regisztráció
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.textBoxSzulDatum = new System.Windows.Forms.TextBox();
            this.textBoxUjHobbi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnBetoltes = new System.Windows.Forms.Button();
            this.listBoxHobbik = new System.Windows.Forms.ListBox();
            this.radioFerfi = new System.Windows.Forms.RadioButton();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Szül. dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kedvenc Hobbi:";
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(78, 25);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(100, 20);
            this.textBoxNev.TabIndex = 6;
            // 
            // textBoxSzulDatum
            // 
            this.textBoxSzulDatum.Location = new System.Drawing.Point(78, 56);
            this.textBoxSzulDatum.Name = "textBoxSzulDatum";
            this.textBoxSzulDatum.Size = new System.Drawing.Size(100, 20);
            this.textBoxSzulDatum.TabIndex = 7;
            // 
            // textBoxUjHobbi
            // 
            this.textBoxUjHobbi.Location = new System.Drawing.Point(193, 139);
            this.textBoxUjHobbi.Name = "textBoxUjHobbi";
            this.textBoxUjHobbi.Size = new System.Drawing.Size(120, 20);
            this.textBoxUjHobbi.TabIndex = 8;
            this.textBoxUjHobbi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUjHobbi_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Új hobbi:";
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.Location = new System.Drawing.Point(238, 165);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(75, 23);
            this.btnHozzaad.TabIndex = 10;
            this.btnHozzaad.Text = "Hozzáad";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(157, 210);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(75, 23);
            this.btnMentes.TabIndex = 11;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // btnBetoltes
            // 
            this.btnBetoltes.Location = new System.Drawing.Point(238, 210);
            this.btnBetoltes.Name = "btnBetoltes";
            this.btnBetoltes.Size = new System.Drawing.Size(75, 23);
            this.btnBetoltes.TabIndex = 12;
            this.btnBetoltes.Text = "Betöltés";
            this.btnBetoltes.UseVisualStyleBackColor = true;
            this.btnBetoltes.Click += new System.EventHandler(this.btnBetoltes_Click);
            // 
            // listBoxHobbik
            // 
            this.listBoxHobbik.FormattingEnabled = true;
            this.listBoxHobbik.Location = new System.Drawing.Point(193, 24);
            this.listBoxHobbik.Name = "listBoxHobbik";
            this.listBoxHobbik.Size = new System.Drawing.Size(120, 95);
            this.listBoxHobbik.TabIndex = 13;
            // 
            // radioFerfi
            // 
            this.radioFerfi.AutoSize = true;
            this.radioFerfi.Location = new System.Drawing.Point(78, 92);
            this.radioFerfi.Name = "radioFerfi";
            this.radioFerfi.Size = new System.Drawing.Size(45, 17);
            this.radioFerfi.TabIndex = 14;
            this.radioFerfi.TabStop = true;
            this.radioFerfi.Text = "Férfi";
            this.radioFerfi.UseVisualStyleBackColor = true;
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Location = new System.Drawing.Point(78, 115);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(39, 17);
            this.radioNo.TabIndex = 15;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "Nő";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Szöveges fájl|*.txt";
            this.saveFileDialog1.Tag = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Regisztráció
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 241);
            this.Controls.Add(this.radioNo);
            this.Controls.Add(this.radioFerfi);
            this.Controls.Add(this.listBoxHobbik);
            this.Controls.Add(this.btnBetoltes);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnHozzaad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxUjHobbi);
            this.Controls.Add(this.textBoxSzulDatum);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Regisztráció";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.TextBox textBoxSzulDatum;
        private System.Windows.Forms.TextBox textBoxUjHobbi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnBetoltes;
        private System.Windows.Forms.ListBox listBoxHobbik;
        private System.Windows.Forms.RadioButton radioFerfi;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

