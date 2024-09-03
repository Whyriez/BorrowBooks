namespace BorrowBooks1
{
    partial class FormBuku
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBuku = new System.Windows.Forms.TextBox();
            this.textPenulis = new System.Windows.Forms.TextBox();
            this.textPenerbit = new System.Windows.Forms.TextBox();
            this.textTerbit = new System.Windows.Forms.TextBox();
            this.textIsbn = new System.Windows.Forms.TextBox();
            this.textIdBuku = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textCari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.userControlBuku1 = new BorrowBooks1.Usercontrol.UserControlBuku();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Penulis Buku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(16, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Penerbit Buku";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(413, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Isbn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(413, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tahun terbit";
            // 
            // textBuku
            // 
            this.textBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuku.Location = new System.Drawing.Point(179, 22);
            this.textBuku.Name = "textBuku";
            this.textBuku.Size = new System.Drawing.Size(200, 24);
            this.textBuku.TabIndex = 5;
            // 
            // textPenulis
            // 
            this.textPenulis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPenulis.Location = new System.Drawing.Point(179, 80);
            this.textPenulis.Name = "textPenulis";
            this.textPenulis.Size = new System.Drawing.Size(200, 24);
            this.textPenulis.TabIndex = 6;
            // 
            // textPenerbit
            // 
            this.textPenerbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPenerbit.Location = new System.Drawing.Point(179, 137);
            this.textPenerbit.Name = "textPenerbit";
            this.textPenerbit.Size = new System.Drawing.Size(200, 24);
            this.textPenerbit.TabIndex = 7;
            // 
            // textTerbit
            // 
            this.textTerbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTerbit.Location = new System.Drawing.Point(567, 21);
            this.textTerbit.Name = "textTerbit";
            this.textTerbit.Size = new System.Drawing.Size(200, 24);
            this.textTerbit.TabIndex = 8;
            this.textTerbit.TextChanged += new System.EventHandler(this.textTerbit_TextChanged);
            this.textTerbit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTerbit_KeyPress);
            // 
            // textIsbn
            // 
            this.textIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIsbn.Location = new System.Drawing.Point(567, 78);
            this.textIsbn.Name = "textIsbn";
            this.textIsbn.Size = new System.Drawing.Size(200, 24);
            this.textIsbn.TabIndex = 9;
            this.textIsbn.TextChanged += new System.EventHandler(this.textIsbn_TextChanged);
            this.textIsbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIsbn_KeyPress);
            // 
            // textIdBuku
            // 
            this.textIdBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdBuku.Location = new System.Drawing.Point(629, 137);
            this.textIdBuku.Name = "textIdBuku";
            this.textIdBuku.Size = new System.Drawing.Size(105, 24);
            this.textIdBuku.TabIndex = 10;
            this.textIdBuku.Visible = false;
            this.textIdBuku.TextChanged += new System.EventHandler(this.textIdBuku_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(808, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(178, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.userControlBuku1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 302);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1107, 310);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(284, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 14;
            this.button2.Text = "Ubah";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Location = new System.Drawing.Point(393, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 15;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.Location = new System.Drawing.Point(501, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 16;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textCari
            // 
            this.textCari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCari.Location = new System.Drawing.Point(919, 272);
            this.textCari.Name = "textCari";
            this.textCari.Size = new System.Drawing.Size(200, 24);
            this.textCari.TabIndex = 18;
            this.textCari.TextChanged += new System.EventHandler(this.textCari_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(858, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cari";
            // 
            // userControlBuku1
            // 
            this.userControlBuku1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.userControlBuku1.GambarBuku = null;
            this.userControlBuku1.IDBuku = null;
            this.userControlBuku1.Isbn = null;
            this.userControlBuku1.Location = new System.Drawing.Point(3, 3);
            this.userControlBuku1.NamaBuku = null;
            this.userControlBuku1.Name = "userControlBuku1";
            this.userControlBuku1.PenerbitBuku = null;
            this.userControlBuku1.PenulisBuku = null;
            this.userControlBuku1.Size = new System.Drawing.Size(2098, 108);
            this.userControlBuku1.TabIndex = 0;
            this.userControlBuku1.TahunTerbit = null;
            // 
            // FormBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(68)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1131, 624);
            this.Controls.Add(this.textCari);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textIdBuku);
            this.Controls.Add(this.textIsbn);
            this.Controls.Add(this.textTerbit);
            this.Controls.Add(this.textPenerbit);
            this.Controls.Add(this.textPenulis);
            this.Controls.Add(this.textBuku);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBuku";
            this.Text = "FormBuku";
            this.Load += new System.EventHandler(this.FormBuku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBuku;
        private System.Windows.Forms.TextBox textPenulis;
        private System.Windows.Forms.TextBox textPenerbit;
        private System.Windows.Forms.TextBox textTerbit;
        private System.Windows.Forms.TextBox textIsbn;
        private System.Windows.Forms.TextBox textIdBuku;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Usercontrol.UserControlBuku userControlBuku1;
        private System.Windows.Forms.TextBox textCari;
        private System.Windows.Forms.Label label6;
    }
}