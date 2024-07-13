namespace siredis.antarmuka
{
    partial class FormPendaftaran
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
            this.components = new System.ComponentModel.Container();
            this.Homelb = new System.Windows.Forms.LinkLabel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.cbDokter = new System.Windows.Forms.ComboBox();
            this.cbPasien1 = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dtTanggal = new System.Windows.Forms.DateTimePicker();
            this.tKeluhan = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnPerbarui = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.pendaftaran_dgv = new System.Windows.Forms.DataGridView();
            this.btnCari = new System.Windows.Forms.Button();
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pendaftaran_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Homelb
            // 
            this.Homelb.AutoSize = true;
            this.Homelb.Location = new System.Drawing.Point(12, 112);
            this.Homelb.Name = "Homelb";
            this.Homelb.Size = new System.Drawing.Size(35, 13);
            this.Homelb.TabIndex = 28;
            this.Homelb.TabStop = true;
            this.Homelb.Text = "Home";
            this.Homelb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Homelb_LinkClicked);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(224)))));
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(-1, -1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1305, 95);
            this.Panel1.TabIndex = 24;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Bookman Old Style", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Snow;
            this.Label1.Location = new System.Drawing.Point(291, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(721, 63);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "APLIKASI REKAM MEDIS";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 659);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.StatusStrip1.TabIndex = 27;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(90, 17);
            this.ToolStripStatusLabel1.Text = "Total row data : ";
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.btnClear);
            this.Panel2.Controls.Add(this.cbDokter);
            this.Panel2.Controls.Add(this.cbPasien1);
            this.Panel2.Controls.Add(this.cbStatus);
            this.Panel2.Controls.Add(this.dtTanggal);
            this.Panel2.Controls.Add(this.tKeluhan);
            this.Panel2.Controls.Add(this.Label8);
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Controls.Add(this.Label7);
            this.Panel2.Controls.Add(this.btnHapus);
            this.Panel2.Controls.Add(this.btnPerbarui);
            this.Panel2.Controls.Add(this.btnTambah);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Location = new System.Drawing.Point(12, 142);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1240, 99);
            this.Panel2.TabIndex = 25;
            // 
            // cbDokter
            // 
            this.cbDokter.FormattingEnabled = true;
            this.cbDokter.Location = new System.Drawing.Point(14, 70);
            this.cbDokter.Name = "cbDokter";
            this.cbDokter.Size = new System.Drawing.Size(250, 21);
            this.cbDokter.TabIndex = 20;
            // 
            // cbPasien1
            // 
            this.cbPasien1.FormattingEnabled = true;
            this.cbPasien1.Location = new System.Drawing.Point(14, 27);
            this.cbPasien1.Name = "cbPasien1";
            this.cbPasien1.Size = new System.Drawing.Size(250, 21);
            this.cbPasien1.TabIndex = 19;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "pendaftaran",
            "pemeriksaan"});
            this.cbStatus.Location = new System.Drawing.Point(624, 69);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(250, 21);
            this.cbStatus.TabIndex = 18;
            // 
            // dtTanggal
            // 
            this.dtTanggal.Location = new System.Drawing.Point(624, 27);
            this.dtTanggal.Name = "dtTanggal";
            this.dtTanggal.Size = new System.Drawing.Size(250, 20);
            this.dtTanggal.TabIndex = 17;
            // 
            // tKeluhan
            // 
            this.tKeluhan.Location = new System.Drawing.Point(297, 23);
            this.tKeluhan.Multiline = true;
            this.tKeluhan.Name = "tKeluhan";
            this.tKeluhan.Size = new System.Drawing.Size(305, 67);
            this.tKeluhan.TabIndex = 16;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(294, 3);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(77, 17);
            this.Label8.TabIndex = 15;
            this.Label8.Text = "Keluhan :";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(11, 7);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(67, 17);
            this.Label4.TabIndex = 14;
            this.Label4.Text = "Pasien :";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(621, 7);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(77, 17);
            this.Label7.TabIndex = 9;
            this.Label7.Text = "Tanggal :";
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Crimson;
            this.btnHapus.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHapus.Location = new System.Drawing.Point(1016, 60);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(88, 31);
            this.btnHapus.TabIndex = 7;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnPerbarui
            // 
            this.btnPerbarui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(54)))));
            this.btnPerbarui.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerbarui.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPerbarui.Location = new System.Drawing.Point(1016, 15);
            this.btnPerbarui.Name = "btnPerbarui";
            this.btnPerbarui.Size = new System.Drawing.Size(88, 34);
            this.btnPerbarui.TabIndex = 6;
            this.btnPerbarui.Text = "EDIT";
            this.btnPerbarui.UseVisualStyleBackColor = false;
            this.btnPerbarui.Click += new System.EventHandler(this.btnPerbarui_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.btnTambah.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTambah.Location = new System.Drawing.Point(893, 15);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(117, 76);
            this.btnTambah.TabIndex = 5;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(621, 50);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(64, 17);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "Status :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(11, 50);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(66, 17);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Dokter :";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(53, 112);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(100, 13);
            this.Label6.TabIndex = 29;
            this.Label6.Text = "> Form Pendaftaran";
            // 
            // Panel3
            // 
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.pendaftaran_dgv);
            this.Panel3.Controls.Add(this.btnCari);
            this.Panel3.Controls.Add(this.cari_txt);
            this.Panel3.Location = new System.Drawing.Point(12, 247);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1240, 403);
            this.Panel3.TabIndex = 26;
            // 
            // pendaftaran_dgv
            // 
            this.pendaftaran_dgv.AllowUserToAddRows = false;
            this.pendaftaran_dgv.AllowUserToDeleteRows = false;
            this.pendaftaran_dgv.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pendaftaran_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pendaftaran_dgv.Location = new System.Drawing.Point(26, 41);
            this.pendaftaran_dgv.Name = "pendaftaran_dgv";
            this.pendaftaran_dgv.ReadOnly = true;
            this.pendaftaran_dgv.RowHeadersWidth = 62;
            this.pendaftaran_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pendaftaran_dgv.Size = new System.Drawing.Size(1209, 336);
            this.pendaftaran_dgv.TabIndex = 9;
            this.pendaftaran_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pendaftaran_dgv_CellClick);
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.btnCari.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCari.Location = new System.Drawing.Point(1110, 6);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(117, 29);
            this.btnCari.TabIndex = 8;
            this.btnCari.Text = "CARI";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // cari_txt
            // 
            this.cari_txt.Location = new System.Drawing.Point(775, 6);
            this.cari_txt.Multiline = true;
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(329, 29);
            this.cari_txt.TabIndex = 3;
            this.cari_txt.TextChanged += new System.EventHandler(this.cari_txt_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.btnClear.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(1110, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 76);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormPendaftaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Homelb);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Panel3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormPendaftaran";
            this.Text = "FormPendaftaran";
            this.Load += new System.EventHandler(this.FormPendaftaran_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pendaftaran_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.LinkLabel Homelb;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.ComboBox cbDokter;
        internal System.Windows.Forms.ComboBox cbPasien1;
        internal System.Windows.Forms.ComboBox cbStatus;
        internal System.Windows.Forms.DateTimePicker dtTanggal;
        internal System.Windows.Forms.TextBox tKeluhan;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button btnHapus;
        internal System.Windows.Forms.Button btnPerbarui;
        internal System.Windows.Forms.Button btnTambah;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.DataGridView pendaftaran_dgv;
        internal System.Windows.Forms.Button btnCari;
        internal System.Windows.Forms.TextBox cari_txt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        internal System.Windows.Forms.Button btnClear;
    }
}