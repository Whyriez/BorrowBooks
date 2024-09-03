namespace BorrowBooks1
{
    partial class FormHomeOperator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomeOperator));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnKeluar = new FontAwesome.Sharp.IconButton();
            this.btnRiwayat = new FontAwesome.Sharp.IconButton();
            this.btnPengembalian = new FontAwesome.Sharp.IconButton();
            this.btnPinjam = new FontAwesome.Sharp.IconButton();
            this.btnBuku = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.iconCurrentHome = new FontAwesome.Sharp.IconPictureBox();
            this.labelTitleCurrentHome = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.panelMenu.Controls.Add(this.btnKeluar);
            this.panelMenu.Controls.Add(this.btnRiwayat);
            this.panelMenu.Controls.Add(this.btnPengembalian);
            this.panelMenu.Controls.Add(this.btnPinjam);
            this.panelMenu.Controls.Add(this.btnBuku);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(305, 735);
            this.panelMenu.TabIndex = 0;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKeluar.FlatAppearance.BorderSize = 0;
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKeluar.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnKeluar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnKeluar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKeluar.IconSize = 45;
            this.btnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeluar.Location = new System.Drawing.Point(0, 359);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(305, 60);
            this.btnKeluar.TabIndex = 5;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKeluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRiwayat.FlatAppearance.BorderSize = 0;
            this.btnRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiwayat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRiwayat.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnRiwayat.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRiwayat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRiwayat.IconSize = 45;
            this.btnRiwayat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRiwayat.Location = new System.Drawing.Point(0, 299);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.Size = new System.Drawing.Size(305, 60);
            this.btnRiwayat.TabIndex = 4;
            this.btnRiwayat.Text = "Riwayat Pengembalian";
            this.btnRiwayat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRiwayat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRiwayat.UseVisualStyleBackColor = true;
            this.btnRiwayat.Click += new System.EventHandler(this.btnRiwayat_Click);
            // 
            // btnPengembalian
            // 
            this.btnPengembalian.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPengembalian.FlatAppearance.BorderSize = 0;
            this.btnPengembalian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPengembalian.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPengembalian.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.btnPengembalian.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPengembalian.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPengembalian.IconSize = 45;
            this.btnPengembalian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPengembalian.Location = new System.Drawing.Point(0, 239);
            this.btnPengembalian.Name = "btnPengembalian";
            this.btnPengembalian.Size = new System.Drawing.Size(305, 60);
            this.btnPengembalian.TabIndex = 3;
            this.btnPengembalian.Text = "Pengembalian Buku";
            this.btnPengembalian.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPengembalian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPengembalian.UseVisualStyleBackColor = true;
            this.btnPengembalian.Click += new System.EventHandler(this.btnPengembalian_Click);
            // 
            // btnPinjam
            // 
            this.btnPinjam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPinjam.FlatAppearance.BorderSize = 0;
            this.btnPinjam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPinjam.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPinjam.IconChar = FontAwesome.Sharp.IconChar.HandHolding;
            this.btnPinjam.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPinjam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPinjam.IconSize = 45;
            this.btnPinjam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPinjam.Location = new System.Drawing.Point(0, 179);
            this.btnPinjam.Name = "btnPinjam";
            this.btnPinjam.Size = new System.Drawing.Size(305, 60);
            this.btnPinjam.TabIndex = 2;
            this.btnPinjam.Text = "Pinjam Buku";
            this.btnPinjam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPinjam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPinjam.UseVisualStyleBackColor = true;
            this.btnPinjam.Click += new System.EventHandler(this.btnPinjam_Click);
            // 
            // btnBuku
            // 
            this.btnBuku.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuku.FlatAppearance.BorderSize = 0;
            this.btnBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuku.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuku.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnBuku.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBuku.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuku.IconSize = 45;
            this.btnBuku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuku.Location = new System.Drawing.Point(0, 119);
            this.btnBuku.Name = "btnBuku";
            this.btnBuku.Size = new System.Drawing.Size(305, 60);
            this.btnBuku.TabIndex = 1;
            this.btnBuku.Text = "Data Buku";
            this.btnBuku.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuku.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuku.UseVisualStyleBackColor = true;
            this.btnBuku.Click += new System.EventHandler(this.btnBuku_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(305, 119);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.labelName);
            this.panelTitleBar.Controls.Add(this.pictureBox2);
            this.panelTitleBar.Controls.Add(this.iconCurrentHome);
            this.panelTitleBar.Controls.Add(this.labelTitleCurrentHome);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(305, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(906, 100);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.Location = new System.Drawing.Point(789, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 21);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.Location = new System.Drawing.Point(824, 8);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(29, 21);
            this.btnMaximize.TabIndex = 5;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.Location = new System.Drawing.Point(859, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 22);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelName.Location = new System.Drawing.Point(697, 52);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(124, 21);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Selamat Datang";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(627, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // iconCurrentHome
            // 
            this.iconCurrentHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.iconCurrentHome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.iconCurrentHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentHome.IconColor = System.Drawing.SystemColors.Highlight;
            this.iconCurrentHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentHome.IconSize = 40;
            this.iconCurrentHome.Location = new System.Drawing.Point(16, 40);
            this.iconCurrentHome.Name = "iconCurrentHome";
            this.iconCurrentHome.Size = new System.Drawing.Size(40, 40);
            this.iconCurrentHome.TabIndex = 1;
            this.iconCurrentHome.TabStop = false;
            // 
            // labelTitleCurrentHome
            // 
            this.labelTitleCurrentHome.AutoSize = true;
            this.labelTitleCurrentHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleCurrentHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleCurrentHome.Location = new System.Drawing.Point(62, 52);
            this.labelTitleCurrentHome.Name = "labelTitleCurrentHome";
            this.labelTitleCurrentHome.Size = new System.Drawing.Size(49, 18);
            this.labelTitleCurrentHome.TabIndex = 0;
            this.labelTitleCurrentHome.Text = "Home";
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(305, 100);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(906, 6);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(68)))), ((int)(((byte)(105)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(305, 106);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(906, 629);
            this.panelDesktop.TabIndex = 3;
            // 
            // FormHomeOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 735);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormHomeOperator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHomeOperator";
            this.Load += new System.EventHandler(this.FormHomeOperator_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnBuku;
        private FontAwesome.Sharp.IconButton btnKeluar;
        private FontAwesome.Sharp.IconButton btnRiwayat;
        private FontAwesome.Sharp.IconButton btnPengembalian;
        private FontAwesome.Sharp.IconButton btnPinjam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconCurrentHome;
        private System.Windows.Forms.Label labelTitleCurrentHome;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
    }
}