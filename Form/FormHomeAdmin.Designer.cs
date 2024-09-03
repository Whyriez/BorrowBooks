namespace BorrowBooks1
{
    partial class FormHomeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomeAdmin));
            this.btnKeluar = new FontAwesome.Sharp.IconButton();
            this.btnMahasiswa = new FontAwesome.Sharp.IconButton();
            this.btnUser = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentHome)).BeginInit();
            this.SuspendLayout();
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
            this.btnKeluar.Location = new System.Drawing.Point(0, 239);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(254, 60);
            this.btnKeluar.TabIndex = 5;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKeluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnMahasiswa
            // 
            this.btnMahasiswa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMahasiswa.FlatAppearance.BorderSize = 0;
            this.btnMahasiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMahasiswa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMahasiswa.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnMahasiswa.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMahasiswa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMahasiswa.IconSize = 45;
            this.btnMahasiswa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMahasiswa.Location = new System.Drawing.Point(0, 179);
            this.btnMahasiswa.Name = "btnMahasiswa";
            this.btnMahasiswa.Size = new System.Drawing.Size(254, 60);
            this.btnMahasiswa.TabIndex = 2;
            this.btnMahasiswa.Text = "Data Mahasiswa";
            this.btnMahasiswa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMahasiswa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMahasiswa.UseVisualStyleBackColor = true;
            this.btnMahasiswa.Click += new System.EventHandler(this.btnMahasiswa_Click);
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnUser.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUser.IconSize = 45;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 119);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(254, 60);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "Data User";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(254, 119);
            this.panelLogo.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.panelMenu.Controls.Add(this.btnKeluar);
            this.panelMenu.Controls.Add(this.btnMahasiswa);
            this.panelMenu.Controls.Add(this.btnUser);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(254, 735);
            this.panelMenu.TabIndex = 4;
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
            this.panelTitleBar.Location = new System.Drawing.Point(254, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(957, 100);
            this.panelTitleBar.TabIndex = 5;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
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
            this.btnMinimize.Location = new System.Drawing.Point(840, 8);
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
            this.btnMaximize.Location = new System.Drawing.Point(875, 8);
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
            this.btnClose.Location = new System.Drawing.Point(910, 7);
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
            this.labelName.Location = new System.Drawing.Point(748, 52);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(124, 21);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Selamat Datang";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(678, 31);
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
            this.panelShadow.Location = new System.Drawing.Point(254, 100);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(957, 6);
            this.panelShadow.TabIndex = 6;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(68)))), ((int)(((byte)(105)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(254, 106);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(957, 629);
            this.panelDesktop.TabIndex = 7;
            // 
            // FormHomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 735);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormHomeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHomeAdmin";
            this.Load += new System.EventHandler(this.FormHomeAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnKeluar;
        private FontAwesome.Sharp.IconButton btnMahasiswa;
        private FontAwesome.Sharp.IconButton btnUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMenu;
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