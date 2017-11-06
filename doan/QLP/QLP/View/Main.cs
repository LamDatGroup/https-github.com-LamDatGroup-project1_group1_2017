using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLP.View;

namespace QLP
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string user;
        public static string idLogin; 
        public Main()
        {
            InitializeComponent();
            DisEndMenuLogin(true);
        }
        public void skins ()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Office 2010 Green";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            skins();
        }
        
        public void DisEndMenuLogin(bool e)
        {

            btnDangNhap.Enabled = e;
            btnDoiMatKhau.Enabled = !e;
            btnDangXuat.Enabled = !e;
            btnNguoiDung.Enabled = !e;
            btnThoat.Enabled = !e;
            btnThôngTin.Enabled = !e;
            btnDoiMatKhau.Enabled = !e;
            pgGiaoDien.Enabled = !e;
            btnNhanVien.Enabled = !e;
            btnKhachHang.Enabled = !e;
            btnPhim.Enabled = !e;
            btnPhong.Enabled = !e;
        }
        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ?", " Thông Báo ", MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDangNhap login = null;
            Check_DangNhap:
            if (login == null || login.IsDisposed)
                login = new FrmDangNhap();
            if (login.ShowDialog() == DialogResult.OK )
            {
                if (login.txtMaNV.Text == "")
                {
                    XtraMessageBox.Show("Hay nhap Ten Dang Nhap !! ");
                    goto Check_DangNhap;
                }
                if (login.txtMatKhau.Text == "")
                {
                    XtraMessageBox.Show("Hay nhap Mat Khau !! ");
                    goto Check_DangNhap;
                }
                if (login.IsLogin == true)
                {
                    DisEndMenuLogin(false);
                }
                string check = "";
                user = login.txtMaNV.Text;
                //Gọi hàm SHA256 để mã hóa mật khẩu
                string pass = Model.UserControl.SHA256(login.txtMatKhau.Text);
                //check = Controller.LoginCtrl.CheckDangNhap(user, pass);
                //if (check == "")
                //{
                //    XtraMessageBox.Show("Đăng nhập thất bại !! Kiểm tra lại Username và Password ");
                //    goto Check_DangNhap;
                //}
                //else
                //{
                //    DisEndMenuLogin(false, idLogin);
                //}

            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn muốn đăng xuất ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DisEndMenuLogin(true);
                btnDangNhap_ItemClick(sender, e);
            }
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmQuanLyNhanVien frm = FrmQuanLyNhanVien();
            frm.Text = "Quản lý nhân viên ";
            frm.ShowDialog();
        }
    }
}
