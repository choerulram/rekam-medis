namespace siredis.antarmuka
{
    partial class FormPemeriksaanDokter
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
            this.btnSelesai = new System.Windows.Forms.Button();
            this.btnTambahObat = new System.Windows.Forms.Button();
            this.lpasien = new System.Windows.Forms.Label();
            this.ListBox2 = new System.Windows.Forms.ListBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.tDiagnosa = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.tKeluhan = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelesai
            // 
            this.btnSelesai.BackColor = System.Drawing.Color.Green;
            this.btnSelesai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelesai.Location = new System.Drawing.Point(29, 578);
            this.btnSelesai.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(1012, 52);
            this.btnSelesai.TabIndex = 38;
            this.btnSelesai.Text = "PERIKSA SELSESAI";
            this.btnSelesai.UseVisualStyleBackColor = false;
            // 
            // btnTambahObat
            // 
            this.btnTambahObat.BackColor = System.Drawing.Color.OrangeRed;
            this.btnTambahObat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahObat.Location = new System.Drawing.Point(613, 474);
            this.btnTambahObat.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambahObat.Name = "btnTambahObat";
            this.btnTambahObat.Size = new System.Drawing.Size(428, 52);
            this.btnTambahObat.TabIndex = 37;
            this.btnTambahObat.Text = "TAMBAH RESEP OBAT";
            this.btnTambahObat.UseVisualStyleBackColor = false;
            // 
            // lpasien
            // 
            this.lpasien.AutoSize = true;
            this.lpasien.Location = new System.Drawing.Point(25, 46);
            this.lpasien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lpasien.Name = "lpasien";
            this.lpasien.Size = new System.Drawing.Size(82, 16);
            this.lpasien.TabIndex = 36;
            this.lpasien.Text = "namapasien";
            // 
            // ListBox2
            // 
            this.ListBox2.FormattingEnabled = true;
            this.ListBox2.ItemHeight = 16;
            this.ListBox2.Location = new System.Drawing.Point(29, 377);
            this.ListBox2.Margin = new System.Windows.Forms.Padding(4);
            this.ListBox2.Name = "ListBox2";
            this.ListBox2.Size = new System.Drawing.Size(481, 148);
            this.ListBox2.TabIndex = 35;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(25, 339);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(120, 20);
            this.Label3.TabIndex = 34;
            this.Label3.Text = "Resep Obat :";
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 16;
            this.ListBox1.Location = new System.Drawing.Point(613, 20);
            this.ListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(427, 436);
            this.ListBox1.TabIndex = 33;
            // 
            // tDiagnosa
            // 
            this.tDiagnosa.Location = new System.Drawing.Point(29, 236);
            this.tDiagnosa.Margin = new System.Windows.Forms.Padding(4);
            this.tDiagnosa.Multiline = true;
            this.tDiagnosa.Name = "tDiagnosa";
            this.tDiagnosa.Size = new System.Drawing.Size(481, 82);
            this.tDiagnosa.TabIndex = 32;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(25, 211);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 20);
            this.Label2.TabIndex = 31;
            this.Label2.Text = "Diagnosa :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(25, 20);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(69, 20);
            this.Label1.TabIndex = 30;
            this.Label1.Text = "Nama :";
            // 
            // tKeluhan
            // 
            this.tKeluhan.Location = new System.Drawing.Point(29, 110);
            this.tKeluhan.Margin = new System.Windows.Forms.Padding(4);
            this.tKeluhan.Multiline = true;
            this.tKeluhan.Name = "tKeluhan";
            this.tKeluhan.Size = new System.Drawing.Size(481, 82);
            this.tKeluhan.TabIndex = 29;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(25, 85);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(88, 20);
            this.Label8.TabIndex = 28;
            this.Label8.Text = "Keluhan :";
            // 
            // FormPemeriksaanDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 651);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnTambahObat);
            this.Controls.Add(this.lpasien);
            this.Controls.Add(this.ListBox2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.tDiagnosa);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.tKeluhan);
            this.Controls.Add(this.Label8);
            this.Name = "FormPemeriksaanDokter";
            this.Text = "FormPemeriksaanDokter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnSelesai;
        internal System.Windows.Forms.Button btnTambahObat;
        internal System.Windows.Forms.Label lpasien;
        internal System.Windows.Forms.ListBox ListBox2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.TextBox tDiagnosa;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox tKeluhan;
        internal System.Windows.Forms.Label Label8;
    }
}