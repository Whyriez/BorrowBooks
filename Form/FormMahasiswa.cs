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

namespace BorrowBooks1
{
    public partial class FormMahasiswa : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseBorrowBooks.mdf;Integrated Security=True");
        public FormMahasiswa()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            flowLayoutPanel1.Controls.Clear();
            String querry = "SELECT * FROM tb_mahasiswa";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                UserControlMahasiswa[] listItem = new UserControlMahasiswa[dtable.Rows.Count];

                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dtable.Rows)
                    {
                        listItem[i] = new UserControlMahasiswa();

                        Byte[] imgData = (byte[])row["profile_image"];
                        MemoryStream ms = new MemoryStream(imgData);
                        listItem[i].Profile = System.Drawing.Image.FromStream(ms, false);
                        listItem[i].Nim = row["nim"].ToString();
                        listItem[i].NamaMahasiswa = row["nama_lengkap"].ToString();
                        listItem[i].Jurusan = row["jurusan"].ToString();
                        listItem[i].ProgramStudi = row["program_studi"].ToString();
                        listItem[i].IDMahasiswa = row["Id_mahasiswa"].ToString();
                        flowLayoutPanel1.Controls.Add(listItem[i]);

                        listItem[i].Click += new System.EventHandler(editHapus);
                    }
                }



            }
        }

        private void cariData()
        {
            flowLayoutPanel1.Controls.Clear();
            String querry = "SELECT * FROM tb_mahasiswa where nim like '"+ textCari.Text +"' AND nama_lengkap like '"+ textCari.Text +"'";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                UserControlMahasiswa[] listItem = new UserControlMahasiswa[dtable.Rows.Count];

                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dtable.Rows)
                    {
                        listItem[i] = new UserControlMahasiswa();

                        Byte[] imgData = (byte[])row["profile_image"];
                        MemoryStream ms = new MemoryStream(imgData);
                        listItem[i].Profile = System.Drawing.Image.FromStream(ms, false);
                        listItem[i].Nim = row["nim"].ToString();
                        listItem[i].NamaMahasiswa = row["nama_lengkap"].ToString();
                        listItem[i].Jurusan = row["jurusan"].ToString();
                        listItem[i].ProgramStudi = row["program_studi"].ToString();
                        listItem[i].IDMahasiswa = row["Id_mahasiswa"].ToString();
                        flowLayoutPanel1.Controls.Add(listItem[i]);

                        listItem[i].Click += new System.EventHandler(editHapus);
                    }
                }



            }
        }

        void editHapus(object sender, EventArgs e)
        {
            UserControlMahasiswa list = (UserControlMahasiswa)sender;

            textNim.Text = list.Nim;
            textJurusan.Text = list.Jurusan;
            textNama.Text = list.NamaMahasiswa;
            textStudi.Text = list.ProgramStudi;
            textID.Text = list.IDMahasiswa;
            pictureBox1.Image = list.Profile;
        }

        void Refresh()
        {
            textNim.Text = "";
            textJurusan.Text = "";
            textNama.Text = "";
            textStudi.Text = "";
            textID.Text = "";
            pictureBox1.Image = null;
        }

        private void FormMahasiswa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textNim.Text == "" || textNama.Text == "" || textJurusan.Text == ""|| textStudi.Text == "" || pictureBox1.Image == null)
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
                SqlCommand cmd4 = new SqlCommand("insert into tb_mahasiswa (nim,nama_lengkap,jurusan,program_studi,profile_image) values ('" + textNim.Text + "','" + textNama.Text + "', '" + textJurusan.Text + "', '" + textStudi.Text + "', @image)", conn);
                cmd4.Parameters.AddWithValue("@image", arr);
                cmd4.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Mahasiswa Berhasil Ditambahkan");
                GetData();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textNim.Text == "" || textNama.Text == "" || textJurusan.Text == "" || textStudi.Text == "" || pictureBox1.Image == null)
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
                SqlCommand cmd = new SqlCommand("update tb_mahasiswa set nim = '" + textNim.Text + "', nama_lengkap = '" + textNama.Text + "', jurusan = '" + textJurusan.Text + "', program_studi = '" + textStudi.Text + "', profile_image = @image where Id_mahasiswa ='" + int.Parse(textID.Text) + "'", conn);
                cmd.Parameters.AddWithValue("@image", arr);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Mahasiswa Berhasil Diubah");
                GetData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textID.Text == "")
            {
                MessageBox.Show("Silahkan Pilih data yang ingin dihapus");
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from tb_mahasiswa where Id_mahasiswa ='" + int.Parse(textID.Text) + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Mahasiswa Berhasil Dihapus");
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
            if (textCari.Text == "")
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
