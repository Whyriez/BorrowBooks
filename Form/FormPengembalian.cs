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
    public partial class FormPengembalian : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseBorrowBooks.mdf;Integrated Security=True");
        public String Status = "Belum Dikembalikan";
        public String StatusKembali = "Sudah Dikembalikan";
        public FormPengembalian()
        {
            InitializeComponent();
            tampilNamaCombo();
            GetData();
        }

        private void GetData()
        {
            flowLayoutPanel1.Controls.Clear();
            String querry = "SELECT * FROM tb_peminjaman where nama_mahasiswa like '" + comboBoxNama.SelectedItem + "' AND status like '" + Status + "'";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                UserControlPengembalian[] listItem = new UserControlPengembalian[dtable.Rows.Count];

                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dtable.Rows)
                    {
                        listItem[i] = new UserControlPengembalian();

                        Byte[] imgData = (byte[])row["profile_image"];
                        MemoryStream ms = new MemoryStream(imgData);
                        listItem[i].Profile = System.Drawing.Image.FromStream(ms, false);
                        listItem[i].IdPinjam = row["id_pinjam"].ToString();
                        listItem[i].NamaMahasiswa = row["nama_mahasiswa"].ToString();
                        listItem[i].Jurusan = row["jurusan"].ToString();
                        listItem[i].ProgramStudi = row["program_studi"].ToString();
                        listItem[i].NamaBuku = row["nama_buku"].ToString();
                        listItem[i].TanggalPinjam = row["tgl_pinjam"].ToString();
                        listItem[i].Status = row["status"].ToString();
                        flowLayoutPanel1.Controls.Add(listItem[i]);

                        listItem[i].Click += new System.EventHandler(getBuku);
                    }
                }



            }
        }

        private void cariData()
        {
            flowLayoutPanel1.Controls.Clear();
            String querry = "SELECT * FROM tb_peminjaman where nama_mahasiswa like '" + comboBoxNama.SelectedItem + "' AND status like '" + Status + "' AND nama_buku like '"+ textCari.Text +"'";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                UserControlPengembalian[] listItem = new UserControlPengembalian[dtable.Rows.Count];

                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dtable.Rows)
                    {
                        listItem[i] = new UserControlPengembalian();

                        Byte[] imgData = (byte[])row["profile_image"];
                        MemoryStream ms = new MemoryStream(imgData);
                        listItem[i].Profile = System.Drawing.Image.FromStream(ms, false);
                        listItem[i].IdPinjam = row["id_pinjam"].ToString();
                        listItem[i].NamaMahasiswa = row["nama_mahasiswa"].ToString();
                        listItem[i].Jurusan = row["jurusan"].ToString();
                        listItem[i].ProgramStudi = row["program_studi"].ToString();
                        listItem[i].NamaBuku = row["nama_buku"].ToString();
                        listItem[i].TanggalPinjam = row["tgl_pinjam"].ToString();
                        listItem[i].Status = row["status"].ToString();
                        flowLayoutPanel1.Controls.Add(listItem[i]);

                        listItem[i].Click += new System.EventHandler(getBuku);
                    }
                }



            }
        }


        void getBuku(object sender, EventArgs e)
        {
            UserControlPengembalian list = (UserControlPengembalian)sender;

            textBuku.Text = list.NamaBuku;
            textJurusan.Text = list.Jurusan;
            textProdi.Text = list.ProgramStudi;
            dateTimePickerPinjam.Text = list.TanggalPinjam;
            labelidPinjam.Text = list.IdPinjam;
            pictureBox1.Image = list.Profile;
        }

        public void tampilNamaCombo()
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

        void Refresh()
        {
            comboBoxNama.SelectedItem = null;
            comboBoxNama.SelectedText = "--Pilih Nama--";
            textBuku.Text = "";
            textJurusan.Text = "";
            textProdi.Text = "";
            dateTimePickerPinjam.Text = "";
            dateTimePickerKembali.Text = "";
            pictureBox1.Image = null;
            labelidPinjam.Text = "";
        }

        private void FormPengembalian_Load(object sender, EventArgs e)
        {
            comboBoxNama.SelectedItem = null;
            comboBoxNama.SelectedText = "--Pilih Nama--";
        }

        private void comboBoxNama_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void dateTimePickerKembali_ValueChanged(object sender, EventArgs e)
        {
            int a, b;
            string denda = labelDenda.Text;
            DateTime tanggal1 = Convert.ToDateTime(dateTimePickerPinjam.Text);
            DateTime tanggal2 = Convert.ToDateTime(dateTimePickerKembali.Text);
            TimeSpan ts = new TimeSpan();
            ts = tanggal2.Subtract(tanggal1);
            textWaktuPinjam.Text = ts.Days + " Hari";

            
            if (ts.Days <= 3)
            {
                labelDenda.Text = "Rp.0";
            }
            else if (ts.Days > 3)
            {
                a = (ts.Days - 3) * 500;
                labelDenda.Text = Convert.ToString("Rp." + a);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxNama.Text == "" || textBuku.Text == "" || textJurusan.Text == "" || textProdi.Text == "" || dateTimePickerPinjam.Text == "" || pictureBox1.Image == null)
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

                SqlCommand cmd4 = new SqlCommand("insert into tb_pengembalian (id_pinjam,Profile_image,Nama_mahasiswa,Jurusan,Program_studi,Nama_buku,Tgl_pinjam,Tgl_kembali,denda,Status) values ('" + labelidPinjam.Text + "', @image ,'" + comboBoxNama.SelectedItem + "','" + textJurusan.Text + "', '" + textProdi.Text + "', '" + textBuku.Text + "', @datePinjam , @dateKembali, '" + labelDenda.Text + "', '" + StatusKembali + "')", conn);
                cmd4.Parameters.Add(new SqlParameter("@datePinjam", dateTimePickerPinjam.Value.Date.ToString("MM/dd/yyyy")));
                cmd4.Parameters.Add(new SqlParameter("@dateKembali", dateTimePickerKembali.Value.Date.ToString("MM/dd/yyyy")));
                cmd4.Parameters.AddWithValue("@image", arr);
                cmd4.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Buku Berhasil Dikembalikan");

                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from tb_peminjaman where Id_pinjam ='" + int.Parse(labelidPinjam.Text) + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                GetData();
            }
        }

        private void textBuku_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void textWaktuPinjam_Click(object sender, EventArgs e)
        {

        }
    }
}
