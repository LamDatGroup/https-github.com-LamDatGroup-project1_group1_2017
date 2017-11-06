namespace QLP
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnThôngTin = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhim = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhong = new DevExpress.XtraBars.BarButtonItem();
            this.btnNguoiDung = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuongDan = new DevExpress.XtraBars.BarButtonItem();
            this.btn = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiaVe = new DevExpress.XtraBars.BarButtonItem();
            this.PgHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pgGiaoDien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pgDatVe = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgDatVe = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pgDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.NhanVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Phim = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.KhachHang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Phong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.TroGiup = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDangNhap,
            this.btnThôngTin,
            this.btnDangXuat,
            this.btnThoat,
            this.btnDoiMatKhau,
            this.skinRibbonGalleryBarItem1,
            this.btnNhanVien,
            this.btnPhim,
            this.btnKhachHang,
            this.btnPhong,
            this.btnNguoiDung,
            this.btnHuongDan,
            this.btn,
            this.btnGiaVe});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 26;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.PgHeThong,
            this.pgDatVe,
            this.pgDanhMuc,
            this.TroGiup});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1166, 143);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng Nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.LargeGlyph = global::QLP.Properties.Resources.secrecy_icon;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnThôngTin
            // 
            this.btnThôngTin.Caption = "Thông Tin";
            this.btnThôngTin.Id = 3;
            this.btnThôngTin.LargeGlyph = global::QLP.Properties.Resources.Status_dialog_information_icon;
            this.btnThôngTin.Name = "btnThôngTin";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng Xuất";
            this.btnDangXuat.Id = 8;
            this.btnDangXuat.LargeGlyph = global::QLP.Properties.Resources.Log_Out_icon;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 9;
            this.btnThoat.LargeGlyph = global::QLP.Properties.Resources.Actions_system_shutdown_icon;
            this.btnThoat.Name = "btnThoat";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi mật khẩu";
            this.btnDoiMatKhau.Id = 10;
            this.btnDoiMatKhau.LargeGlyph = global::QLP.Properties.Resources.Apps_preferences_desktop_user_password_icon;
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 14;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân Viên";
            this.btnNhanVien.Id = 15;
            this.btnNhanVien.LargeGlyph = global::QLP.Properties.Resources.Manager_icon;
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnPhim
            // 
            this.btnPhim.Caption = "Phim";
            this.btnPhim.Id = 16;
            this.btnPhim.LargeGlyph = global::QLP.Properties.Resources.Videos_icon;
            this.btnPhim.Name = "btnPhim";
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Caption = "Khách Hàng";
            this.btnKhachHang.Id = 17;
            this.btnKhachHang.LargeGlyph = global::QLP.Properties.Resources.African_Boss_icon;
            this.btnKhachHang.Name = "btnKhachHang";
            // 
            // btnPhong
            // 
            this.btnPhong.Caption = "Phòng";
            this.btnPhong.Id = 18;
            this.btnPhong.LargeGlyph = global::QLP.Properties.Resources.Household_Room_icon;
            this.btnPhong.Name = "btnPhong";
            // 
            // btnNguoiDung
            // 
            this.btnNguoiDung.Caption = "Phân Loại Người Dùng";
            this.btnNguoiDung.Id = 21;
            this.btnNguoiDung.LargeGlyph = global::QLP.Properties.Resources.User_Group_icon;
            this.btnNguoiDung.Name = "btnNguoiDung";
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.Caption = "Hướng dẫn sử dụng";
            this.btnHuongDan.Id = 22;
            this.btnHuongDan.Name = "btnHuongDan";
            // 
            // btn
            // 
            this.btn.Caption = "barButtonItem1";
            this.btn.Id = 24;
            this.btn.Name = "btn";
            // 
            // btnGiaVe
            // 
            this.btnGiaVe.Caption = "barButtonItem2";
            this.btnGiaVe.Id = 25;
            this.btnGiaVe.Name = "btnGiaVe";
            // 
            // PgHeThong
            // 
            this.PgHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.pgGiaoDien});
            this.PgHeThong.Name = "PgHeThong";
            this.PgHeThong.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangNhap, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDoiMatKhau);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNguoiDung);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Đăng Nhập";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnThôngTin);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnThoat);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Thông Tin";
            // 
            // pgGiaoDien
            // 
            this.pgGiaoDien.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.pgGiaoDien.Name = "pgGiaoDien";
            this.pgGiaoDien.Text = "Giao Diện";
            // 
            // pgDatVe
            // 
            this.pgDatVe.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgDatVe});
            this.pgDatVe.Name = "pgDatVe";
            this.pgDatVe.Text = "Đặt Vé";
            // 
            // rpgDatVe
            // 
            this.rpgDatVe.KeyTip = "K";
            this.rpgDatVe.Name = "rpgDatVe";
            this.rpgDatVe.Text = "Đặt Vé";
            // 
            // pgDanhMuc
            // 
            this.pgDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.NhanVien,
            this.Phim,
            this.KhachHang,
            this.Phong});
            this.pgDanhMuc.Name = "pgDanhMuc";
            this.pgDanhMuc.Text = "Quản Lý";
            // 
            // NhanVien
            // 
            this.NhanVien.ItemLinks.Add(this.btnNhanVien);
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Text = "Nhân Viên";
            // 
            // Phim
            // 
            this.Phim.ItemLinks.Add(this.btnPhim);
            this.Phim.Name = "Phim";
            this.Phim.Text = "Phim";
            // 
            // KhachHang
            // 
            this.KhachHang.ItemLinks.Add(this.btnKhachHang);
            this.KhachHang.Name = "KhachHang";
            this.KhachHang.Text = "Khách Hàng";
            // 
            // Phong
            // 
            this.Phong.ItemLinks.Add(this.btnPhong);
            this.Phong.Name = "Phong";
            this.Phong.Text = "Phòng";
            // 
            // TroGiup
            // 
            this.TroGiup.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.TroGiup.Name = "TroGiup";
            this.TroGiup.Text = "Trợ Giúp";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnHuongDan);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnGiaVe);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1166, 466);
            this.dataGridView1.TabIndex = 1;
            // 
            // Main
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 609);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Main";
            this.Ribbon = this.ribbonControl1;
            this.Text = "QUẢN LÝ RẠP PHIM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage PgHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnThôngTin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage pgDanhMuc;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgGiaoDien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup NhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Phim;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup KhachHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Phong;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnPhim;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private DevExpress.XtraBars.BarButtonItem btnPhong;
        private DevExpress.XtraBars.BarButtonItem btnNguoiDung;
        private DevExpress.XtraBars.Ribbon.RibbonPage TroGiup;
        private DevExpress.XtraBars.BarButtonItem btnHuongDan;
        private DevExpress.XtraBars.BarButtonItem btn;
        private DevExpress.XtraBars.Ribbon.RibbonPage pgDatVe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnGiaVe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDatVe;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

