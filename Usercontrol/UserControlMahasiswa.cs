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
    public partial class UserControlMahasiswa : UserControl
    {
        public UserControlMahasiswa()
        {
            InitializeComponent();
        }

        #region Properties;

        private string _Pname;
        private string _Lnim;
        private string _Ljurusan;
        private string _Lstudi;
        private Image _Lgambar;
        private string _Lid;

        [Category("Custom Props")]
        public string Nim
        {
            get { return _Lnim; }
            set { _Lnim = value; labelNim.Text = value; }
        }
        [Category("Custom Props")]
        public string NamaMahasiswa
        {
            get { return _Pname; }
            set { _Pname = value; labelNim.Text = value; }
        }
        [Category("Custom Props")]
        public string Jurusan
        {
            get { return _Ljurusan; }
            set { _Ljurusan = value; labelJurusan.Text = value; }
        }
        [Category("Custom Props")]
        public string ProgramStudi
        {
            get { return _Lstudi; }
            set { _Lstudi = value; labelProdi.Text = value; }
        }
        [Category("Custom Props")]
        public Image Profile
        {
            get { return _Lgambar; }
            set { _Lgambar = value; pictureBox1.Image = value; }
        }

        [Category("Custom Props")]
        public string IDMahasiswa
        {
            get { return _Lid; }
            set { _Lid = value; labelId.Text = value; }
        }


        #endregion

        private void UserControlMahasiswa_Load(object sender, EventArgs e)
        {

        }
    }
}
