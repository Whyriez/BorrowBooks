namespace BorrowBooks1.Usercontrol
{
    partial class UserControlBuku
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelPenulis = new System.Windows.Forms.Label();
            this.labelTahun = new System.Windows.Forms.Label();
            this.labelPenerbit = new System.Windows.Forms.Label();
            this.labelIsbn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.labelNama.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNama.Location = new System.Drawing.Point(130, 43);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(90, 21);
            this.labelNama.TabIndex = 1;
            this.labelNama.Text = "Nama Buku";
            this.labelNama.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.labelID.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelID.Location = new System.Drawing.Point(130, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(29, 21);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID";
            this.labelID.Visible = false;
            // 
            // labelPenulis
            // 
            this.labelPenulis.AutoSize = true;
            this.labelPenulis.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.labelPenulis.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPenulis.Location = new System.Drawing.Point(534, 43);
            this.labelPenulis.Name = "labelPenulis";
            this.labelPenulis.Size = new System.Drawing.Size(97, 21);
            this.labelPenulis.TabIndex = 3;
            this.labelPenulis.Text = "Penulis Buku";
            // 
            // labelTahun
            // 
            this.labelTahun.AutoSize = true;
            this.labelTahun.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.labelTahun.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTahun.Location = new System.Drawing.Point(1403, 43);
            this.labelTahun.Name = "labelTahun";
            this.labelTahun.Size = new System.Drawing.Size(105, 21);
            this.labelTahun.TabIndex = 4;
            this.labelTahun.Text = "Tahun Terbit";
            // 
            // labelPenerbit
            // 
            this.labelPenerbit.AutoSize = true;
            this.labelPenerbit.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.labelPenerbit.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPenerbit.Location = new System.Drawing.Point(1003, 43);
            this.labelPenerbit.Name = "labelPenerbit";
            this.labelPenerbit.Size = new System.Drawing.Size(109, 21);
            this.labelPenerbit.TabIndex = 5;
            this.labelPenerbit.Text = "Penerbit Buku";
            // 
            // labelIsbn
            // 
            this.labelIsbn.AutoSize = true;
            this.labelIsbn.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.labelIsbn.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelIsbn.Location = new System.Drawing.Point(1821, 43);
            this.labelIsbn.Name = "labelIsbn";
            this.labelIsbn.Size = new System.Drawing.Size(42, 21);
            this.labelIsbn.TabIndex = 6;
            this.labelIsbn.Text = "Isbn";
            // 
            // UserControlBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.Controls.Add(this.labelIsbn);
            this.Controls.Add(this.labelPenerbit);
            this.Controls.Add(this.labelTahun);
            this.Controls.Add(this.labelPenulis);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControlBuku";
            this.Size = new System.Drawing.Size(2098, 108);
            this.Load += new System.EventHandler(this.UserControlBuku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelPenulis;
        private System.Windows.Forms.Label labelTahun;
        private System.Windows.Forms.Label labelPenerbit;
        private System.Windows.Forms.Label labelIsbn;
    }
}
