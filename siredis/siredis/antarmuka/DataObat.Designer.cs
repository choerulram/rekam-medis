namespace siredis.antarmuka
{
    partial class DataObat
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
            this.Panel3 = new System.Windows.Forms.Panel();
            this.obat_dgv = new System.Windows.Forms.DataGridView();
            this.btnCari = new System.Windows.Forms.Button();
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tNama = new System.Windows.Forms.TextBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.tIdObat = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Label6 = new System.Windows.Forms.Label();
            this.Homelb = new System.Windows.Forms.LinkLabel();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obat_dgv)).BeginInit();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel3
            // 
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.obat_dgv);
            this.Panel3.Location = new System.Drawing.Point(-36, 284);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1311, 320);
            this.Panel3.TabIndex = 32;
            // 
            // obat_dgv
            // 
            this.obat_dgv.AllowUserToAddRows = false;
            this.obat_dgv.AllowUserToDeleteRows = false;
            this.obat_dgv.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.obat_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.obat_dgv.Location = new System.Drawing.Point(44, 17);
            this.obat_dgv.Name = "obat_dgv";
            this.obat_dgv.ReadOnly = true;
            this.obat_dgv.RowHeadersWidth = 62;
            this.obat_dgv.Size = new System.Drawing.Size(1265, 289);
            this.obat_dgv.TabIndex = 9;
            this.obat_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.obat_dgv_CellClick);
            this.obat_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.obat_dgv_CellContentClick);
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.btnCari.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.btnCari.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCari.Location = new System.Drawing.Point(875, 90);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(117, 29);
            this.btnCari.TabIndex = 8;
            this.btnCari.Text = "CARI";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // cari_txt
            // 
            this.cari_txt.Location = new System.Drawing.Point(680, 91);
            this.cari_txt.Multiline = true;
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(189, 25);
            this.cari_txt.TabIndex = 3;
            this.cari_txt.TextChanged += new System.EventHandler(this.cari_txt_TextChanged);
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.label2);
            this.Panel2.Controls.Add(this.tNama);
            this.Panel2.Controls.Add(this.btnHapus);
            this.Panel2.Controls.Add(this.btnCari);
            this.Panel2.Controls.Add(this.btnEdit);
            this.Panel2.Controls.Add(this.cari_txt);
            this.Panel2.Controls.Add(this.btnTambah);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Controls.Add(this.tIdObat);
            this.Panel2.Location = new System.Drawing.Point(9, 150);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1266, 134);
            this.Panel2.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nama :";
            // 
            // tNama
            // 
            this.tNama.Location = new System.Drawing.Point(20, 96);
            this.tNama.Name = "tNama";
            this.tNama.Size = new System.Drawing.Size(488, 20);
            this.tNama.TabIndex = 9;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Crimson;
            this.btnHapus.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.btnHapus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHapus.Location = new System.Drawing.Point(900, 41);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(92, 33);
            this.btnHapus.TabIndex = 7;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(54)))));
            this.btnEdit.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(789, 41);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 33);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.btnTambah.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.btnTambah.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTambah.Location = new System.Drawing.Point(680, 41);
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
            this.Label3.Location = new System.Drawing.Point(17, 23);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(71, 17);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Id Obat :";
            // 
            // tIdObat
            // 
            this.tIdObat.Location = new System.Drawing.Point(20, 42);
            this.tIdObat.Name = "tIdObat";
            this.tIdObat.Size = new System.Drawing.Size(488, 20);
            this.tIdObat.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Bookman Old Style", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Snow;
            this.Label1.Location = new System.Drawing.Point(334, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(721, 63);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "APLIKASI REKAM MEDIS";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(224)))));
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(-1, 1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1294, 95);
            this.Panel1.TabIndex = 30;
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(90, 17);
            this.ToolStripStatusLabel1.Text = "Total row data : ";
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Location = new System.Drawing.Point(-36, 66);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(35, 13);
            this.LinkLabel1.TabIndex = 34;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "Home";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 660);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(1283, 22);
            this.StatusStrip1.TabIndex = 33;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(42, 116);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(65, 13);
            this.Label6.TabIndex = 36;
            this.Label6.Text = "> Data Obat";
            // 
            // Homelb
            // 
            this.Homelb.AutoSize = true;
            this.Homelb.Location = new System.Drawing.Point(9, 116);
            this.Homelb.Name = "Homelb";
            this.Homelb.Size = new System.Drawing.Size(35, 13);
            this.Homelb.TabIndex = 35;
            this.Homelb.TabStop = true;
            this.Homelb.Text = "Home";
            this.Homelb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Homelb_LinkClicked);
            // 
            // DataObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 682);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Homelb);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.LinkLabel1);
            this.Controls.Add(this.StatusStrip1);
            this.Name = "DataObat";
            this.Text = "DataObat";
            this.Load += new System.EventHandler(this.DataObat_Load);
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.obat_dgv)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.DataGridView obat_dgv;
        internal System.Windows.Forms.Button btnCari;
        internal System.Windows.Forms.TextBox cari_txt;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button btnHapus;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnTambah;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox tIdObat;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.LinkLabel LinkLabel1;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.LinkLabel Homelb;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox tNama;
    }
}