namespace GUI
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.repositoryItemHypertextLabel1 = new DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btn1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuyDinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnDaiLy = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiDaiLy = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuan = new DevExpress.XtraBars.BarButtonItem();
            this.btnMatHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnDonViTinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaoCaoDoanhSo = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaoCaoCongNo = new DevExpress.XtraBars.BarButtonItem();
            this.infoUser = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.tabHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.menuGroup_1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.menuGroup_2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tabQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tabBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tabTroGiup = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemHypertextLabel1
            // 
            this.repositoryItemHypertextLabel1.Name = "repositoryItemHypertextLabel1";
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbon;
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Teal;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnDangNhap,
            this.btn1,
            this.btnDangXuat,
            this.btnQuyDinh,
            this.btnThoat,
            this.btnDoiMatKhau,
            this.btnDaiLy,
            this.btnLoaiDaiLy,
            this.btnQuan,
            this.btnMatHang,
            this.btnDonViTinh,
            this.btnBaoCaoDoanhSo,
            this.btnBaoCaoCongNo,
            this.infoUser,
            this.barEditItem1,
            this.barEditItem2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 29;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.infoUser);
            this.ribbon.PageHeaderItemLinks.Add(this.barEditItem1);
            this.ribbon.PageHeaderItemLinks.Add(this.barEditItem2);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.tabHeThong,
            this.tabQuanLy,
            this.tabBaoCao,
            this.tabTroGiup});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.ribbon.Size = new System.Drawing.Size(966, 146);
            this.ribbon.StatusBar = this.ribbonStatusBar1;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng Nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.Image")));
            this.btnDangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.LargeImage")));
            this.btnDangNhap.LargeWidth = 80;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btn1
            // 
            this.btn1.Caption = "Quy Định";
            this.btn1.Id = 4;
            this.btn1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn1.ImageOptions.Image")));
            this.btn1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn1.ImageOptions.LargeImage")));
            this.btn1.LargeWidth = 70;
            this.btn1.Name = "btn1";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng Xuất";
            this.btnDangXuat.Id = 5;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.LargeImage")));
            this.btnDangXuat.LargeWidth = 80;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnĐangXuat_ItemClick);
            // 
            // btnQuyDinh
            // 
            this.btnQuyDinh.Caption = "Thay Đổi Quy  Định";
            this.btnQuyDinh.Id = 8;
            this.btnQuyDinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuyDinh.ImageOptions.Image")));
            this.btnQuyDinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQuyDinh.ImageOptions.LargeImage")));
            this.btnQuyDinh.LargeWidth = 80;
            this.btnQuyDinh.Name = "btnQuyDinh";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 9;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.LargeWidth = 80;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.Id = 10;
            this.btnDoiMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.Image")));
            this.btnDoiMatKhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.LargeImage")));
            this.btnDoiMatKhau.LargeWidth = 80;
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            // 
            // btnDaiLy
            // 
            this.btnDaiLy.Caption = "Đại Lý";
            this.btnDaiLy.Id = 11;
            this.btnDaiLy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDaiLy.ImageOptions.Image")));
            this.btnDaiLy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDaiLy.ImageOptions.LargeImage")));
            this.btnDaiLy.LargeWidth = 80;
            this.btnDaiLy.Name = "btnDaiLy";
            // 
            // btnLoaiDaiLy
            // 
            this.btnLoaiDaiLy.Caption = "Loại Đại Lý";
            this.btnLoaiDaiLy.Id = 12;
            this.btnLoaiDaiLy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoaiDaiLy.ImageOptions.Image")));
            this.btnLoaiDaiLy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLoaiDaiLy.ImageOptions.LargeImage")));
            this.btnLoaiDaiLy.LargeWidth = 80;
            this.btnLoaiDaiLy.Name = "btnLoaiDaiLy";
            // 
            // btnQuan
            // 
            this.btnQuan.Caption = "Quận";
            this.btnQuan.Id = 13;
            this.btnQuan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuan.ImageOptions.Image")));
            this.btnQuan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQuan.ImageOptions.LargeImage")));
            this.btnQuan.LargeWidth = 80;
            this.btnQuan.Name = "btnQuan";
            // 
            // btnMatHang
            // 
            this.btnMatHang.Caption = "Mặt Hàng";
            this.btnMatHang.Id = 14;
            this.btnMatHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMatHang.ImageOptions.LargeImage")));
            this.btnMatHang.LargeWidth = 80;
            this.btnMatHang.Name = "btnMatHang";
            // 
            // btnDonViTinh
            // 
            this.btnDonViTinh.Caption = "Đơn Vị Tính";
            this.btnDonViTinh.Id = 20;
            this.btnDonViTinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDonViTinh.ImageOptions.Image")));
            this.btnDonViTinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDonViTinh.ImageOptions.LargeImage")));
            this.btnDonViTinh.LargeWidth = 80;
            this.btnDonViTinh.Name = "btnDonViTinh";
            // 
            // btnBaoCaoDoanhSo
            // 
            this.btnBaoCaoDoanhSo.Caption = "Doanh Số";
            this.btnBaoCaoDoanhSo.Id = 21;
            this.btnBaoCaoDoanhSo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoDoanhSo.ImageOptions.Image")));
            this.btnBaoCaoDoanhSo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoDoanhSo.ImageOptions.LargeImage")));
            this.btnBaoCaoDoanhSo.LargeWidth = 80;
            this.btnBaoCaoDoanhSo.Name = "btnBaoCaoDoanhSo";
            // 
            // btnBaoCaoCongNo
            // 
            this.btnBaoCaoCongNo.Caption = "Công Nợ";
            this.btnBaoCaoCongNo.Id = 22;
            this.btnBaoCaoCongNo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoCongNo.ImageOptions.Image")));
            this.btnBaoCaoCongNo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoCongNo.ImageOptions.LargeImage")));
            this.btnBaoCaoCongNo.LargeWidth = 80;
            this.btnBaoCaoCongNo.Name = "btnBaoCaoCongNo";
            // 
            // infoUser
            // 
            this.infoUser.Id = 23;
            this.infoUser.Name = "infoUser";
            this.infoUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.infoUser_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Edit = null;
            this.barEditItem1.Id = 27;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Edit = null;
            this.barEditItem2.Id = 28;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // tabHeThong
            // 
            this.tabHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.menuGroup_1,
            this.menuGroup_2});
            this.tabHeThong.Name = "tabHeThong";
            this.tabHeThong.Text = "Quản Trị Hệ Thống";
            // 
            // menuGroup_1
            // 
            this.menuGroup_1.ItemLinks.Add(this.btnDangNhap);
            this.menuGroup_1.ItemLinks.Add(this.btnDangXuat);
            this.menuGroup_1.ItemLinks.Add(this.btnThoat);
            this.menuGroup_1.Name = "menuGroup_1";
            this.menuGroup_1.Text = "Hệ thống";
            // 
            // menuGroup_2
            // 
            this.menuGroup_2.ItemLinks.Add(this.btnQuyDinh);
            this.menuGroup_2.ItemLinks.Add(this.btnDoiMatKhau);
            this.menuGroup_2.Name = "menuGroup_2";
            this.menuGroup_2.Text = "Thao tác";
            // 
            // tabQuanLy
            // 
            this.tabQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup5});
            this.tabQuanLy.Name = "tabQuanLy";
            this.tabQuanLy.Text = "Thông Tin Đối Tượng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDaiLy);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLoaiDaiLy);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQuan);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Đại lý";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnMatHang);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDonViTinh);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Hàng hóa";
            // 
            // tabBaoCao
            // 
            this.tabBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup6});
            this.tabBaoCao.Name = "tabBaoCao";
            this.tabBaoCao.Text = "Báo Cáo & Thống Kê";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBaoCaoDoanhSo);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnBaoCaoCongNo);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // tabTroGiup
            // 
            this.tabTroGiup.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.tabTroGiup.Name = "tabTroGiup";
            this.tabTroGiup.Text = "Trợ Giúp";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 506);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbon;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(966, 21);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 146);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(966, 360);
            this.pnlMain.TabIndex = 6;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(966, 527);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "QUẢN LÝ ĐẠI LÝ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btn1;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnQuyDinh;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem btnDaiLy;
        private DevExpress.XtraBars.BarButtonItem btnLoaiDaiLy;
        private DevExpress.XtraBars.BarButtonItem btnQuan;
        private DevExpress.XtraBars.BarButtonItem btnMatHang;
        private DevExpress.XtraBars.Ribbon.RibbonPage tabHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup menuGroup_1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup menuGroup_2;
        private DevExpress.XtraBars.Ribbon.RibbonPage tabQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage tabBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage tabTroGiup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem btnDonViTinh;
        private DevExpress.XtraBars.BarButtonItem btnBaoCaoDoanhSo;
        private DevExpress.XtraBars.BarButtonItem btnBaoCaoCongNo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraBars.BarStaticItem infoUser;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel repositoryItemHypertextLabel1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
    }
}