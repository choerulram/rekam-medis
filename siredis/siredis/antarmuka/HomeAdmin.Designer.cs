namespace siredis.antarmuka
{
    partial class HomeAdmin
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HomeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PendaftaranMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DokterMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PasienMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ObatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lHello = new System.Windows.Forms.Label();
            this.user_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeMenu,
            this.TransaksiToolStripMenuItem,
            this.DataToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuStrip1.Size = new System.Drawing.Size(1283, 24);
            this.MenuStrip1.TabIndex = 6;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // HomeMenu
            // 
            this.HomeMenu.Name = "HomeMenu";
            this.HomeMenu.Size = new System.Drawing.Size(52, 20);
            this.HomeMenu.Text = "Home";
            // 
            // TransaksiToolStripMenuItem
            // 
            this.TransaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PendaftaranMenu});
            this.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem";
            this.TransaksiToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.TransaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // PendaftaranMenu
            // 
            this.PendaftaranMenu.Name = "PendaftaranMenu";
            this.PendaftaranMenu.Size = new System.Drawing.Size(180, 22);
            this.PendaftaranMenu.Text = "Pendaftaran";
            this.PendaftaranMenu.Click += new System.EventHandler(this.PendaftaranMenu_Click);
            // 
            // DataToolStripMenuItem
            // 
            this.DataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DokterMenu,
            this.PasienMenu,
            this.ObatMenu});
            this.DataToolStripMenuItem.Name = "DataToolStripMenuItem";
            this.DataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.DataToolStripMenuItem.Text = "Data";
            // 
            // DokterMenu
            // 
            this.DokterMenu.Name = "DokterMenu";
            this.DokterMenu.Size = new System.Drawing.Size(109, 22);
            this.DokterMenu.Text = "Dokter";
            this.DokterMenu.Click += new System.EventHandler(this.DokterMenu_Click);
            // 
            // PasienMenu
            // 
            this.PasienMenu.Name = "PasienMenu";
            this.PasienMenu.Size = new System.Drawing.Size(109, 22);
            this.PasienMenu.Text = "Pasien";
            this.PasienMenu.Click += new System.EventHandler(this.PasienMenu_Click);
            // 
            // ObatMenu
            // 
            this.ObatMenu.Name = "ObatMenu";
            this.ObatMenu.Size = new System.Drawing.Size(109, 22);
            this.ObatMenu.Text = "Obat";
            this.ObatMenu.Click += new System.EventHandler(this.ObatMenu_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_logout.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(317, 366);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(89, 28);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.Text = "LOGOUT";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lHello
            // 
            this.lHello.AutoSize = true;
            this.lHello.BackColor = System.Drawing.Color.White;
            this.lHello.Font = new System.Drawing.Font("Bookman Old Style", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHello.ForeColor = System.Drawing.Color.Navy;
            this.lHello.Location = new System.Drawing.Point(313, 201);
            this.lHello.Name = "lHello";
            this.lHello.Size = new System.Drawing.Size(367, 78);
            this.lHello.TabIndex = 7;
            this.lHello.Text = "Welcome,";
            // 
            // user_lbl
            // 
            this.user_lbl.AutoSize = true;
            this.user_lbl.BackColor = System.Drawing.Color.White;
            this.user_lbl.Font = new System.Drawing.Font("Bookman Old Style", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_lbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.user_lbl.Location = new System.Drawing.Point(671, 201);
            this.user_lbl.Name = "user_lbl";
            this.user_lbl.Size = new System.Drawing.Size(212, 78);
            this.user_lbl.TabIndex = 9;
            this.user_lbl.Text = "User!";
            this.user_lbl.Click += new System.EventHandler(this.user_lbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Solusi Canggih Untuk Manajemen Rumah sakit ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::siredis.Properties.Resources.a;
            this.pictureBox1.Location = new System.Drawing.Point(-9, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1300, 683);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 682);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_lbl);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lHello);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeAdmin";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.HomeAdmin_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem HomeMenu;
        internal System.Windows.Forms.ToolStripMenuItem TransaksiToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PendaftaranMenu;
        internal System.Windows.Forms.ToolStripMenuItem DataToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DokterMenu;
        internal System.Windows.Forms.ToolStripMenuItem PasienMenu;
        internal System.Windows.Forms.ToolStripMenuItem ObatMenu;
        internal System.Windows.Forms.Button btn_logout;
        internal System.Windows.Forms.Label lHello;
        internal System.Windows.Forms.Label user_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}