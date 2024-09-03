namespace BorrowBooks1
{
    partial class FormRiwayat
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.userControlRiwayat1 = new BorrowBooks1.Usercontrol.UserControlRiwayat();
            this.label3 = new System.Windows.Forms.Label();
            this.textCari = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.userControlRiwayat1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 88);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 350);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // userControlRiwayat1
            // 
            this.userControlRiwayat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.userControlRiwayat1.Jurusan = null;
            this.userControlRiwayat1.Location = new System.Drawing.Point(3, 3);
            this.userControlRiwayat1.NamaBuku = null;
            this.userControlRiwayat1.NamaMahasiswa = null;
            this.userControlRiwayat1.Name = "userControlRiwayat1";
            this.userControlRiwayat1.Profile = null;
            this.userControlRiwayat1.ProgramStudi = null;
            this.userControlRiwayat1.Size = new System.Drawing.Size(1710, 106);
            this.userControlRiwayat1.Status = null;
            this.userControlRiwayat1.TabIndex = 0;
            this.userControlRiwayat1.TanggalKembali = null;
            this.userControlRiwayat1.TanggalPinjam = null;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(534, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cari";
            // 
            // textCari
            // 
            this.textCari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCari.Location = new System.Drawing.Point(588, 58);
            this.textCari.Name = "textCari";
            this.textCari.Size = new System.Drawing.Size(200, 24);
            this.textCari.TabIndex = 22;
            this.textCari.TextChanged += new System.EventHandler(this.textCari_TextChanged);
            // 
            // FormRiwayat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(68)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCari);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormRiwayat";
            this.Text = "FormRiwayat";
            this.Load += new System.EventHandler(this.FormRiwayat_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCari;
        private Usercontrol.UserControlRiwayat userControlRiwayat1;
    }
}