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
    public partial class FormBuku : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseBorrowBooks.mdf;Integrated Security=True");
        public FormBuku()
        {
            InitializeComponent();
            
        }
        private void GetData()
        {
            flowLayoutPanel1.Controls.Clear();
            String querry = "SELECT * FROM tb_buku";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                UserControlBuku[] listItem = new UserControlBuku[dtable.Rows.Count];

                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dtable.Rows)
                    {
                        listItem[i] = new UserControlBuku();
                        Byte[] imgData = (byte[])row["gambar_buku"];
                        MemoryStream ms = new MemoryStream(imgData);
                        listItem[i].GambarBuku = System.Drawing.Image.FromStream(ms, false); ;
                        listItem[i].NamaBuku = row["nama_buku"].ToString();
                        listItem[i].PenulisBuku = row["penulis_buku"].ToString();
                        listItem[i].PenerbitBuku = row["penerbit_buku"].ToString();
                        listItem[i].TahunTerbit = row["tahun_terbit"].ToString();
                        listItem[i].Isbn = row["isbn"].ToString();
                        listItem[i].IDBuku = row["Id"].ToString();
                        flowLayoutPanel1.Controls.Add(listItem[i]);

                        listItem[i].Click += new System.EventHandler(editHapus);
                    }
                }



            }
        }

        private void cariData()
        {
            flowLayoutPanel1.Controls.Clear();
            String querry = "SELECT * FROM tb_buku where nama_buku like '"+ textCari.Text +"' AND penulis_buku like '"+ textCari.Text +"' AND penerbit_buku like '"+ textCari.Text +"' AND tahun_terbit like '"+ textCari.Text +"'";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                UserControlBuku[] listItem = new UserControlBuku[dtable.Rows.Count];

                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dtable.Rows)
                    {
                        listItem[i] = new UserControlBuku();
                        Byte[] imgData = (byte[])row["gambar_buku"];
                        MemoryStream ms = new MemoryStream(imgData);
                        listItem[i].GambarBuku = System.Drawing.Image.FromStream(ms, false); ;
                        listItem[i].NamaBuku = row["nama_buku"].ToString();
                        listItem[i].PenulisBuku = row["penulis_buku"].ToString();
                        listItem[i].PenerbitBuku = row["penerbit_buku"].ToString();
                        listItem[i].TahunTerbit = row["tahun_terbit"].ToString();
                        listItem[i].Isbn = row["isbn"].ToString();
                        listItem[i].IDBuku = row["Id"].ToString();
                        flowLayoutPanel1.Controls.Add(listItem[i]);

                        listItem[i].Click += new System.EventHandler(editHapus);
                    }
                }



            }
        }

        void editHapus(object sender, EventArgs e)
        {
            UserControlBuku list = (UserControlBuku)sender;

            textBuku.Text = list.NamaBuku;
            textPenulis.Text = list.PenulisBuku;
            textPenerbit.Text = list.PenerbitBuku;
            textTerbit.Text = list.TahunTerbit;
            textIsbn.Text = list.Isbn;
            textIdBuku.Text = list.IDBuku;
            pictureBox1.Image = list.GambarBuku;
        }

        void Refresh()
        {
            textBuku.Text = "";
            textPenulis.Text = "";
            textPenerbit.Text = "";
            textTerbit.Text = "";
            textIsbn.Text = "";
            textIdBuku.Text = "";
            pictureBox1.Image = null;
        }

        private void FormBuku_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBuku.Text == "" || textPenulis.Text == "" || textPenerbit.Text == "" || textTerbit.Text == "" || textIsbn.Text == "" || pictureBox1.Image == null)
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
               
                SqlCommand cmd = new SqlCommand("update tb_buku set nama_buku = '" + textBuku.Text + "', penulis_buku = '" + textPenulis.Text + "', penerbit_buku = '" + textPenerbit.Text + "', tahun_terbit = '" + textTerbit.Text + "', isbn = '" + textIsbn.Text + "', gambar_buku = @image where Id ='" + int.Parse(textIdBuku.Text) + "'", conn);
                cmd.Parameters.AddWithValue("@image", arr);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Buku Berhasil Diubah");
                GetData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textIdBuku.Text == "")
            {
                MessageBox.Show("Silahkan Pilih Buku Yang Ingin Dihapus");
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from tb_buku where Id ='" + int.Parse(textIdBuku.Text) + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Buku Berhasil Dihapus");
                GetData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBuku.Text == "" || textPenulis.Text == "" || textPenerbit.Text == "" || textTerbit.Text == "" || textIsbn.Text == "" || pictureBox1.Image == null)
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
                SqlCommand cmd4 = new SqlCommand("insert into tb_buku (nama_buku,penulis_buku,penerbit_buku,tahun_terbit,isbn,gambar_buku) values ('" + textBuku.Text + "','" + textPenulis.Text + "', '" + textPenerbit.Text + "', '" + textTerbit.Text + "', '" + textIsbn.Text + "', @image)", conn);
                cmd4.Parameters.AddWithValue("@image", arr);
                cmd4.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Buku Berhasil Ditambahkan");
                GetData();
            }
           
        }

        private void textIdBuku_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTerbit_TextChanged(object sender, EventArgs e)
        {

        }

        private void textIsbn_TextChanged(object sender, EventArgs e)
        {

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

        private void textTerbit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
