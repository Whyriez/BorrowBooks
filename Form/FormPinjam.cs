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
    public partial class FormPinjam : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseBorrowBooks.mdf;Integrated Security=True");
        public string Status = "Belum Dikembalikan";
        public FormPinjam()
        {
            InitializeComponent();
            tampilBuku();
            tampilNama();
            GetData();
        }

        private void GetData()
        {
            flowLayoutPanel1.Controls.Clear();
            String querry = "SELECT * FROM tb_peminjaman";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                UserControlPinjamBuku[] listItem = new UserControlPinjamBuku[dtable.Rows.Count];

                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dtable.Rows)
                    {
                        listItem[i] = new UserControlPinjamBuku();

                        Byte[] imgData = (byte[])row["profile_image"];
                        MemoryStream ms = new MemoryStream(imgData);
                        listItem[i].Profile = System.Drawing.Image.FromStream(ms, false);
                        listItem[i].NamaMahasiswa = row["nama_mahasiswa"].ToString();
                        listItem[i].Jurusan = row["jurusan"].ToString();
                        listItem[i].ProgramStudi = row["program_studi"].ToString();
                        listItem[i].NamaBuku = row["nama_buku"].ToString();
                        listItem[i].TanggalPinjam = row["tgl_pinjam"].ToString();
                        flowLayoutPanel1.Controls.Add(listItem[i]);


                    }
                }



            }
        }

        void cariData()
        {
            flowLayoutPanel1.Controls.Clear();
            String querry = "SELECT * FROM tb_peminjaman where nama_mahasiswa like '"+ textCari.Text +"'";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                UserControlPinjamBuku[] listItem = new UserControlPinjamBuku[dtable.Rows.Count];

                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dtable.Rows)
                    {
                        listItem[i] = new UserControlPinjamBuku();

                        Byte[] imgData = (byte[])row["profile_image"];
                        MemoryStream ms = new MemoryStream(imgData);
                        listItem[i].Profile = System.Drawing.Image.FromStream(ms, false);
                        listItem[i].NamaMahasiswa = row["nama_mahasiswa"].ToString();
                        listItem[i].Jurusan = row["jurusan"].ToString();
                        listItem[i].ProgramStudi = row["program_studi"].ToString();
                        listItem[i].NamaBuku = row["nama_buku"].ToString();
                        listItem[i].TanggalPinjam = row["tgl_pinjam"].ToString();
                        flowLayoutPanel1.Controls.Add(listItem[i]);


                    }
                }



            }
        }
        void Refresh()
        {
            comboBoxNama.Text = "";
            comboBoxBuku.Text = "";
            textJurusan.Text = "";
            textProdi.Text = "";
            dateTimePickerPinjam.Text = "";
            pictureBox1.Image = null;
        }

        public void tampilBuku()
        {
            try
            {

                string query = "select Id, nama_buku from tb_buku";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandText = query;
                conn.Open();
                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    comboBoxBuku.Items.Add(drd["nama_buku"].ToString());
                    comboBoxBuku.ValueMember = drd["Id"].ToString();
                    comboBoxBuku.DisplayMember = drd["nama_buku"].ToString();
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error ");
            }
        }

        public void tampilNama()
        {
            try
            {
                string query1 = "select Id_mahasiswa, nama_lengkap from tb_mahasiswa";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                cmd1.CommandText = query1;
                conn.Open();
                SqlDataReader drd1 = cmd1.ExecuteReader();
                while (drd1.Read())
                {
                    comboBoxNama.Items.Add(drd1["nama_lengkap"].ToString());
                    comboBoxNama.ValueMember = drd1["Id_mahasiswa"].ToString();
                    comboBoxNama.DisplayMember = drd1["nama_lengkap"].ToString();
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void FormPinjam_Load(object sender, EventArgs e)
        {
            dateTimePickerPinjam.CustomFormat = "dd-MM-yyyy";
        }

        private void comboBoxNama_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_mahasiswa where nama_lengkap = '" + comboBoxNama.SelectedItem.ToString() + "'", conn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                textJurusan.Text = dr["jurusan"].ToString();
                textProdi.Text = dr["program_studi"].ToString();
                labelIDMahasiswa.Text = dr["Id_mahasiswa"].ToString();
                Byte[] imgData = (byte[])dr["profile_image"];
                MemoryStream ms = new MemoryStream(imgData);
                pictureBox1.Image = Image.FromStream(ms, false);
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxNama.Text == "" || comboBoxBuku.Text == "" || textJurusan.Text == "" || textProdi.Text == "" || dateTimePickerPinjam.Text == "" || pictureBox1.Image == null)
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
                SqlCommand cmd4 = new SqlCommand("insert into tb_peminjaman (id_mahasiswa,nama_mahasiswa,jurusan,program_studi,nama_buku,tgl_pinjam,profile_image,status) values ('" + labelIDMahasiswa.Text + "', '" + comboBoxNama.SelectedItem + "','" + textJurusan.Text + "', '" + textProdi.Text + "', '" + comboBoxBuku.SelectedItem + "', '" + dateTimePickerPinjam.Value.Date.ToString("MM/dd/yyyy") + "' ,@image, '" + Status + "')", conn);
                cmd4.Parameters.AddWithValue("@image", arr);
                cmd4.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Buku Berhasil Ditambahkan");
                GetData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Refresh();
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

        private void textJurusan_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxBuku_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerPinjam_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textProdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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
