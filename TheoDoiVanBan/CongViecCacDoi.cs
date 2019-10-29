using DevExpress.XtraEditors;
using System;
using System.Linq;
using TheoDoiVanBan.HeThong;

namespace TheoDoiVanBan
{
    public partial class CongViecCacDoi : DevExpress.XtraEditors.XtraUserControl
    {
        TheoDoiVanBanEntities _theoDoiVanBanEntities;
        private static CongViecCacDoi _CongViecCacDoi;
        public static CongViecCacDoi UCCongViecCacDoi
        {
            get
            {
                if (_CongViecCacDoi == null)
                    _CongViecCacDoi = new CongViecCacDoi();
                return _CongViecCacDoi;
            }
        }
        public CongViecCacDoi()
        {
            InitializeComponent();
        }
        private void GetViecCuaNhom()
        {
            try
            {
                using (_theoDoiVanBanEntities = new TheoDoiVanBanEntities())
                {
                    var _list = _theoDoiVanBanEntities.GetAllDonViCongViec(DinhDanhAccount.Id_DonVi_Tbl_DonVi, DinhDanhAccount.Id_Account).ToList();
                    GrcQuanLyViecNhom.DataSource = _list;
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Lỗi kết nối đến server");
                //throw;
            }
        }
        private void CongViecCacDoi_Load(object sender, EventArgs e)
        {
            GetViecCuaNhom();
        }

        private void BtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetViecCuaNhom();
        }
    }
}
