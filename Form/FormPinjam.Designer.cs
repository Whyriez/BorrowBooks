namespace BorrowBooks1
{
    partial class FormPinjam
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
            this.textJurusan = new System.Windows.Forms.TextBox();
            this.textProdi = new System.Windows.Forms.TextBox();
            this.comboBoxBuku = new System.Windows.Forms.ComboBox();
            this.comboBoxNama = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerPinjam = new System.Windows.Forms.DateTimePicker();
            this.labelIDMahasiswa = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.userControlPinjamBuku1 = new BorrowBooks1.Usercontrol.UserControlPinjamBuku();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCAri = new System.Windows.Forms.Label();
            this.textCari = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textJurusan
            // 
            this.textJurusan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textJurusan.Location = new System.Drawing.Point(204, 110);
            this.textJurusan.Name = "textJurusan";
            this.textJurusan.Size = new System.Drawing.Size(200, 24);
            this.textJurusan.TabIndex = 6;
            this.textJurusan.TextChanged += new System.EventHandler(this.textJurusan_TextChanged);
            // 
            // textProdi
            // 
            this.textProdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProdi.Location = new System.Drawing.Point(605, 21);
            this.textProdi.Name = "textProdi";
            this.textProdi.Size = new System.Drawing.Size(200, 24);
            this.textProdi.TabIndex = 7;
            this.textProdi.TextChanged += new System.EventHandler(this.textProdi_TextChanged);
            // 
            // comboBoxBuku
            // 
            this.comboBoxBuku.FormattingEnabled = true;
            this.comboBoxBuku.Location = new System.Drawing.Point(204, 65);
            this.comboBoxBuku.Name = "comboBoxBuku";
            this.comboBoxBuku.Size = new System.Drawing.Size(200, 24);
            this.comboBoxBuku.TabIndex = 8;
            this.comboBoxBuku.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuku_SelectedIndexChanged);
            // 
            // comboBoxNama
            // 
            this.comboBoxNama.FormattingEnabled = true;
            this.comboBoxNama.Location = new System.Drawing.Point(204, 22);
            this.comboBoxNama.Name = "comboBoxNama";
            this.comboBoxNama.Size = new System.Drawing.Size(200, 24);
            this.comboBoxNama.TabIndex = 9;
            this.comboBoxNama.SelectedIndexChanged += new System.EventHandler(this.comboBoxNama_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nama Mahasiswa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nama Buku";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Jurusan";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(427, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Program Studi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(427, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tanggal Pinjam";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateTimePickerPinjam
            // 
            this.dateTimePickerPinjam.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerPinjam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPinjam.Location = new System.Drawing.Point(605, 65);
            this.dateTimePickerPinjam.Name = "dateTimePickerPinjam";
            this.dateTimePickerPinjam.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerPinjam.TabIndex = 15;
            this.dateTimePickerPinjam.ValueChanged += new System.EventHandler(this.dateTimePickerPinjam_ValueChanged);
            // 
            // labelIDMahasiswa
            // 
            this.labelIDMahasiswa.AutoSize = true;
            this.labelIDMahasiswa.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDMahasiswa.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelIDMahasiswa.Location = new System.Drawing.Point(427, 113);
            this.labelIDMahasiswa.Name = "labelIDMahasiswa";
            this.labelIDMahasiswa.Size = new System.Drawing.Size(96, 21);
            this.labelIDMahasiswa.TabIndex = 17;
            this.labelIDMahasiswa.Text = "idmahasiswa";
            this.labelIDMahasiswa.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(204, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "Pinjamkan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(344, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 40);
            this.button2.TabIndex = 19;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.userControlPinjamBuku1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 241);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(906, 350);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // userControlPinjamBuku1
            // 
            this.userControlPinjamBuku1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.userControlPinjamBuku1.IdPinjam = null;
            this.userControlPinjamBuku1.Jurusan = null;
            this.userControlPinjamBuku1.Location = new System.Drawing.Point(3, 3);
            this.userControlPinjamBuku1.NamaBuku = null;
            this.userControlPinjamBuku1.NamaMahasiswa = null;
            this.userControlPinjamBuku1.Name = "userControlPinjamBuku1";
            this.userControlPinjamBuku1.Profile = null;
            this.userControlPinjamBuku1.ProgramStudi = null;
            this.userControlPinjamBuku1.Size = new System.Drawing.Size(1410, 105);
            this.userControlPinjamBuku1.TabIndex = 0;
            this.userControlPinjamBuku1.TanggalPinjam = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(818, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // labelCAri
            // 
            this.labelCAri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCAri.AutoSize = true;
            this.labelCAri.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCAri.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCAri.Location = new System.Drawing.Point(646, 212);
            this.labelCAri.Name = "labelCAri";
            this.labelCAri.Size = new System.Drawing.Size(38, 21);
            this.labelCAri.TabIndex = 30;
            this.labelCAri.Text = "Cari";
            // 
            // textCari
            // 
            this.textCari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCari.Location = new System.Drawing.Point(718, 211);
            this.textCari.Name = "textCari";
            this.textCari.Size = new System.Drawing.Size(200, 24);
            this.textCari.TabIndex = 29;
            this.textCari.TextChanged += new System.EventHandler(this.textCari_TextChanged);
            // 
            // FormPinjam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(68)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(930, 603);
            this.Controls.Add(this.labelCAri);
            this.Controls.Add(this.textCari);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelIDMahasiswa);
            this.Controls.Add(this.dateTimePickerPinjam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNama);
            this.Controls.Add(this.comboBoxBuku);
            this.Controls.Add(this.textProdi);
            this.Controls.Add(this.textJurusan);
            this.Name = "FormPinjam";
            this.Text = "FormPinjam";
            this.Load += new System.EventHandler(this.FormPinjam_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textJurusan;
        private System.Windows.Forms.TextBox textProdi;
        private System.Windows.Forms.ComboBox comboBoxBuku;
        private System.Windows.Forms.ComboBox comboBoxNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerPinjam;
        private System.Windows.Forms.Label labelIDMahasiswa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Usercontrol.UserControlPinjamBuku userControlPinjamBuku1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCAri;
        private System.Windows.Forms.TextBox textCari;
    }
}