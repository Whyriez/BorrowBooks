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
    public partial class FormLogin : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseBorrowBooks.mdf;Integrated Security=True");
        public FormLogin()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Username, Password;

            Username = textUsername.Text;
            Password = textPassword.Text;

            try
            {

                String querry = "SELECT * FROM tb_user WHERE username = '" + textUsername.Text + "' AND password = '" + textPassword.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    Username = textUsername.Text;
                    Password = textPassword.Text;

                    LoggedUser.Nama = dtable.Rows[0]["nama"].ToString();
                    Byte[] imgData = (byte[])dtable.Rows[0]["profile_picture"];
                    MemoryStream ms = new MemoryStream(imgData);
                    LoggedUser.Img = Image.FromStream(ms);

                    switch (dtable.Rows[0]["role"].ToString())
                    {
                        case "Admin":
                            {
                                FormHomeAdmin homeAdmin = new FormHomeAdmin();
                                homeAdmin.Show();
                                this.Hide();

                                break;
                            }
                        case "Operator":
                            {
                                FormHomeOperator home = new FormHomeOperator();
                                home.Show();
                                this.Hide();
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }




                }
                else
                {
                    MessageBox.Show("Username Dan Password Salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textUsername.Clear();
                    textPassword.Clear();

                    textUsername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Terjadi Kesalahan Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
