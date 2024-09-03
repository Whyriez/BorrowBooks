namespace BorrowBooks1.Usercontrol
{
    partial class UserControlRiwayat
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
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelPinjam = new System.Windows.Forms.Label();
            this.labelBuku = new System.Windows.Forms.Label();
            this.labelStudi = new System.Windows.Forms.Label();
            this.labelJurusan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelKembali = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.labelStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelStatus.Location = new System.Drawing.Point(1814, 42);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(57, 21);
            this.labelStatus.TabIndex = 23;
            this.labelStatus.Text = "Status";
            // 
            // labelPinjam
            // 
            this.labelPinjam.AutoSize = true;
            this.labelPinjam.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.labelPinjam.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPinjam.Location = new System.Drawing.Point(1139, 42);
            this.labelPinjam.Name = "labelPinjam";
            this.labelPinjam.Size = new System.Drawing.Size(110, 21);
            this.labelPinjam.TabIndex = 22;
            this.labelPinjam.Text = "TanggalPinjam";
            // 
            // labelBuku
            // 
            this.labelBuku.AutoSize = true;
            this.labelBuku.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.labelBuku.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelBuku.Location = new System.Drawing.Point(847, 42);
            this.labelBuku.Name = "labelBuku";
            this.labelBuku.Size = new System.Drawing.Size(90, 21);
            this.labelBuku.TabIndex = 21;
            this.labelBuku.Text = "Nama Buku";
            // 
            // labelStudi
            // 
            this.labelStudi.AutoSize = true;
            this.labelStudi.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.labelStudi.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelStudi.Location = new System.Drawing.Point(588, 42);
            this.labelStudi.Name = "labelStudi";
            this.labelStudi.Size = new System.Drawing.Size(113, 21);
            this.labelStudi.TabIndex = 20;
            this.labelStudi.Text = "Program Studi";
            // 
            // labelJurusan
            // 
            this.labelJurusan.AutoSize = true;
            this.labelJurusan.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.labelJurusan.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelJurusan.Location = new System.Drawing.Point(371, 42);
            this.labelJurusan.Name = "labelJurusan";
            this.labelJurusan.Size = new System.Drawing.Size(66, 21);
            this.labelJurusan.TabIndex = 19;
            this.labelJurusan.Text = "Jurusan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(47, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.labelNama.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNama.Location = new System.Drawing.Point(182, 42);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(50, 21);
            this.labelNama.TabIndex = 17;
            this.labelNama.Text = "Nama";
            // 
            // labelKembali
            // 
            this.labelKembali.AutoSize = true;
            this.labelKembali.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.labelKembali.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelKembali.Location = new System.Drawing.Point(1477, 42);
            this.labelKembali.Name = "labelKembali";
            this.labelKembali.Size = new System.Drawing.Size(118, 21);
            this.labelKembali.TabIndex = 24;
            this.labelKembali.Text = "TanggalKembali";
            // 
            // UserControlRiwayat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.Controls.Add(this.labelKembali);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelPinjam);
            this.Controls.Add(this.labelBuku);
            this.Controls.Add(this.labelStudi);
            this.Controls.Add(this.labelJurusan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelNama);
            this.Name = "UserControlRiwayat";
            this.Size = new System.Drawing.Size(2051, 106);
            this.Load += new System.EventHandler(this.UserControlRiwayat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelPinjam;
        private System.Windows.Forms.Label labelBuku;
        private System.Windows.Forms.Label labelStudi;
        private System.Windows.Forms.Label labelJurusan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelKembali;
    }
}
