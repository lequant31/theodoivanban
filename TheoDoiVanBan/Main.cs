using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.Windows.Forms;
using TheoDoiVanBan.HeThong;

namespace TheoDoiVanBan
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        TheoDoiVanBanEntities _theoDoiVanBanEntities;
        int tabPageIndex = 0;
        bool NotTabExist(string tabName)
        {
            for (int i = 0; i < xtraTabControl1.TabPages.Count; i++)
            {
                if (xtraTabControl1.TabPages[i].Text == tabName)
                    return false;
            }
            return true;
        }
        int TabPageIndex(string tabName)
        {
            for (int i = 0; i < xtraTabControl1.TabPages.Count; i++)
            {
                if (xtraTabControl1.TabPages[i].Text == tabName)
                    return i;
            }
            return -1;
        }
        public void LoadForm(UserControl ctl, string tabName)
        {
            try
            {
                if (NotTabExist(tabName))
                {
                    ctl.Dock = DockStyle.Fill;
                    DevExpress.XtraTab.XtraTabPage xtra = new DevExpress.XtraTab.XtraTabPage();
                    xtra.Text = tabName;
                    xtra.Controls.Add(ctl);
                    xtra.Padding = new System.Windows.Forms.Padding(2);
                    xtraTabControl1.TabPages.Add(xtra);
                }

                tabPageIndex = TabPageIndex(tabName);
                if (tabPageIndex == -1)
                    xtraTabControl1.SelectedTabPageIndex = 0;
                else
                {
                    try
                    {
                        xtraTabControl1.SelectedTabPageIndex = tabPageIndex;
                    }
                    catch
                    {
                        XtraMessageBox.Show("Có lỗi xảy ra");
                    }
                }

            }
            catch
            {
                XtraMessageBox.Show("Có lỗi xảy ra");
            }

        }
        public Main()
        {
            InitializeComponent();
        }

        private void BtnChangeInfor_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangeInfor _changeInfor = new ChangeInfor();
            _changeInfor.ShowDialog();

        }

        private void BtnChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangePass _changePass = new ChangePass();
            _changePass.ShowDialog();
        }
        private void GetInforAccount()
        {
            try
            {
                using (_theoDoiVanBanEntities = new TheoDoiVanBanEntities())
                {
                    //var infor = _theoDoiVanBanEntities.GetInfor(Login.ID_USER).FirstOrDefault();
                    //BtnInfor.Caption = infor.UserName;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            GetInforAccount();
            if (DinhDanhAccount.Level == 3)
            {
                BtnInfor.Visibility = BarItemVisibility.Never;
            }
            else
            {
                BtnInfor.Visibility = BarItemVisibility.Always;
            }
        }

        private void XtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            try
            {
                XtraTabPage xtra = (XtraTabPage)(e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs).Page;
                if (xtra.Name != "pageMain")
                {
                    xtraTabControl1.TabPages.Remove(xtra);
                    xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
                    foreach (Control ctl in xtra.Controls)
                    {
                        ctl.Dispose();
                    }
                    xtra.Dispose();
                }
            }
            catch { XtraMessageBox.Show("Có lỗi xảy ra"); }
        }

        private void BtnVanBanMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadForm(new UcTheoDoiVanBanDen(), "Văn bản mới");
        }

        private void BtnAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadForm(new ManagementAccount(), "Quản lý tài khoản");
        }

        private void Btn_CreateJob_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadForm(new UcCreateJob(), "Khởi tạo công việc giúp cấp trên");
        }

        private void Btn_CongViecChuaNhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadForm(new CongViecChuaNhan(), "Nhận và hoàn thành việc");
        }

        private void BtnInfor_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadForm(new CongViecCacDoi(), "Công việc các đội");
        }
    }
}