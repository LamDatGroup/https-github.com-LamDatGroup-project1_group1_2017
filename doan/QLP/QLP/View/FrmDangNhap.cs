using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLP.Controller;
namespace QLP.View
{
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        QLPhimEntities DB = new QLPhimEntities();
        public bool IsLogin;
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            IsLogin = false;
        }

        private bool LoginuUser()
        {
            try
            {
                DB.spCheckDangNhap(txtMaNV.Text, txtMatKhau.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            if (LoginuUser() == true)
            {
                IsLogin = true;
                MessageBox.Show("Login success!!!");
            }

            else
                MessageBox.Show("Login fail!!!");
        }

            }
}

