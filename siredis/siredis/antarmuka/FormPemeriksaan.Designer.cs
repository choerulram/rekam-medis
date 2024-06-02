namespace siredis.antarmuka
{
    partial class FormPemeriksaan
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
            this.pemeriksaan_dgv = new System.Windows.Forms.DataGridView();
            this.btnCari = new System.Windows.Forms.Button();
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.btnResep = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.ldokter = new System.Windows.Forms.Label();
            this.lpasien = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnPeriksa = new System.Windows.Forms.Button();
            this.btnPerbarui = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Homelb = new System.Windows.Forms.LinkLabel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pemeriksaan_dgv)).BeginInit();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel3
            // 
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.pemeriksaan_dgv);
            this.Panel3.Location = new System.Drawing.Point(12, 318);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1240, 332);
            this.Panel3.TabIndex = 32;
            // 
            // pemeriksaan_dgv
            // 
            this.pemeriksaan_dgv.AllowUserToAddRows = false;
            this.pemeriksaan_dgv.AllowUserToDeleteRows = false;
            this.pemeriksaan_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pemeriksaan_dgv.Location = new System.Drawing.Point(14, -1);
            this.pemeriksaan_dgv.MultiSelect = false;
            this.pemeriksaan_dgv.Name = "pemeriksaan_dgv";
            this.pemeriksaan_dgv.ReadOnly = true;
            this.pemeriksaan_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.pemeriksaan_dgv.Size = new System.Drawing.Size(1209, 387);
            this.pemeriksaan_dgv.TabIndex = 9;
            this.pemeriksaan_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pemeriksaan_dgv_CellClick);
            this.pemeriksaan_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pemeriksaan_dgv_CellContentClick);
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCari.Location = new System.Drawing.Point(219, 73);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(74, 32);
            this.btnCari.TabIndex = 8;
            this.btnCari.Text = "CARI";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // cari_txt
            // 
            this.cari_txt.Location = new System.Drawing.Point(325, 80);
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(134, 20);
            this.cari_txt.TabIndex = 3;
            this.cari_txt.TextChanged += new System.EventHandler(this.cari_txt_TextChanged);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(53, 112);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(96, 13);
            this.Label6.TabIndex = 35;
            this.Label6.Text = "> List Pemeriksaan";
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.btnResep);
            this.Panel2.Controls.Add(this.btnCari);
            this.Panel2.Controls.Add(this.btnRefresh);
            this.Panel2.Controls.Add(this.cari_txt);
            this.Panel2.Controls.Add(this.ldokter);
            this.Panel2.Controls.Add(this.lpasien);
            this.Panel2.Controls.Add(this.cbStatus);
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Controls.Add(this.btnPeriksa);
            this.Panel2.Controls.Add(this.btnPerbarui);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Location = new System.Drawing.Point(12, 142);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1240, 132);
            this.Panel2.TabIndex = 31;
            // 
            // btnResep
            // 
            this.btnResep.BackColor = System.Drawing.Color.Gold;
            this.btnResep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnResep.Location = new System.Drawing.Point(669, 75);
            this.btnResep.Name = "btnResep";
            this.btnResep.Size = new System.Drawing.Size(83, 39);
            this.btnResep.TabIndex = 36;
            this.btnResep.Text = "LIHAT RESEP";
            this.btnResep.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Green;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(544, 75);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 39);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // ldokter
            // 
            this.ldokter.AutoSize = true;
            this.ldokter.Location = new System.Drawing.Point(12, 92);
            this.ldokter.Name = "ldokter";
            this.ldokter.Size = new System.Drawing.Size(66, 13);
            this.ldokter.TabIndex = 20;
            this.ldokter.Text = "nama dokter";
            // 
            // lpasien
            // 
            this.lpasien.AutoSize = true;
            this.lpasien.Location = new System.Drawing.Point(11, 31);
            this.lpasien.Name = "lpasien";
            this.lpasien.Size = new System.Drawing.Size(64, 13);
            this.lpasien.TabIndex = 19;
            this.lpasien.Text = "namapasien";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "pemeriksaan",
            "selesai"});
            this.cbStatus.Location = new System.Drawing.Point(325, 12);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(134, 21);
            this.cbStatus.TabIndex = 18;
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
            // btnPeriksa
            // 
            this.btnPeriksa.BackColor = System.Drawing.Color.Crimson;
            this.btnPeriksa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriksa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPeriksa.Location = new System.Drawing.Point(669, 12);
            this.btnPeriksa.Name = "btnPeriksa";
            this.btnPeriksa.Size = new System.Drawing.Size(83, 38);
            this.btnPeriksa.TabIndex = 7;
            this.btnPeriksa.Text = "PERIKSA";
            this.btnPeriksa.UseVisualStyleBackColor = false;
            this.btnPeriksa.Click += new System.EventHandler(this.btnPeriksa_Click);
            // 
            // btnPerbarui
            // 
            this.btnPerbarui.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPerbarui.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerbarui.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPerbarui.Location = new System.Drawing.Point(544, 12);
            this.btnPerbarui.Name = "btnPerbarui";
            this.btnPerbarui.Size = new System.Drawing.Size(82, 38);
            this.btnPerbarui.TabIndex = 6;
            this.btnPerbarui.Text = "PERBARUI";
            this.btnPerbarui.UseVisualStyleBackColor = false;
            this.btnPerbarui.Click += new System.EventHandler(this.btnPerbarui_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(216, 16);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(64, 17);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "Status :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(12, 66);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(66, 17);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Dokter :";
            // 
            // Homelb
            // 
            this.Homelb.AutoSize = true;
            this.Homelb.Location = new System.Drawing.Point(12, 112);
            this.Homelb.Name = "Homelb";
            this.Homelb.Size = new System.Drawing.Size(35, 13);
            this.Homelb.TabIndex = 34;
            this.Homelb.TabStop = true;
            this.Homelb.Text = "Home";
            this.Homelb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Homelb_LinkClicked);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(-1, -1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1266, 95);
            this.Panel1.TabIndex = 30;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Bookman Old Style", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Yellow;
            this.Label1.Location = new System.Drawing.Point(267, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(721, 63);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "APLIKASI REKAM MEDIS";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 659);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.StatusStrip1.TabIndex = 33;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(90, 17);
            this.ToolStripStatusLabel1.Text = "Total row data : ";
            // 
            // FormPemeriksaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Homelb);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.StatusStrip1);
            this.Name = "FormPemeriksaan";
            this.Text = "FormPemeriksaan";
            this.Load += new System.EventHandler(this.FormPemeriksaan_Load);
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pemeriksaan_dgv)).EndInit();
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
        internal System.Windows.Forms.DataGridView pemeriksaan_dgv;
        internal System.Windows.Forms.Button btnCari;
        internal System.Windows.Forms.TextBox cari_txt;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Label ldokter;
        internal System.Windows.Forms.Label lpasien;
        internal System.Windows.Forms.ComboBox cbStatus;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnPeriksa;
        internal System.Windows.Forms.Button btnPerbarui;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.LinkLabel Homelb;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.Button btnResep;
    }
}