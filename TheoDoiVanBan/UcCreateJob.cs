using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;
using TheoDoiVanBan.HeThong;

namespace TheoDoiVanBan
{
    public partial class UcCreateJob : DevExpress.XtraEditors.XtraUserControl
    {


        TheoDoiVanBanEntities _theoDoiVanBanEntities;
        private static UcCreateJob _UcCreateJob;
        public static UcCreateJob UucCreateJob
        {
            get
            {
                if (_UcCreateJob == null)
                    _UcCreateJob = new UcCreateJob();
                return _UcCreateJob;
            }
        }
        public UcCreateJob()
        {
            InitializeComponent();
        }

        private void GetCreateJob()
        {
            try
            {
                using (_theoDoiVanBanEntities = new TheoDoiVanBanEntities())
                {

                    if (DinhDanhAccount.Level == 3)
                    {
                        var _GetCreateJob = _theoDoiVanBanEntities.GetCreateJob(DinhDanhAccount.Id_Account, DinhDanhAccount.IdParent, DinhDanhAccount.Id_DonVi_Tbl_DonVi).ToList();
                        GrcCreateJob.DataSource = _GetCreateJob;
                    }
                    if (DinhDanhAccount.Level == 2)
                    {
                        var _GetCreateJob = _theoDoiVanBanEntities.GetCreateJobPhoPhong(DinhDanhAccount.Id_Account, DinhDanhAccount.Id_Account, DinhDanhAccount.Id_DonVi_Tbl_DonVi).ToList();
                        GrcCreateJob.DataSource = _GetCreateJob;
                    }
                    if (DinhDanhAccount.Level == 1)
                    {
                        var _GetCreateJob = _theoDoiVanBanEntities.GetCreateJobTruongPhong(DinhDanhAccount.Id_DonVi_Tbl_DonVi).ToList();
                        GrcCreateJob.DataSource = _GetCreateJob;
                    }
                }
            }
            catch (Exception)
            {
                //throw;
                XtraMessageBox.Show("Lỗi kết nối với cơ sở dữ liệu");
            }
        }

        private void BtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            KhoiTaoCongViec frm = new KhoiTaoCongViec();
            frm._Edit = false;
            frm.ShowDialog();

        }

        private void BtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = (int)GrvCreateJob.GetFocusedRowCellValue("Id_CongViec");

            KhoiTaoCongViec frm = new KhoiTaoCongViec();
            frm._Edit = true;
            frm.IdEdit = id;
            frm.ShowDialog();
        }

        private void BtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetCreateJob();
        }

        private void BtnComment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                int id = (int)GrvCreateJob.GetFocusedRowCellValue("Id_CongViec");
                GiaoViec _giaoViec = new GiaoViec();
                _giaoViec.Id_tbl_congviec = id;
                _giaoViec.ShowDialog();

            }
            catch (Exception)
            {

                XtraMessageBox.Show("Kiểm tra lại thông tin đã nhập");
            }

        }

        private void UcTheoDoiVanBanDen_Load(object sender, EventArgs e)
        {
            GetCreateJob();
        }

        private void BtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = (int)GrvCreateJob.GetFocusedRowCellValue("Id_CongViec");
            try
            {
                using (_theoDoiVanBanEntities = new TheoDoiVanBanEntities())
                {
                    var _exits = _theoDoiVanBanEntities.GetOneCongViec(id).FirstOrDefault();
                    if (_exits.StatusForward == true)
                    {
                        XtraMessageBox.Show("Công việc đã được giao.\nKhông thể xóa");
                    }
                    else
                    {
                        _theoDoiVanBanEntities.DeleteCreateJob(id);
                        XtraMessageBox.Show("Xóa thông tin thành công");
                    }

                }
                GetCreateJob();
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Vui lòng xóa ở bảng dưới trước khi xóa ở đây");
            }
        }

        private void GrvTienDoCongViec_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)GrvCreateJob.GetFocusedRowCellValue("Id_CongViec");

            KhoiTaoCongViec frm = new KhoiTaoCongViec();
            frm._Edit = true;
            frm.IdEdit = id;
            frm.ShowDialog();

        }

        private void RepositoryItemHyperLinkEdit1_Click(object sender, EventArgs e)
        {
            string tailieudinhkem = (string)GrvCreateJob.GetFocusedRowCellValue("tailieu");
            if (tailieudinhkem != null)
            {
                //ViewPdf view = new ViewPdf();
                //view.FileNamePdf = (string)grvTienDoCongViec.GetFocusedRowCellValue("tailieu");
                //view.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Không có tài liệu đính kèm");
            }
        }

        private void BtnDeleteYKienGD_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa thông tin?", "Confirmation", MessageBoxButtons.YesNo) !=
                  DialogResult.Yes)

                    return;
                //Guid guid = (Guid)grvYKienGiamDoc.GetFocusedRowCellValue("Id");
                //quanLyCongViecEntities = new QuanLyCongViecEntities();
                //quanLyCongViecEntities.DeleteTheoDoiVanBan(guid);
                //var GetAllTheoDoivanBan = quanLyCongViecEntities.GetAllTheoDoiVanBan(guid).ToList();
                //grcYKienGiamDoc.DataSource = GetAllTheoDoivanBan;
                XtraMessageBox.Show("Xóa thông tin thành công");
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu");
            }
        }

        private void GrvYKienGiamDoc_DoubleClick(object sender, EventArgs e)
        {
            //Guid guid = (Guid)grvYKienGiamDoc.GetFocusedRowCellValue("Id");
            //Guid guidGDVanBanDen = (Guid)grvTienDoCongViec.GetFocusedRowCellValue("Id");
            //try
            //{
            //    //YKienGiamDoc frm = new YKienGiamDoc();
            //    //frm._Edit = true;
            //    //frm.IdEdit = guid;
            //    //frm.IdGDVanBanDen = guidGDVanBanDen;
            //    //frm.ShowDialog();
            //}
            //catch (Exception)
            //{

            //    XtraMessageBox.Show("Lỗi kết nối với cơ sở dữ liệu");
            //}
        }

        private void GrvTienDoCongViec_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void GrvYKienGiamDoc_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs f)
        {
            if (f.Info.IsRowIndicator && f.RowHandle >= 0)
            {
                f.Info.DisplayText = (f.RowHandle + 1).ToString();
            }
        }

        private void GrcCreateJob_Click(object sender, EventArgs e)
        {

            try

            {
                int i = GrvCreateJob.FocusedRowHandle;
                if (i < 0)
                {
                    return;
                }
                int id = (int)GrvCreateJob.GetFocusedRowCellValue("Id_CongViec");

                using (_theoDoiVanBanEntities = new TheoDoiVanBanEntities())
                {

                    var _list = _theoDoiVanBanEntities.GetForwardCreateJob(id).ToList();
                    GrcChuyenVanBan.DataSource = _list;
                }

            }
            catch (Exception)
            {
                XtraMessageBox.Show("Có lỗi xảy ra");
                //throw;
            }
        }
    }
}
