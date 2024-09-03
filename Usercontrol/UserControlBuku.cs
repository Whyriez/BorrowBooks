using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorrowBooks1.Usercontrol
{
    public partial class UserControlBuku : UserControl
    {
        public UserControlBuku()
        {
            InitializeComponent();
        }

        #region Properties;

        private string _Pname;
        private string _Lpenulis;
        private string _Lpenerbit;
        private string _Ltahun;
        private Image _Lgambar;
        private string _Lisbn;
        private string _Lid;

        [Category("Custom Props")]
        public string NamaBuku
        {
            get { return _Pname; }
            set { _Pname = value; labelNama.Text = value; }
        }
        [Category("Custom Props")]
        public string PenulisBuku
        {
            get { return _Lpenulis; }
            set { _Lpenulis = value; labelPenulis.Text = value; }
        }
        [Category("Custom Props")]
        public string PenerbitBuku
        {
            get { return _Lpenerbit; }
            set { _Lpenerbit = value; labelPenerbit.Text = value; }
        }
        [Category("Custom Props")]
        public string TahunTerbit
        {
            get { return _Ltahun; }
            set { _Ltahun = value; labelTahun.Text = value; }
        }
        [Category("Custom Props")]
        public string Isbn
        {
            get { return _Lisbn; }
            set { _Lisbn = value; labelIsbn.Text = value; }
        }
        [Category("Custom Props")]
        public Image GambarBuku
        {
            get { return _Lgambar; }
            set { _Lgambar = value; pictureBox1.Image = value; }
        }

        [Category("Custom Props")]
        public string IDBuku
        {
            get { return _Lid; }
            set { _Lid = value; labelID.Text = value; }
        }


        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControlBuku_Load(object sender, EventArgs e)
        {

        }
    }
}
