using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe_FormNew
{
    public partial class QuanLyQuanCafe : Form
    {
        public QuanLyQuanCafe()
        {
            InitializeComponent();
        }
        public bool EnableKH { get ; set; }
        public bool EnableAdmin { get; set; }
        private void QuanLyQuanCafe_Load(object sender, EventArgs e)
        {
            quanLyChung2.Visible = false;
            taiKhoan1.Visible = false;
            admin1.Visible = false;
            BT_QLChung.PerformClick();

            BT_Admin.Enabled = EnableAdmin;
            BT_TTTK.Enabled = EnableKH;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_QLChung_Click(object sender, EventArgs e)
        {
            quanLyChung2.Visible = true;
            quanLyChung2.BringToFront();
        }
        private void BT_TTTK_Click(object sender, EventArgs e)
        {
            taiKhoan1.Visible = true;
            taiKhoan1.BringToFront();
        }
        private void BT_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_Admin_Click(object sender, EventArgs e)
        {
            admin1.Visible = true;
            admin1.BringToFront();
        }
        
    }
}
