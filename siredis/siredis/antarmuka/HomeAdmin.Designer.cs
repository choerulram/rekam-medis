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
            this.PemeriksaanMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PengambilanObatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SelesaiMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DokterMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PasienMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ObatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lHello = new System.Windows.Forms.Label();
            this.MenuStrip1.SuspendLayout();
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
            this.MenuStrip1.Size = new System.Drawing.Size(871, 28);
            this.MenuStrip1.TabIndex = 6;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // HomeMenu
            // 
            this.HomeMenu.Name = "HomeMenu";
            this.HomeMenu.Size = new System.Drawing.Size(64, 24);
            this.HomeMenu.Text = "Home";
            // 
            // TransaksiToolStripMenuItem
            // 
            this.TransaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PendaftaranMenu,
            this.PemeriksaanMenu,
            this.PengambilanObatMenu,
            this.SelesaiMenu});
            this.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem";
            this.TransaksiToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.TransaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // PendaftaranMenu
            // 
            this.PendaftaranMenu.Name = "PendaftaranMenu";
            this.PendaftaranMenu.Size = new System.Drawing.Size(224, 26);
            this.PendaftaranMenu.Text = "Pendaftaran";
            this.PendaftaranMenu.Click += new System.EventHandler(this.PendaftaranMenu_Click);
            // 
            // PemeriksaanMenu
            // 
            this.PemeriksaanMenu.Name = "PemeriksaanMenu";
            this.PemeriksaanMenu.Size = new System.Drawing.Size(224, 26);
            this.PemeriksaanMenu.Text = "Pemeriksaan";
            this.PemeriksaanMenu.Click += new System.EventHandler(this.PemeriksaanMenu_Click);
            // 
            // PengambilanObatMenu
            // 
            this.PengambilanObatMenu.Name = "PengambilanObatMenu";
            this.PengambilanObatMenu.Size = new System.Drawing.Size(224, 26);
            this.PengambilanObatMenu.Text = "Pengambilan Obat";
            this.PengambilanObatMenu.Click += new System.EventHandler(this.PengambilanObatMenu_Click);
            // 
            // SelesaiMenu
            // 
            this.SelesaiMenu.Name = "SelesaiMenu";
            this.SelesaiMenu.Size = new System.Drawing.Size(224, 26);
            this.SelesaiMenu.Text = "Selesai";
            this.SelesaiMenu.Click += new System.EventHandler(this.SelesaiMenu_Click);
            // 
            // DataToolStripMenuItem
            // 
            this.DataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdminMenu,
            this.DokterMenu,
            this.PasienMenu,
            this.ObatMenu});
            this.DataToolStripMenuItem.Name = "DataToolStripMenuItem";
            this.DataToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.DataToolStripMenuItem.Text = "Data";
            // 
            // AdminMenu
            // 
            this.AdminMenu.Name = "AdminMenu";
            this.AdminMenu.Size = new System.Drawing.Size(224, 26);
            this.AdminMenu.Text = "Admin";
            this.AdminMenu.Click += new System.EventHandler(this.AdminMenu_Click);
            // 
            // DokterMenu
            // 
            this.DokterMenu.Name = "DokterMenu";
            this.DokterMenu.Size = new System.Drawing.Size(224, 26);
            this.DokterMenu.Text = "Dokter";
            this.DokterMenu.Click += new System.EventHandler(this.DokterMenu_Click);
            // 
            // PasienMenu
            // 
            this.PasienMenu.Name = "PasienMenu";
            this.PasienMenu.Size = new System.Drawing.Size(224, 26);
            this.PasienMenu.Text = "Pasien";
            this.PasienMenu.Click += new System.EventHandler(this.PasienMenu_Click);
            // 
            // ObatMenu
            // 
            this.ObatMenu.Name = "ObatMenu";
            this.ObatMenu.Size = new System.Drawing.Size(224, 26);
            this.ObatMenu.Text = "Obat";
            this.ObatMenu.Click += new System.EventHandler(this.ObatMenu_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(739, 43);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(109, 34);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.Text = "LOGOUT";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lHello
            // 
            this.lHello.AutoSize = true;
            this.lHello.Font = new System.Drawing.Font("Bookman Old Style", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHello.ForeColor = System.Drawing.Color.Yellow;
            this.lHello.Location = new System.Drawing.Point(146, 239);
            this.lHello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHello.Name = "lHello";
            this.lHello.Size = new System.Drawing.Size(440, 78);
            this.lHello.TabIndex = 7;
            this.lHello.Text = "Hello, User!";
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lHello);
            this.Name = "HomeAdmin";
            this.Text = "HomeAdmin";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem HomeMenu;
        internal System.Windows.Forms.ToolStripMenuItem TransaksiToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PendaftaranMenu;
        internal System.Windows.Forms.ToolStripMenuItem PemeriksaanMenu;
        internal System.Windows.Forms.ToolStripMenuItem PengambilanObatMenu;
        internal System.Windows.Forms.ToolStripMenuItem SelesaiMenu;
        internal System.Windows.Forms.ToolStripMenuItem DataToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AdminMenu;
        internal System.Windows.Forms.ToolStripMenuItem DokterMenu;
        internal System.Windows.Forms.ToolStripMenuItem PasienMenu;
        internal System.Windows.Forms.ToolStripMenuItem ObatMenu;
        internal System.Windows.Forms.Button btn_logout;
        internal System.Windows.Forms.Label lHello;
    }
}