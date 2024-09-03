using BorrowBooks1.Usercontrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace BorrowBooks1
{
    public partial class FormOperator : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseBorrowBooks.mdf;Integrated Security=True");
        public FormOperator()
        {
            InitializeComponent();
            GetData(); 
        }
        private void GetData()
        {
            flowLayoutPanel1.Controls.Clear();
            String querry = "SELECT * FROM tb_user";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                UserControlOperator[] listItem = new UserControlOperator[dtable.Rows.Count];

                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dtable.Rows)
                    {
                        listItem[i] = new UserControlOperator();

                        Byte[] imgData = (byte[])row["profile_picture"];
                        MemoryStream ms = new MemoryStream(imgData);
                        listItem[i].Profile = System.Drawing.Image.FromStream(ms, false);
                        listItem[i].Username = row["username"].ToString();
                        listItem[i].NamaLengkap = row["nama"].ToString();
                        listItem[i].UserRole = row["role"].ToString();
                        listItem[i].ID = row["Iduser"].ToString();
                        flowLayoutPanel1.Controls.Add(listItem[i]);

                        listItem[i].Click += new System.EventHandler(editHapus);
                    }
                }



            }
        }

        private void cariData()
        {
            flowLayoutPanel1.Controls.Clear();
            String querry = "SELECT * FROM tb_user where nama like '"+ textCari.Text +"' AND username like '"+ textCari.Text +"'";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                UserControlOperator[] listItem = new UserControlOperator[dtable.Rows.Count];

                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dtable.Rows)
                    {
                        listItem[i] = new UserControlOperator();

                        Byte[] imgData = (byte[])row["profile_picture"];
                        MemoryStream ms = new MemoryStream(imgData);
                        listItem[i].Profile = System.Drawing.Image.FromStream(ms, false);
                        listItem[i].Username = row["username"].ToString();
                        listItem[i].NamaLengkap = row["nama"].ToString();
                        listItem[i].UserRole = row["role"].ToString();
                        listItem[i].ID = row["Iduser"].ToString();
                        flowLayoutPanel1.Controls.Add(listItem[i]);

                        listItem[i].Click += new System.EventHandler(editHapus);
                    }
                }



            }
        }


        void editHapus(object sender, EventArgs e)
        {
            UserControlOperator list = (UserControlOperator)sender;

            textUsername.Text = list.Username;
            textNama.Text = list.NamaLengkap;
            comboBoxRole.Text = list.UserRole;
            /*textPassword.Text = list.Pas;*/
            textID.Text = list.ID;
            pictureBox1.Image = list.Profile;
        }

        void Refresh()
        {
            textUsername.Text = "";
            textNama.Text = "";
            comboBoxRole.Text = "";
            textPassword.Text = "";
            textID.Text = "";
            pictureBox1.Image = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormOperator_Load(object sender, EventArgs e)
        {
            comboBoxRole.Items.Add("Admin");
            comboBoxRole.Items.Add("Operator");

            comboBoxRole.SelectedItem = null;
            comboBoxRole.SelectedText = "--Pilih Role--";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "" || textPassword.Text == "" || textNama.Text == "" || comboBoxRole.Text == "" ||  pictureBox1.Image == null)
            {
                MessageBox.Show("Silahkan Isi Semua Field");
            }
            else
            {
                Image img = pictureBox1.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                conn.Open();
                SqlCommand cmd4 = new SqlCommand("insert into tb_user (username,nama,role,profile_picture,password) values ('" + textUsername.Text + "','" + textNama.Text + "', '" + comboBoxRole.SelectedItem + "', @image, '" + textPassword.Text + "')", conn);
                cmd4.Parameters.AddWithValue("@image", arr);
                cmd4.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("User Berhasil Ditambahkan");
                GetData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "" || textPassword.Text == "" || textNama.Text == "" || comboBoxRole.Text == "" || pictureBox1.Image == null)
            {
                MessageBox.Show("Silahkan Isi Semua Field");
            }
            else
            {
                Image img = pictureBox1.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                conn.Open();
                SqlCommand cmd = new SqlCommand("update tb_user set username = '" + textUsername.Text + "', nama = '" + textNama.Text + "', role = '" + comboBoxRole.SelectedItem + "', password = '" + textPassword.Text + "', profile_picture = @image where IdUser ='" + int.Parse(textID.Text) + "'", conn);
                cmd.Parameters.AddWithValue("@image", arr);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("User Berhasil Diubah");
                GetData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textID.Text == "" )
            {
                MessageBox.Show("Silahkan Pilih data yang ingin dihapus");
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from tb_user where Iduser ='" + int.Parse(textID.Text) + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("User Berhasil Dihapus");
                GetData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }

        private void textCari_TextChanged(object sender, EventArgs e)
        {
            if(textCari.Text == "")
            {
                GetData();
            }
            else
            {
                cariData();
            }
        }
    }
}
