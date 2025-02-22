﻿using System;
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
    public partial class UserControlPinjamBuku : UserControl
    {
        public UserControlPinjamBuku()
        {
            InitializeComponent();
        }

        #region Properties;

        private string _Pname;
        private string _Ljurusan;
        private string _Lstudi;
        private string _Lbuku;
        private Image _Lgambar;
        private string _Lpinjam;
        private string _Lid;

        [Category("Custom Props")]
        public string NamaMahasiswa
        {
            get { return _Pname; }
            set { _Pname = value; labelNama.Text = value; }
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
            set { _Lstudi = value; labelStudi.Text = value; }
        }
        [Category("Custom Props")]
        public string NamaBuku
        {
            get { return _Lbuku; }
            set { _Lbuku = value; labelBuku.Text = value; }
        }
        [Category("Custom Props")]
        public string TanggalPinjam
        {
            get { return _Lpinjam; }
            set { _Lpinjam = value; labelPinjam.Text = value; }
        }
        [Category("Custom Props")]
        public Image Profile
        {
            get { return _Lgambar; }
            set { _Lgambar = value; pictureBox1.Image = value; }
        }

        [Category("Custom Props")]
        public string IdPinjam
        {
            get { return _Lid; }
            set { _Lid = value; labelId.Text = value; }
        }


        #endregion

        private void UserControlPinjamBuku_Load(object sender, EventArgs e)
        {

        }
    }
}
