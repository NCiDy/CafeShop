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

namespace QuanLyCafe_FormNew.All_User_Controlls
{
    public partial class Admin : UserControl
    {
        private object provider;

        public Admin()
        {
            InitializeComponent();
        }
        void LoadAccoutList()
        {
            string query = "EXEC dbo.USP_GetAccoutByUserName @userName";
            DataProvider provider = new DataProvider();
            dataGridView_DSTK.DataSource = provider.ExecuteQuery(query, new object[] { "" });
        }

        //Tab Tài khoản
        private void BT_DSNV_Click(object sender, EventArgs e)
        {
            string query = "SELECT	MANV AS N'Tài khoản NV', PASSNV AS N'Mật khẩu' FROM LOGINNV";
            DataProvider provider = new DataProvider();
            dataGridView_DSTK.DataSource = provider.ExecuteQuery(query);
        }

        private void BT_DSKH_Click(object sender, EventArgs e)
        {
            string query = "SELECT	MAKH AS N'Tài khoản KH', PASSKH AS N'Mật khẩu' FROM LOGINKH";
            DataProvider provider = new DataProvider();
            dataGridView_DSTK.DataSource = provider.ExecuteQuery(query);
        }
        public bool KiemTraChuoi(string mau, string chuoi)
        {
            Regex regex = new Regex(mau);
            return regex.IsMatch(chuoi);
        }
        private void BT_TimTK_Click(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            if (KiemTraChuoi("NV*", TimTK_txt.Text))
            {
                string query = "EXEC dbo.USP_GetAccoutByUserName @userName";
                dataGridView_DSTK.DataSource = provider.ExecuteQuery(query, new object[] { TimTK_txt.Text });
            }
            else
            {
                string queryy = "EXEC dbo.USP_GettAccoutByUserNameKH @userName";
                dataGridView_DSTK.DataSource = provider.ExecuteQuery(queryy, new object[] { TimTK_txt.Text });
            }
        }

        //Tab Hóa đơn
        private void BT_XemHD_Click(object sender, EventArgs e)
        {
            string query = "select MAHDBH as N'Mã hóa đơn', KHACHHANG.TENKH AS N'Tên khách hàng' , NGAYHDBH as N'Ngày xuất hóa đơn', TONGTIEN as N'Tổng tiền', GIAMGIA as N'Giảm giá', NHANVIEN.TENNV as N'Nhân viên' from HDBANHANG, NHANVIEN, KHACHHANG WHERE HDBANHANG.MAKH = KHACHHANG.MAKH AND HDBANHANG.MANV = NHANVIEN.MANV";
            DataProvider provider = new DataProvider();
            dataGridView_DSHD.DataSource = provider.ExecuteQuery(query);
        }

        private void BT_TimHD_Click(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            string query = "EXEC dbo.USP_GettAccoutByUserNameHD @userName";
            dataGridView_DSHD.DataSource = provider.ExecuteQuery(query, new object[] { TimHD_txt.Text });
        }


        //Tab Menu
        private void BT_XemMenu_Click(object sender, EventArgs e)
        {
            string query = "SELECT MASP AS 'Mã sản phẩm', TENSP as N'Tên nước', TENLSP as N'Loại nước', GIASP as N'Giá' FROM SANPHAM, LOAISANPHAM WHERE LOAISANPHAM.MALSP = SANPHAM.MALSP";
            DataProvider provider = new DataProvider();
            dataGridView_DSMenu.DataSource = provider.ExecuteQuery(query);
        }

        private void BT_TimMenu_Click(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            string query = "EXEC dbo.USP_GettAccoutByUserNameMenu @userName";
            dataGridView_DSMenu.DataSource = provider.ExecuteQuery(query, new object[] { TimMon_txt.Text });

        }

        //Tab Khách hàng
        private void BT_XemKH_Click(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            string query = "SELECT MAKH as N'Mã khách hàng', TENKH as N'Tên khách hàng', DIACHI as N'Địa chỉ', SDT as 'Số điện thoại', TENLKH as N'Loại Khách', DIEMTL as N'Điểm tích lũy' FROM KHACHHANG,LOAIKHACHHANG WHERE KHACHHANG.MALKH = LOAIKHACHHANG.MALKH";
            dataGridView_DSKH.DataSource = provider.ExecuteQuery(query);
        }

        private void BT_TimKH_Click(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            string query = "EXEC dbo.USP_GettAccoutByUserNameDSKH @userName";
            dataGridView_DSKH.DataSource = provider.ExecuteQuery(query, new object[] { TimKH_txt.Text });
        }

        //Tab Nhân viên
        private void BT_XemNV_Click(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            string query = "SELECT MANV as N'Mã nhân viên', TENNV as N'Tên nhân viên', GIOITINH as N'Giới tính', CHUCVU as N'Chức vụ', NGAYVAOLAM as N'Ngày vào làm', DIACHI as N'Địa chỉ', SDT as N'Số điện thoại' from NHANVIEN";
            dataGridView_DSNV.DataSource = provider.ExecuteQuery(query);
        }

        private void BT_TimNV_Click(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            string query = "EXEC dbo.USP_GettAccoutByUserNameDSNV @userName";
            dataGridView_DSNV.DataSource = provider.ExecuteQuery(query, new object[] { TimNV_txt.Text });
        }
    }
}
