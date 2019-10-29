using DevExpress.XtraEditors;
using System;
using System.Linq;
using TheoDoiVanBan.HeThong;

namespace TheoDoiVanBan
{
    public partial class CongViecChuaNhan : DevExpress.XtraEditors.XtraUserControl
    {
        public CongViecChuaNhan()
        {
            InitializeComponent();
        }
        TheoDoiVanBanEntities _TheoDoiVanBanEntities;
        private static CongViecChuaNhan _congViecChuaNhan;
        public static CongViecChuaNhan CCongViecChuaNhan
        {
            get
            {
                if (_congViecChuaNhan == null)
                    _congViecChuaNhan = new CongViecChuaNhan();
                return _congViecChuaNhan;
            }
        }
        private void BtnNhanViec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = (int)GrvCongViecChuaNhan.GetFocusedRowCellValue("Id_tbl_AccountSupport");
            try
            {
                using (_TheoDoiVanBanEntities = new TheoDoiVanBanEntities())
                {
                    var checkreceived = _TheoDoiVanBanEntities.checkreceived(id).FirstOrDefault();
                    if (checkreceived.StatusReceived == false)
                    {
                        _TheoDoiVanBanEntities.UpdateNhanViec(id, DinhDanhAccount.Id_Account, true, DateTime.Now);
                        XtraMessageBox.Show("Đã nhận việc");
                    }
                    else
                    {
                        XtraMessageBox.Show("Công việc đã được nhận");
                    }
                }

            }
            catch (Exception)
            {
                XtraMessageBox.Show("Nhận việc thất bại");
                //throw;
            }
        }

        private void CongViecChuaNhan_Load(object sender, EventArgs e)
        {
            try
            {
                using (_TheoDoiVanBanEntities = new TheoDoiVanBanEntities())
                {
                    var listviecchuanhan = _TheoDoiVanBanEntities.NhanViec(DinhDanhAccount.Id_Account, DinhDanhAccount.Id_DonVi_Tbl_DonVi).ToList();
                    GrcCongViecChuaNhan.DataSource = listviecchuanhan;

                }
            }
            catch (Exception)
            {

                //throw;
                XtraMessageBox.Show("Lỗi kết nối đến server");
            }

        }

        private void GrvCongViecChuaNhan_DoubleClick(object sender, EventArgs e)
        {
            int idcongviec = (int)GrvCongViecChuaNhan.GetFocusedRowCellValue("Id_tbl_AccountSupport");
            int idAccountSupport = (int)GrvCongViecChuaNhan.GetFocusedRowCellValue("Id_AccountTiepNhan");
            HoanThanhCongViec HoanThanh = new HoanThanhCongViec();
            HoanThanh.IdEdit = idcongviec;
            HoanThanh.idAccountSupport = idAccountSupport;
            HoanThanh.ShowDialog();
        }

        private void BtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (_TheoDoiVanBanEntities = new TheoDoiVanBanEntities())
                {
                    var listviecchuanhan = _TheoDoiVanBanEntities.NhanViec(DinhDanhAccount.Id_Account, DinhDanhAccount.Id_DonVi_Tbl_DonVi).ToList();
                    GrcCongViecChuaNhan.DataSource = listviecchuanhan;

                }
            }
            catch (Exception)
            {

                //throw;
                XtraMessageBox.Show("Lỗi kết nối đến server");
            }
        }
    }
}
