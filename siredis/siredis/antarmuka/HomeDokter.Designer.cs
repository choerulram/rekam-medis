namespace siredis.antarmuka
{
    partial class HomeDokter
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
            this.btn_logout = new System.Windows.Forms.Button();
            this.user_lbl = new System.Windows.Forms.Label();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HomeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PemeriksaanMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SelesaiMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lHello = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_logout.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(237, 372);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(82, 28);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.Text = "LOGOUT";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // user_lbl
            // 
            this.user_lbl.AutoSize = true;
            this.user_lbl.BackColor = System.Drawing.Color.White;
            this.user_lbl.Font = new System.Drawing.Font("Bookman Old Style", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_lbl.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.user_lbl.Location = new System.Drawing.Point(602, 202);
            this.user_lbl.Name = "user_lbl";
            this.user_lbl.Size = new System.Drawing.Size(212, 78);
            this.user_lbl.TabIndex = 11;
            this.user_lbl.Text = "User!";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeMenu,
            this.TransaksiToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuStrip1.Size = new System.Drawing.Size(1283, 24);
            this.MenuStrip1.TabIndex = 12;
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
            this.PemeriksaanMenu,
            this.SelesaiMenu});
            this.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem";
            this.TransaksiToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.TransaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // PemeriksaanMenu
            // 
            this.PemeriksaanMenu.Name = "PemeriksaanMenu";
            this.PemeriksaanMenu.Size = new System.Drawing.Size(180, 22);
            this.PemeriksaanMenu.Text = "Pemeriksaan";
            this.PemeriksaanMenu.Click += new System.EventHandler(this.PemeriksaanMenu_Click);
            // 
            // SelesaiMenu
            // 
            this.SelesaiMenu.Name = "SelesaiMenu";
            this.SelesaiMenu.Size = new System.Drawing.Size(180, 22);
            this.SelesaiMenu.Text = "Selesai";
            this.SelesaiMenu.Click += new System.EventHandler(this.SelesaiMenu_Click);
            // 
            // lHello
            // 
            this.lHello.AutoSize = true;
            this.lHello.BackColor = System.Drawing.Color.White;
            this.lHello.Font = new System.Drawing.Font("Bookman Old Style", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHello.ForeColor = System.Drawing.Color.Navy;
            this.lHello.Location = new System.Drawing.Point(238, 202);
            this.lHello.Name = "lHello";
            this.lHello.Size = new System.Drawing.Size(367, 78);
            this.lHello.TabIndex = 13;
            this.lHello.Text = "Welcome,";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::siredis.Properties.Resources.a;
            this.pictureBox1.Location = new System.Drawing.Point(-44, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1327, 661);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Solusi Canggih Untuk Manajemen Rumah sakit ";
            // 
            // HomeDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 660);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.user_lbl);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lHello);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeDokter";
            this.Text = "HomeDokter";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btn_logout;
        internal System.Windows.Forms.Label user_lbl;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem HomeMenu;
        internal System.Windows.Forms.ToolStripMenuItem TransaksiToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PemeriksaanMenu;
        internal System.Windows.Forms.ToolStripMenuItem SelesaiMenu;
        internal System.Windows.Forms.Label lHello;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}