namespace BorrowBooks1.Usercontrol
{
    partial class UserControlOperator
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
            this.labelUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.labelUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelUser.Location = new System.Drawing.Point(149, 39);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(79, 21);
            this.labelUser.TabIndex = 6;
            this.labelUser.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.labelRole.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRole.Location = new System.Drawing.Point(729, 39);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(40, 21);
            this.labelRole.TabIndex = 8;
            this.labelRole.Text = "Role";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.labelNama.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNama.Location = new System.Drawing.Point(434, 39);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(113, 21);
            this.labelNama.TabIndex = 9;
            this.labelNama.Text = "Nama Lengkap";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.labelID.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelID.Location = new System.Drawing.Point(149, 10);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(29, 21);
            this.labelID.TabIndex = 10;
            this.labelID.Text = "ID";
            this.labelID.Visible = false;
            // 
            // UserControlOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelUser);
            this.Name = "UserControlOperator";
            this.Size = new System.Drawing.Size(1071, 103);
            this.Load += new System.EventHandler(this.UserControlOperator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelID;
    }
}
