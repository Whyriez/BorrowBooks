namespace BorrowBooks1.Usercontrol
{
    partial class UserControlMahasiswa
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
            this.labelNama = new System.Windows.Forms.Label();
            this.labelNim = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelJurusan = new System.Windows.Forms.Label();
            this.labelProdi = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.labelNama.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNama.Location = new System.Drawing.Point(396, 41);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(131, 21);
            this.labelNama.TabIndex = 6;
            this.labelNama.Text = "Nama Mahasiswa";
            // 
            // labelNim
            // 
            this.labelNim.AutoSize = true;
            this.labelNim.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.labelNim.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNim.Location = new System.Drawing.Point(137, 41);
            this.labelNim.Name = "labelNim";
            this.labelNim.Size = new System.Drawing.Size(38, 21);
            this.labelNim.TabIndex = 5;
            this.labelNim.Text = "Nim";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelJurusan
            // 
            this.labelJurusan.AutoSize = true;
            this.labelJurusan.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.labelJurusan.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelJurusan.Location = new System.Drawing.Point(751, 41);
            this.labelJurusan.Name = "labelJurusan";
            this.labelJurusan.Size = new System.Drawing.Size(66, 21);
            this.labelJurusan.TabIndex = 7;
            this.labelJurusan.Text = "Jurusan";
            // 
            // labelProdi
            // 
            this.labelProdi.AutoSize = true;
            this.labelProdi.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.labelProdi.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelProdi.Location = new System.Drawing.Point(1037, 41);
            this.labelProdi.Name = "labelProdi";
            this.labelProdi.Size = new System.Drawing.Size(113, 21);
            this.labelProdi.TabIndex = 8;
            this.labelProdi.Text = "Program Studi";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.labelId.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelId.Location = new System.Drawing.Point(137, 14);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(29, 21);
            this.labelId.TabIndex = 9;
            this.labelId.Text = "ID";
            this.labelId.Visible = false;
            // 
            // UserControlMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelProdi);
            this.Controls.Add(this.labelJurusan);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelNim);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControlMahasiswa";
            this.Size = new System.Drawing.Size(1273, 106);
            this.Load += new System.EventHandler(this.UserControlMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelNim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelJurusan;
        private System.Windows.Forms.Label labelProdi;
        private System.Windows.Forms.Label labelId;
    }
}
