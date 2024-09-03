namespace BorrowBooks1
{
    partial class FormPengembalian
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
            this.textBuku = new System.Windows.Forms.TextBox();
            this.dateTimePickerPinjam = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerKembali = new System.Windows.Forms.DateTimePicker();
            this.comboBoxNama = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelidPinjam = new System.Windows.Forms.Label();
            this.labelCAri = new System.Windows.Forms.Label();
            this.textCari = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.textWaktuPinjam = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelDenda = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControlPengembalian2 = new BorrowBooks1.Usercontrol.UserControlPengembalian();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textJurusan
            // 
            this.textJurusan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textJurusan.Location = new System.Drawing.Point(218, 121);
            this.textJurusan.Name = "textJurusan";
            this.textJurusan.Size = new System.Drawing.Size(200, 24);
            this.textJurusan.TabIndex = 7;
            // 
            // textProdi
            // 
            this.textProdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProdi.Location = new System.Drawing.Point(633, 38);
            this.textProdi.Name = "textProdi";
            this.textProdi.Size = new System.Drawing.Size(200, 24);
            this.textProdi.TabIndex = 8;
            // 
            // textBuku
            // 
            this.textBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuku.Location = new System.Drawing.Point(218, 79);
            this.textBuku.Name = "textBuku";
            this.textBuku.Size = new System.Drawing.Size(200, 24);
            this.textBuku.TabIndex = 9;
            this.textBuku.TextChanged += new System.EventHandler(this.textBuku_TextChanged);
            // 
            // dateTimePickerPinjam
            // 
            this.dateTimePickerPinjam.CustomFormat = "";
            this.dateTimePickerPinjam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPinjam.Location = new System.Drawing.Point(633, 81);
            this.dateTimePickerPinjam.Name = "dateTimePickerPinjam";
            this.dateTimePickerPinjam.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerPinjam.TabIndex = 16;
            this.dateTimePickerPinjam.Value = new System.DateTime(2022, 10, 3, 0, 0, 0, 0);
            // 
            // dateTimePickerKembali
            // 
            this.dateTimePickerKembali.CustomFormat = "";
            this.dateTimePickerKembali.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerKembali.Location = new System.Drawing.Point(633, 123);
            this.dateTimePickerKembali.Name = "dateTimePickerKembali";
            this.dateTimePickerKembali.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerKembali.TabIndex = 17;
            this.dateTimePickerKembali.Value = new System.DateTime(2022, 10, 3, 0, 0, 0, 0);
            this.dateTimePickerKembali.ValueChanged += new System.EventHandler(this.dateTimePickerKembali_ValueChanged);
            // 
            // comboBoxNama
            // 
            this.comboBoxNama.FormattingEnabled = true;
            this.comboBoxNama.Location = new System.Drawing.Point(218, 38);
            this.comboBoxNama.Name = "comboBoxNama";
            this.comboBoxNama.Size = new System.Drawing.Size(200, 24);
            this.comboBoxNama.TabIndex = 18;
            this.comboBoxNama.SelectedIndexChanged += new System.EventHandler(this.comboBoxNama_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nama Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nama Buku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Jurusan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(457, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Program Studi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(457, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tanggal Pinjam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(457, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tanggal Kembali";
            // 
            // labelidPinjam
            // 
            this.labelidPinjam.AutoSize = true;
            this.labelidPinjam.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidPinjam.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelidPinjam.Location = new System.Drawing.Point(303, 174);
            this.labelidPinjam.Name = "labelidPinjam";
            this.labelidPinjam.Size = new System.Drawing.Size(69, 21);
            this.labelidPinjam.TabIndex = 25;
            this.labelidPinjam.Text = "idPinjam";
            this.labelidPinjam.Visible = false;
            // 
            // labelCAri
            // 
            this.labelCAri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCAri.AutoSize = true;
            this.labelCAri.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCAri.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCAri.Location = new System.Drawing.Point(766, 188);
            this.labelCAri.Name = "labelCAri";
            this.labelCAri.Size = new System.Drawing.Size(38, 21);
            this.labelCAri.TabIndex = 28;
            this.labelCAri.Text = "Cari";
            // 
            // textCari
            // 
            this.textCari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCari.Location = new System.Drawing.Point(838, 187);
            this.textCari.Name = "textCari";
            this.textCari.Size = new System.Drawing.Size(200, 24);
            this.textCari.TabIndex = 27;
            this.textCari.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.userControlPengembalian2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 217);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1022, 350);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(36, 589);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 32);
            this.label8.TabIndex = 30;
            this.label8.Text = "Lama Pinjam";
            // 
            // textWaktuPinjam
            // 
            this.textWaktuPinjam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textWaktuPinjam.AutoSize = true;
            this.textWaktuPinjam.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.textWaktuPinjam.ForeColor = System.Drawing.Color.Gainsboro;
            this.textWaktuPinjam.Location = new System.Drawing.Point(228, 589);
            this.textWaktuPinjam.Name = "textWaktuPinjam";
            this.textWaktuPinjam.Size = new System.Drawing.Size(62, 32);
            this.textWaktuPinjam.TabIndex = 31;
            this.textWaktuPinjam.Text = "Hari";
            this.textWaktuPinjam.Click += new System.EventHandler(this.textWaktuPinjam_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(36, 645);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 32);
            this.label10.TabIndex = 32;
            this.label10.Text = "Denda";
            // 
            // labelDenda
            // 
            this.labelDenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDenda.AutoSize = true;
            this.labelDenda.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelDenda.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDenda.Location = new System.Drawing.Point(228, 645);
            this.labelDenda.Name = "labelDenda";
            this.labelDenda.Size = new System.Drawing.Size(65, 32);
            this.labelDenda.TabIndex = 33;
            this.labelDenda.Text = "Rp.0";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(671, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 58);
            this.button1.TabIndex = 34;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(838, 573);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 58);
            this.button2.TabIndex = 35;
            this.button2.Text = "Kembalikan";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(914, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 108);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // userControlPengembalian2
            // 
            this.userControlPengembalian2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.userControlPengembalian2.IdPinjam = null;
            this.userControlPengembalian2.Jurusan = null;
            this.userControlPengembalian2.Location = new System.Drawing.Point(3, 3);
            this.userControlPengembalian2.NamaBuku = null;
            this.userControlPengembalian2.NamaMahasiswa = null;
            this.userControlPengembalian2.Name = "userControlPengembalian2";
            this.userControlPengembalian2.Profile = null;
            this.userControlPengembalian2.ProgramStudi = null;
            this.userControlPengembalian2.Size = new System.Drawing.Size(1362, 106);
            this.userControlPengembalian2.Status = null;
            this.userControlPengembalian2.TabIndex = 0;
            this.userControlPengembalian2.TanggalPinjam = null;
            this.userControlPengembalian2.UrlImage = null;
            // 
            // FormPengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(68)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1059, 783);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDenda);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textWaktuPinjam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labelCAri);
            this.Controls.Add(this.textCari);
            this.Controls.Add(this.labelidPinjam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNama);
            this.Controls.Add(this.dateTimePickerKembali);
            this.Controls.Add(this.dateTimePickerPinjam);
            this.Controls.Add(this.textBuku);
            this.Controls.Add(this.textProdi);
            this.Controls.Add(this.textJurusan);
            this.Name = "FormPengembalian";
            this.Text = "FormPengembalian";
            this.Load += new System.EventHandler(this.FormPengembalian_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textJurusan;
        private System.Windows.Forms.TextBox textProdi;
        private System.Windows.Forms.TextBox textBuku;
        private System.Windows.Forms.DateTimePicker dateTimePickerPinjam;
        private System.Windows.Forms.DateTimePicker dateTimePickerKembali;
        private System.Windows.Forms.ComboBox comboBoxNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelidPinjam;
        private System.Windows.Forms.Label labelCAri;
        private System.Windows.Forms.TextBox textCari;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label textWaktuPinjam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelDenda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Usercontrol.UserControlPengembalian userControlPengembalian1;
        private Usercontrol.UserControlPengembalian userControlPengembalian2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}