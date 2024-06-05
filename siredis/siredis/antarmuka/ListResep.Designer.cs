namespace siredis.antarmuka
{
    partial class ListResep
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
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.lpasien = new System.Windows.Forms.Label();
            this.ListBox2 = new System.Windows.Forms.ListBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.tDiagnosa = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.tKeluhan = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(-42, -3);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersWidth = 62;
            this.DataGridView1.Size = new System.Drawing.Size(1837, 829);
            this.DataGridView1.TabIndex = 10;
            // 
            // lpasien
            // 
            this.lpasien.AutoSize = true;
            this.lpasien.Location = new System.Drawing.Point(52, 138);
            this.lpasien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lpasien.Name = "lpasien";
            this.lpasien.Size = new System.Drawing.Size(96, 20);
            this.lpasien.TabIndex = 44;
            this.lpasien.Text = "namapasien";
            // 
            // ListBox2
            // 
            this.ListBox2.FormattingEnabled = true;
            this.ListBox2.ItemHeight = 20;
            this.ListBox2.Location = new System.Drawing.Point(791, 274);
            this.ListBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListBox2.Name = "ListBox2";
            this.ListBox2.Size = new System.Drawing.Size(541, 264);
            this.ListBox2.TabIndex = 43;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(786, 213);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(139, 25);
            this.Label3.TabIndex = 42;
            this.Label3.Text = "Resep Obat :";
            // 
            // tDiagnosa
            // 
            this.tDiagnosa.Location = new System.Drawing.Point(56, 487);
            this.tDiagnosa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tDiagnosa.Multiline = true;
            this.tDiagnosa.Name = "tDiagnosa";
            this.tDiagnosa.Size = new System.Drawing.Size(541, 101);
            this.tDiagnosa.TabIndex = 41;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(51, 415);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(116, 25);
            this.Label2.TabIndex = 40;
            this.Label2.Text = "Diagnosa :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(51, 85);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(81, 25);
            this.Label1.TabIndex = 39;
            this.Label1.Text = "Nama :";
            // 
            // tKeluhan
            // 
            this.tKeluhan.Location = new System.Drawing.Point(56, 274);
            this.tKeluhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tKeluhan.Multiline = true;
            this.tKeluhan.Name = "tKeluhan";
            this.tKeluhan.Size = new System.Drawing.Size(541, 101);
            this.tKeluhan.TabIndex = 38;
            this.tKeluhan.TextChanged += new System.EventHandler(this.tKeluhan_TextChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(51, 213);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(105, 25);
            this.Label8.TabIndex = 37;
            this.Label8.Text = "Keluhan :";
            // 
            // ListResep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1714, 824);
            this.Controls.Add(this.lpasien);
            this.Controls.Add(this.ListBox2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.tDiagnosa);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.tKeluhan);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.DataGridView1);
            this.Name = "ListResep";
            this.Text = "ListResep";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Label lpasien;
        internal System.Windows.Forms.ListBox ListBox2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox tDiagnosa;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox tKeluhan;
        internal System.Windows.Forms.Label Label8;
    }
}