namespace siredis.antarmuka
{
    partial class DataPasien
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
            this.tId = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label8 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnPerbarui = new System.Windows.Forms.Button();
            this.tUmur = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.tCari = new System.Windows.Forms.TextBox();
            this.tNama = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.tNokartu = new System.Windows.Forms.TextBox();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Label6 = new System.Windows.Forms.Label();
            this.pasien_dgv = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pasien_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(224)))));
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(-127, -4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1427, 95);
            this.Panel1.TabIndex = 33;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Bookman Old Style", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Snow;
            this.Label1.Location = new System.Drawing.Point(409, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(721, 63);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "APLIKASI REKAM MEDIS";
            // 
            // tId
            // 
            this.tId.Location = new System.Drawing.Point(14, 99);
            this.tId.Name = "tId";
            this.tId.Size = new System.Drawing.Size(178, 20);
            this.tId.TabIndex = 20;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Laki - laki",
            "Perempuan"});
            this.cbGender.Location = new System.Drawing.Point(469, 39);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(176, 21);
            this.cbGender.TabIndex = 21;
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.btnClear);
            this.Panel2.Controls.Add(this.cbGender);
            this.Panel2.Controls.Add(this.tId);
            this.Panel2.Controls.Add(this.Label8);
            this.Panel2.Controls.Add(this.btnHapus);
            this.Panel2.Controls.Add(this.btnCari);
            this.Panel2.Controls.Add(this.btnPerbarui);
            this.Panel2.Controls.Add(this.tUmur);
            this.Panel2.Controls.Add(this.Label7);
            this.Panel2.Controls.Add(this.btnTambah);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Controls.Add(this.tCari);
            this.Panel2.Controls.Add(this.tNama);
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Controls.Add(this.tNokartu);
            this.Panel2.Location = new System.Drawing.Point(7, 140);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1268, 135);
            this.Panel2.TabIndex = 34;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(235, 9);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(82, 17);
            this.Label8.TabIndex = 19;
            this.Label8.Text = "No Kartu :";
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Crimson;
            this.btnHapus.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.btnHapus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHapus.Location = new System.Drawing.Point(852, 53);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(92, 33);
            this.btnHapus.TabIndex = 7;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.btnCari.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.btnCari.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCari.Location = new System.Drawing.Point(959, 93);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(117, 29);
            this.btnCari.TabIndex = 8;
            this.btnCari.Text = "CARI";
            this.btnCari.UseVisualStyleBackColor = false;
            // 
            // btnPerbarui
            // 
            this.btnPerbarui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(54)))));
            this.btnPerbarui.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.btnPerbarui.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPerbarui.Location = new System.Drawing.Point(852, 10);
            this.btnPerbarui.Name = "btnPerbarui";
            this.btnPerbarui.Size = new System.Drawing.Size(91, 33);
            this.btnPerbarui.TabIndex = 6;
            this.btnPerbarui.Text = "EDIT";
            this.btnPerbarui.UseVisualStyleBackColor = false;
            this.btnPerbarui.Click += new System.EventHandler(this.btnPerbarui_Click);
            // 
            // tUmur
            // 
            this.tUmur.Location = new System.Drawing.Point(238, 99);
            this.tUmur.Name = "tUmur";
            this.tUmur.Size = new System.Drawing.Size(178, 20);
            this.tUmur.TabIndex = 3;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(13, 69);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(33, 17);
            this.Label7.TabIndex = 17;
            this.Label7.Text = "ID :";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.btnTambah.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.btnTambah.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTambah.Location = new System.Drawing.Point(720, 10);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(117, 76);
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
            this.Label3.Size = new System.Drawing.Size(113, 17);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Nama Pasien :";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(465, 9);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(118, 17);
            this.Label5.TabIndex = 15;
            this.Label5.Text = "Jenis Kelamin :";
            // 
            // tCari
            // 
            this.tCari.Location = new System.Drawing.Point(720, 94);
            this.tCari.Multiline = true;
            this.tCari.Name = "tCari";
            this.tCari.Size = new System.Drawing.Size(233, 25);
            this.tCari.TabIndex = 13;
            this.tCari.TextChanged += new System.EventHandler(this.tCari_TextChanged);
            // 
            // tNama
            // 
            this.tNama.Location = new System.Drawing.Point(14, 39);
            this.tNama.Name = "tNama";
            this.tNama.Size = new System.Drawing.Size(178, 20);
            this.tNama.TabIndex = 0;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(235, 69);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(56, 17);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "Umur :";
            // 
            // tNokartu
            // 
            this.tNokartu.Location = new System.Drawing.Point(238, 39);
            this.tNokartu.Name = "tNokartu";
            this.tNokartu.Size = new System.Drawing.Size(176, 20);
            this.tNokartu.TabIndex = 14;
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Location = new System.Drawing.Point(17, 112);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(35, 13);
            this.LinkLabel1.TabIndex = 35;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "Home";
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(59, 112);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(74, 13);
            this.Label6.TabIndex = 36;
            this.Label6.Text = "> Data Pasien";
            // 
            // pasien_dgv
            // 
            this.pasien_dgv.AllowUserToAddRows = false;
            this.pasien_dgv.AllowUserToDeleteRows = false;
            this.pasien_dgv.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pasien_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pasien_dgv.Location = new System.Drawing.Point(7, 281);
            this.pasien_dgv.Name = "pasien_dgv";
            this.pasien_dgv.ReadOnly = true;
            this.pasien_dgv.RowHeadersWidth = 62;
            this.pasien_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pasien_dgv.Size = new System.Drawing.Size(1267, 320);
            this.pasien_dgv.TabIndex = 37;
            this.pasien_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pasien_dgv_CellClick);
            this.pasien_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pasien_dgv_CellContentClick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.btnClear.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(959, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 76);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // DataPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 617);
            this.Controls.Add(this.pasien_dgv);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.LinkLabel1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DataPasien";
            this.Text = "DataPasien";
            this.Load += new System.EventHandler(this.DataPasien_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pasien_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox tId;
        internal System.Windows.Forms.ComboBox cbGender;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button btnHapus;
        internal System.Windows.Forms.Button btnCari;
        internal System.Windows.Forms.Button btnPerbarui;
        internal System.Windows.Forms.TextBox tUmur;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button btnTambah;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox tCari;
        internal System.Windows.Forms.TextBox tNama;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox tNokartu;
        internal System.Windows.Forms.LinkLabel LinkLabel1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.DataGridView pasien_dgv;
        internal System.Windows.Forms.Button btnClear;
    }
}