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
    public partial class UserControlOperator : UserControl
    {
        public UserControlOperator()
        {
            InitializeComponent();
        }

        #region Properties;

        private string _Pname;
        private string _Luser;
        private string _Lrole;
        private string _Lid;
        private Image _Lgambar;

        [Category("Custom Props")]
        public string Username
        {
            get { return _Luser; }
            set { _Luser = value; labelUser.Text = value; }
        }
        [Category("Custom Props")]
        public string NamaLengkap
        {
            get { return _Pname; }
            set { _Pname = value; labelNama.Text = value; }
        }
        [Category("Custom Props")]
        public string UserRole
        {
            get { return _Lrole; }
            set { _Lrole = value; labelRole.Text = value; }
        }

        [Category("Custom Props")]
        public Image Profile
        {
            get { return _Lgambar; }
            set { _Lgambar = value; pictureBox1.Image = value; }
        }

        [Category("Custom Props")]
        public string ID
        {
            get { return _Lid; }
            set { _Lid = value; labelID.Text = value; }
        }


        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserControlOperator_Load(object sender, EventArgs e)
        {

        }
    }
}
