
using QuanLyCafe_FormNew.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe_FormNew
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void BT_DangNhap_Click(object sender, EventArgs e)
        {
            string userName = Accout_txt.Text;
            string passWord = Password_txt.Text;
            if (Logins(userName,passWord))
            {
                QuanLyQuanCafe main = new QuanLyQuanCafe();
                if (KiemTraChuois("AD*", Accout_txt.Text))
                {
                    main.EnableAdmin = true;
                    main.EnableKH = true;
                }
                else
                {
                    main.EnableKH = true;
                }
                this.Hide();
                main.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập. Vui lòng nhập lại!!!", "Thông báo",MessageBoxButtons.OK);
            }
            Accout_txt.Clear();
            Password_txt.Clear();
        }

        bool Logins(string userName, string passWord)
        {
            if (KiemTraChuois("NV*", Accout_txt.Text) || KiemTraChuois("AD*",Accout_txt.Text))
            {
                return AccoutDAO.Instance.LoginNV(userName, passWord);
            }
            if(KiemTraChuois("KH*",Accout_txt.Text))
            {
                return AccoutDAO.Instance.LoginKH(userName, passWord);
            }
            else
            {
                return false;
            }
        }
        public bool KiemTraChuois(string mau, string chuoi)
        {
            Regex regex = new Regex(mau);
            return regex.IsMatch(chuoi);
        }
        public Guna.UI2.WinForms.Guna2Button khachVangLai()
        {
            return guna2Button1;
        }
        public void guna2Button1_Click(object sender, EventArgs e)
        {
            QuanLyQuanCafe main = new QuanLyQuanCafe();
            this.Hide();
            main.ShowDialog();
            this.Show();
            //main.EnableButton2 = true;
        }
    }
}
