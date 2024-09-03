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
    public partial class FormRiwayat : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseBorrowBooks.mdf;Integrated Security=True");
        public FormRiwayat()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            flowLayoutPanel1.Controls.Clear();
            String querry = "SELECT * FROM tb_pengembalian";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                UserControlRiwayat[] listItem = new UserControlRiwayat[dtable.Rows.Count];

                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dtable.Rows)
                    {
                        listItem[i] = new UserControlRiwayat();

                        Byte[] imgData = (byte[])row["profile_image"];
                        MemoryStream ms = new MemoryStream(imgData);
                        listItem[i].Profile = System.Drawing.Image.FromStream(ms, false);
                        listItem[i].NamaMahasiswa = row["Nama_mahasiswa"].ToString();
                        listItem[i].Jurusan = row["Jurusan"].ToString();
                        listItem[i].ProgramStudi = row["Program_studi"].ToString();
                        listItem[i].NamaBuku = row["Nama_buku"].ToString();
                        listItem[i].TanggalPinjam = row["Tgl_pinjam"].ToString();
                        listItem[i].TanggalKembali = row["Tgl_kembali"].ToString();
                        listItem[i].Status = row["Status"].ToString();
                        flowLayoutPanel1.Controls.Add(listItem[i]);
                    }
                }



            }
        }
        private void cariData()
        {
            flowLayoutPanel1.Controls.Clear();
            String querry = "SELECT * FROM tb_pengembalian where Nama_mahasiswa like '"+ textCari.Text +"'";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                UserControlRiwayat[] listItem = new UserControlRiwayat[dtable.Rows.Count];

                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dtable.Rows)
                    {
                        listItem[i] = new UserControlRiwayat();

                        Byte[] imgData = (byte[])row["profile_image"];
                        MemoryStream ms = new MemoryStream(imgData);
                        listItem[i].Profile = System.Drawing.Image.FromStream(ms, false);
                        listItem[i].NamaMahasiswa = row["Nama_mahasiswa"].ToString();
                        listItem[i].Jurusan = row["Jurusan"].ToString();
                        listItem[i].ProgramStudi = row["Program_studi"].ToString();
                        listItem[i].NamaBuku = row["Nama_buku"].ToString();
                        listItem[i].TanggalPinjam = row["Tgl_pinjam"].ToString();
                        listItem[i].TanggalKembali = row["Tgl_kembali"].ToString();
                        listItem[i].Status = row["Status"].ToString();
                        flowLayoutPanel1.Controls.Add(listItem[i]);
                    }
                }



            }
        }

        private void FormRiwayat_Load(object sender, EventArgs e)
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
    }
}
