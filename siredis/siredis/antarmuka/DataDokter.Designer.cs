namespace siredis.antarmuka
{
    partial class DataDokter
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.tSpesialis = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tUsername = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.tNama = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Homelb = new System.Windows.Forms.LinkLabel();
            this.dokter_dgv = new System.Windows.Forms.DataGridView();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dokter_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(224)))));
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(-126, 1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1413, 95);
            this.Panel1.TabIndex = 25;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Bookman Old Style", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Snow;
            this.Label1.Location = new System.Drawing.Point(404, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(721, 63);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "APLIKASI REKAM MEDIS";
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.cbGender);
            this.Panel2.Controls.Add(this.Label8);
            this.Panel2.Controls.Add(this.btnHapus);
            this.Panel2.Controls.Add(this.btnCari);
            this.Panel2.Controls.Add(this.tSpesialis);
            this.Panel2.Controls.Add(this.btnEdit);
            this.Panel2.Controls.Add(this.tUsername);
            this.Panel2.Controls.Add(this.Label7);
            this.Panel2.Controls.Add(this.btnTambah);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Controls.Add(this.cari_txt);
            this.Panel2.Controls.Add(this.tNama);
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Controls.Add(this.tPassword);
            this.Panel2.Location = new System.Drawing.Point(9, 145);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1266, 135);
            this.Panel2.TabIndex = 26;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Laki - laki",
            "Perempuan"});
            this.cbGender.Location = new System.Drawing.Point(16, 88);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(176, 21);
            this.cbGender.TabIndex = 20;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(228, 26);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(83, 17);
            this.Label8.TabIndex = 19;
            this.Label8.Text = "Spesialis :";
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Crimson;
            this.btnHapus.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.btnHapus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHapus.Location = new System.Drawing.Point(985, 26);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(92, 33);
            this.btnHapus.TabIndex = 7;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = false;
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.btnCari.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.btnCari.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCari.Location = new System.Drawing.Point(1119, 93);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(117, 29);
            this.btnCari.TabIndex = 8;
            this.btnCari.Text = "CARI";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // tSpesialis
            // 
            this.tSpesialis.Location = new System.Drawing.Point(231, 46);
            this.tSpesialis.Multiline = true;
            this.tSpesialis.Name = "tSpesialis";
            this.tSpesialis.Size = new System.Drawing.Size(176, 63);
            this.tSpesialis.TabIndex = 18;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(54)))));
            this.btnEdit.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(869, 26);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 33);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // tUsername
            // 
            this.tUsername.Location = new System.Drawing.Point(446, 46);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(176, 20);
            this.tUsername.TabIndex = 3;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(13, 69);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(118, 17);
            this.Label7.TabIndex = 17;
            this.Label7.Text = "Jenis Kelamin :";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.btnTambah.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.btnTambah.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTambah.Location = new System.Drawing.Point(751, 26);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(90, 33);
            this.btnTambah.TabIndex = 5;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(11, 9);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(59, 17);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Nama :";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(443, 69);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(87, 17);
            this.Label5.TabIndex = 15;
            this.Label5.Text = "Password :";
            // 
            // cari_txt
            // 
            this.cari_txt.Location = new System.Drawing.Point(933, 101);
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(176, 20);
            this.cari_txt.TabIndex = 13;
            this.cari_txt.TextChanged += new System.EventHandler(this.cari_txt_TextChanged);
            // 
            // tNama
            // 
            this.tNama.Location = new System.Drawing.Point(14, 36);
            this.tNama.Name = "tNama";
            this.tNama.Size = new System.Drawing.Size(178, 20);
            this.tNama.TabIndex = 0;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(443, 26);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(91, 17);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "Username :";
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(446, 89);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(176, 20);
            this.tPassword.TabIndex = 14;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(60, 117);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(74, 13);
            this.Label6.TabIndex = 31;
            this.Label6.Text = "> Data Dokter";
            // 
            // Homelb
            // 
            this.Homelb.AutoSize = true;
            this.Homelb.Location = new System.Drawing.Point(19, 117);
            this.Homelb.Name = "Homelb";
            this.Homelb.Size = new System.Drawing.Size(35, 13);
            this.Homelb.TabIndex = 30;
            this.Homelb.TabStop = true;
            this.Homelb.Text = "Home";
            this.Homelb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Homelb_LinkClicked);
            // 
            // dokter_dgv
            // 
            this.dokter_dgv.AllowUserToAddRows = false;
            this.dokter_dgv.AllowUserToDeleteRows = false;
            this.dokter_dgv.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dokter_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dokter_dgv.Location = new System.Drawing.Point(9, 288);
            this.dokter_dgv.Name = "dokter_dgv";
            this.dokter_dgv.ReadOnly = true;
            this.dokter_dgv.RowHeadersWidth = 62;
            this.dokter_dgv.Size = new System.Drawing.Size(1265, 320);
            this.dokter_dgv.TabIndex = 32;
            this.dokter_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dokter_dgv_CellClick);
            this.dokter_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dokter_dgv_CellContentClick);
            // 
            // DataDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 617);
            this.Controls.Add(this.dokter_dgv);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Homelb);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Name = "DataDokter";
            this.Text = "DataDokter";
            this.Load += new System.EventHandler(this.DataDokter_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dokter_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button btnHapus;
        internal System.Windows.Forms.Button btnCari;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.TextBox tUsername;
        internal System.Windows.Forms.Button btnTambah;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox tNama;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.LinkLabel Homelb;
        internal System.Windows.Forms.ComboBox cbGender;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox tSpesialis;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox cari_txt;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox tPassword;
        internal System.Windows.Forms.DataGridView dokter_dgv;
    }
}