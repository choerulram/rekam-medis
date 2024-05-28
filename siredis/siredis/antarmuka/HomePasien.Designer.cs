namespace siredis.antarmuka
{
    partial class HomePasien
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
            this.PengambilanObatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_logout = new System.Windows.Forms.Button();
            this.user_lbl = new System.Windows.Forms.Label();
            this.lHello = new System.Windows.Forms.Label();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeMenu,
            this.TransaksiToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(866, 28);
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
            this.PengambilanObatMenu});
            this.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem";
            this.TransaksiToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.TransaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // PendaftaranMenu
            // 
            this.PendaftaranMenu.Name = "PendaftaranMenu";
            this.PendaftaranMenu.Size = new System.Drawing.Size(215, 26);
            this.PendaftaranMenu.Text = "Pendaftaran";
            this.PendaftaranMenu.Click += new System.EventHandler(this.PendaftaranMenu_Click);
            // 
            // PengambilanObatMenu
            // 
            this.PengambilanObatMenu.Name = "PengambilanObatMenu";
            this.PengambilanObatMenu.Size = new System.Drawing.Size(215, 26);
            this.PengambilanObatMenu.Text = "Pengambilan Obat";
            this.PengambilanObatMenu.Click += new System.EventHandler(this.PengambilanObatMenu_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(744, 46);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(109, 34);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.Text = "LOGOUT";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // user_lbl
            // 
            this.user_lbl.AutoSize = true;
            this.user_lbl.Font = new System.Drawing.Font("Bookman Old Style", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_lbl.ForeColor = System.Drawing.Color.Olive;
            this.user_lbl.Location = new System.Drawing.Point(458, 146);
            this.user_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_lbl.Name = "user_lbl";
            this.user_lbl.Size = new System.Drawing.Size(212, 78);
            this.user_lbl.TabIndex = 11;
            this.user_lbl.Text = "User!";
            // 
            // lHello
            // 
            this.lHello.AutoSize = true;
            this.lHello.Font = new System.Drawing.Font("Bookman Old Style", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHello.ForeColor = System.Drawing.Color.Olive;
            this.lHello.Location = new System.Drawing.Point(212, 146);
            this.lHello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHello.Name = "lHello";
            this.lHello.Size = new System.Drawing.Size(238, 78);
            this.lHello.TabIndex = 10;
            this.lHello.Text = "Hello,";
            // 
            // HomePasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.user_lbl);
            this.Controls.Add(this.lHello);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.btn_logout);
            this.Name = "HomePasien";
            this.Text = "HomePasien";
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
        internal System.Windows.Forms.ToolStripMenuItem PengambilanObatMenu;
        internal System.Windows.Forms.Button btn_logout;
        internal System.Windows.Forms.Label user_lbl;
        internal System.Windows.Forms.Label lHello;
    }
}