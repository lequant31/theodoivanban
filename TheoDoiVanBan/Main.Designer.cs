namespace TheoDoiVanBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnInfor = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangeInfor = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDonVi = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAccount = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_CreateJob = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_CongViecChuaNhan = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemImageEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.pageMain = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.BtnInfor,
            this.btnChangeInfor,
            this.btnChangePassword,
            this.BtnDonVi,
            this.BtnAccount,
            this.Btn_CreateJob,
            this.Btn_CongViecChuaNhan});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 14;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemImageEdit1,
            this.repositoryItemImageEdit2});
            this.ribbon.Size = new System.Drawing.Size(686, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // BtnInfor
            // 
            this.BtnInfor.Caption = "Công việc các đội";
            this.BtnInfor.Id = 1;
            this.BtnInfor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnInfor.ImageOptions.Image")));
            this.BtnInfor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnInfor.ImageOptions.LargeImage")));
            this.BtnInfor.Name = "BtnInfor";
            this.BtnInfor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnInfor_ItemClick);
            // 
            // btnChangeInfor
            // 
            this.btnChangeInfor.Caption = "Thay đổi thông tin";
            this.btnChangeInfor.Id = 2;
            this.btnChangeInfor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeInfor.ImageOptions.Image")));
            this.btnChangeInfor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChangeInfor.ImageOptions.LargeImage")));
            this.btnChangeInfor.Name = "btnChangeInfor";
            this.btnChangeInfor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnChangeInfor_ItemClick);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Caption = "Thay đổi mật khẩu";
            this.btnChangePassword.Id = 3;
            this.btnChangePassword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.ImageOptions.Image")));
            this.btnChangePassword.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.ImageOptions.LargeImage")));
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnChangePassword_ItemClick);
            // 
            // BtnDonVi
            // 
            this.BtnDonVi.Caption = "Đơn vị";
            this.BtnDonVi.Id = 10;
            this.BtnDonVi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDonVi.ImageOptions.Image")));
            this.BtnDonVi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnDonVi.ImageOptions.LargeImage")));
            this.BtnDonVi.Name = "BtnDonVi";
            // 
            // BtnAccount
            // 
            this.BtnAccount.Caption = "Tài khoản";
            this.BtnAccount.Id = 11;
            this.BtnAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAccount.ImageOptions.Image")));
            this.BtnAccount.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAccount.ImageOptions.LargeImage")));
            this.BtnAccount.Name = "BtnAccount";
            this.BtnAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAccount_ItemClick);
            // 
            // Btn_CreateJob
            // 
            this.Btn_CreateJob.Caption = "Khởi tạo việc giúp cấp trên";
            this.Btn_CreateJob.Id = 12;
            this.Btn_CreateJob.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CreateJob.ImageOptions.Image")));
            this.Btn_CreateJob.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_CreateJob.ImageOptions.LargeImage")));
            this.Btn_CreateJob.Name = "Btn_CreateJob";
            this.Btn_CreateJob.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_CreateJob_ItemClick);
            // 
            // Btn_CongViecChuaNhan
            // 
            this.Btn_CongViecChuaNhan.Caption = "Nhận và hoàn thành việc";
            this.Btn_CongViecChuaNhan.Id = 13;
            this.Btn_CongViecChuaNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CongViecChuaNhan.ImageOptions.Image")));
            this.Btn_CongViecChuaNhan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_CongViecChuaNhan.ImageOptions.LargeImage")));
            this.Btn_CongViecChuaNhan.Name = "Btn_CongViecChuaNhan";
            this.Btn_CongViecChuaNhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_CongViecChuaNhan_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_CreateJob);
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_CongViecChuaNhan);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnInfor);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnChangeInfor);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnChangePassword);
            this.ribbonPageGroup1.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Edit";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản trị hệ thống";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnDonVi);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnAccount);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // repositoryItemImageEdit2
            // 
            this.repositoryItemImageEdit2.AutoHeight = false;
            this.repositoryItemImageEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit2.Name = "repositoryItemImageEdit2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 425);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(686, 24);
            // 
            // pageMain
            // 
            this.pageMain.Name = "pageMain";
            this.pageMain.Size = new System.Drawing.Size(684, 242);
            this.pageMain.Text = "Main Menu";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageAndTabControlHeader;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 158);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.pageMain;
            this.xtraTabControl1.Size = new System.Drawing.Size(686, 267);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageMain});
            this.xtraTabControl1.CloseButtonClick += new System.EventHandler(this.XtraTabControl1_CloseButtonClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 449);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "Main";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem BtnInfor;
        private DevExpress.XtraBars.BarButtonItem btnChangeInfor;
        private DevExpress.XtraBars.BarButtonItem btnChangePassword;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit2;
        private DevExpress.XtraTab.XtraTabPage pageMain;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraBars.BarButtonItem BtnDonVi;
        private DevExpress.XtraBars.BarButtonItem BtnAccount;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem Btn_CreateJob;
        private DevExpress.XtraBars.BarButtonItem Btn_CongViecChuaNhan;
    }
}