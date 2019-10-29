using DevExpress.XtraEditors;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TheoDoiVanBan.HeThong;

namespace TheoDoiVanBan
{
    public partial class HoanThanhCongViec : DevExpress.XtraEditors.XtraForm
    {
        public int IdEdit;
        public int idAccountSupport;
        public bool _Edit = false;
        private bool MustReport;
        private string HoanThanh;
        private string ChuaHoanThanh;
        private string DangThucHien;
        private string ChuaThucHien;
        private string ThucHienCham;
        private bool KetThucCongViec;
        private int IdLinhVucBanHanh;
        private bool StatusForward;
        private int IdLoaiVanBan;
        private int IdCoquanBanhanh;
        private string patition;
        private string pathfile;
        private TheoDoiVanBanEntities _theoDoiVanBanEntities;

        public HoanThanhCongViec()
        {
            InitializeComponent();
        }

        private void GetAllItem()
        {
            try
            {
                using (_theoDoiVanBanEntities = new TheoDoiVanBanEntities())
                {
                    var _GetAllCoQuanBanHanh = _theoDoiVanBanEntities.GetAllCoQuanVaDonVi().ToList();
                    var _GetAllLoaiVanBan = _theoDoiVanBanEntities.GetAllLoaiVanBan().ToList();
                    var _GetAllLinhVucVanBan = _theoDoiVanBanEntities.GetAllLinhVucBanHanh().ToList();

                    SearchCoQuanBanHanh.Properties.DataSource = _GetAllCoQuanBanHanh;
                    SearchCoQuanBanHanh.Properties.DisplayMember = "TenCoQuan";
                    SearchCoQuanBanHanh.Properties.ValueMember = "Id";
                    //SearchCoQuanBanHanh.EditValue =Enum.IdCoQuanbanHanh;

                    SearchLoaiVanBan.Properties.DataSource = _GetAllLoaiVanBan;
                    SearchLoaiVanBan.Properties.DisplayMember = "NameVanBan";
                    SearchLoaiVanBan.Properties.ValueMember = "Id";
                    //SearchLoaiVanBan.EditValue = Enum.IdLoaiVanBan;

                    searchLinhVucVanBan.Properties.DataSource = _GetAllLinhVucVanBan;
                    searchLinhVucVanBan.Properties.DisplayMember = "NameLinhVuc";
                    searchLinhVucVanBan.Properties.ValueMember = "Id";
                    //searchLinhVucVanBan.EditValue = Enum.IdLinhVucBanHanh;
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu");
            }
        }

        private void SubtringString()
        {
            string _pathfile = btnTaiLieuDinhKem.Text.Trim();
            if (_pathfile != "")
            {
                if (_pathfile != ":\\")
                {
                    patition = _pathfile.Substring(0, 1).Trim();
                    pathfile = _pathfile.Substring(3, _pathfile.Length - 3).Trim();
                }
                return;
            }
            return;
        }

        private void GetAllNull()
        {

            memoTomTatKetQua.Text = null;
        }

        private void AddGDVanBanDen()
        {
            try
            {
                using (_theoDoiVanBanEntities = new TheoDoiVanBanEntities())
                {

                    if (radioPhaiBaoCao.SelectedIndex == 0)
                    {
                        MustReport = true;
                    }
                    if (radioPhaiBaoCao.SelectedIndex == 1)
                    {
                        MustReport = false;
                    }
                    if (checkKetThucCongViec.SelectedIndex == 0)
                    {
                        KetThucCongViec = true;
                    }
                    else
                    {
                        KetThucCongViec = false;
                    }

                    SubtringString();
                    _theoDoiVanBanEntities.HoanThanhCongViec(IdEdit, (DateTime)DateHoanThanh.EditValue, memoTomTatKetQua.Text, DateTime.Now, KetThucCongViec);
                }
            }
            catch (Exception ex)
            {
                //throw;
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void GetOneGDVanBanDen()
        {
            try
            {
                using (_theoDoiVanBanEntities = new TheoDoiVanBanEntities())
                {
                    var _GetOne = _theoDoiVanBanEntities.NhanViecChiTiet(DinhDanhAccount.Id_DonVi_Tbl_DonVi, idAccountSupport, IdEdit).SingleOrDefault();
                    dateNgayNhanVanBan.EditValue = _GetOne.NgayNhanVanBan;
                    SearchCoQuanBanHanh.EditValue = _GetOne.Id_CoQuanBanHanh;
                    SearchLoaiVanBan.EditValue = _GetOne.Id_loaiVanBan;
                    searchLinhVucVanBan.EditValue = _GetOne.Id_LinhVucVanBan;
                    txtSoVanBan.EditValue = _GetOne.SoVanBan;
                    dateNgayPhatHanh.EditValue = _GetOne.NgayPhatHanh;
                    txtSoGhiSoCongVan.EditValue = _GetOne.SoGhiSoCongVan;
                    memoTrichYeuVanBan.EditValue = _GetOne.NoiDungVanBan;
                    memoCommentGD.EditValue = _GetOne.CommentLanhDao;
                    dateNgayChiDao.EditValue = _GetOne.NgayChiDao;
                    dateNgayPhaiHoanThanh.EditValue = _GetOne.NgayPhaiHoanThanh;
                    radioPhaiBaoCao.EditValue = _GetOne.PhaiBaoCao;
                    txtNguoiNhanVanBan.EditValue = _GetOne.NguoiNhanVanBan;
                    //btnTaiLieuDinhKem.EditValue = _GetOne.Patition + ":\\" + _GetOne.TaiLIeuDinhKem;
                    DateHoanThanh.EditValue = _GetOne.NgayHoanThanhSupport;
                    StatusForward = (bool)_GetOne.StatusForward;
                    checkKetThucCongViec.EditValue = _GetOne.StatusFinish;
                    memoTomTatKetQua.EditValue = _GetOne.KetQuaCongViec;
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Lỗi kết nối với cơ sở dữ liệu");
            }
        }

        private void TienDoCongViec_Load(object sender, EventArgs e)
        {

            GetAllItem();
            GetOneGDVanBanDen();
            if (_Edit == true)
            {
                GetOneGDVanBanDen();
            }
        }

        private void BtnTaiLieuDinhKem_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "Files pdf|*.pdf*" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(ofd.FileName);
                    btnTaiLieuDinhKem.Text = fi.FullName;
                }
            }
        }

        private void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddGDVanBanDen();
            GetAllNull();
        }

        private void BtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetAllNull();
        }

        private void BtnReNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetAllNull();
        }

        private void BtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (_theoDoiVanBanEntities = new TheoDoiVanBanEntities())
                {
                    if (StatusForward != true)
                    {
                        _theoDoiVanBanEntities.DeleteCreateJob(IdEdit);
                        XtraMessageBox.Show("Xóa thông tin thành công");
                    }
                    if (StatusForward == true)
                    {
                        XtraMessageBox.Show("Công việc đã được giao không thể sửa, xóa");
                    }
                }
                GetAllNull();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Thông tin không có trong cơ sở dữ liệu");
            }
        }

    }
}