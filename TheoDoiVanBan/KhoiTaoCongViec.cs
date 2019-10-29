using DevExpress.XtraEditors;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TheoDoiVanBan.HeThong;

namespace TheoDoiVanBan
{
    public partial class KhoiTaoCongViec : DevExpress.XtraEditors.XtraForm
    {
        public int IdEdit;
        public bool _Edit = false;
        private int IdNguoikhoitao;
        private int IdNguoiGiaoviec;
        private bool MustReport;

        //private bool HoanThanh;
        //private bool ChuaHoanThanh;
        //private bool DangThucHien;
        //private bool ChuaThucHien;
        //private bool ThucHienCham;
        //private bool KetThucCongViec;
        private int IdLinhVucBanHanh;

        private bool StatusForward;
        private int IdLoaiVanBan;
        private int IdCoquanBanhanh;
        private string patition;
        private string pathfile;
        private TheoDoiVanBanEntities _theoDoiVanBanEntities;

        public KhoiTaoCongViec()
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
            txtSoVanBan.Text = null;

            txtSoGhiSoCongVan.Text = null;
            txtNguoiNhanVanBan.Text = null;
            memoTomTatKetQua.Text = null;
            memoTrichYeuVanBan.Text = null;
            btnTaiLieuDinhKem.Text = null;
            _Edit = false;
        }

        private void AddGDVanBanDen()
        {
            try
            {
                using (_theoDoiVanBanEntities = new TheoDoiVanBanEntities())
                {
                    #region kiểm tra ngày phải hoàn thành

                    if (dateNgayPhaiHoanThanh.EditValue == null)
                    {
                        XtraMessageBox.Show("Phải nhập ngày phải hoàn thành");
                        return;
                    }

                    #endregion kiểm tra ngày phải hoàn thành

                    if (radioPhaiBaoCao.SelectedIndex == 0)
                    {
                        MustReport = true;
                    }
                    if (radioPhaiBaoCao.SelectedIndex == 1)
                    {
                        MustReport = false;
                    }
                    //HoanThanh = checkHoanThanh.Checked;
                    //if (checkHoanThanh.CheckState. == true)
                    //{
                    //    HoanThanh = "Hoàn thành";
                    //}
                    //else
                    //{
                    //    HoanThanh = null;
                    //}
                    //if (checkChuaHoanThanh.Checked == true)
                    //{
                    //    ChuaHoanThanh = "Chưa hoàn thành";
                    //}
                    //else
                    //{
                    //    ChuaHoanThanh = null;
                    //}
                    //if (checkDangThucHien.Checked == true)
                    //{
                    //    DangThucHien = "Đang thực hiện";
                    //}
                    //else
                    //{
                    //    DangThucHien = null;
                    //}
                    //if (checkChuaThucHien.Checked == true)
                    //{
                    //    ChuaThucHien = true;
                    //}
                    //else
                    //{
                    //    ChuaThucHien = false;
                    //}
                    //if (checkThucHienCham.Checked == true)
                    //{
                    //    ThucHienCham = true;
                    //}
                    //else
                    //{
                    //    ThucHienCham = false;
                    //}
                    //if (checkKetThucCongViec.Checked == true)
                    //{
                    //    KetThucCongViec = true;
                    //}
                    //else
                    //{
                    //    KetThucCongViec = false;
                    //}

                    SubtringString();
                    int IdNguoiGiaoViec;
                    if (DinhDanhAccount.Level == 3)
                    {
                        IdNguoiGiaoViec = (int)DinhDanhAccount.IdParent;
                    }
                    else
                    {
                        IdNguoiGiaoViec = (int)DinhDanhAccount.Id_Account;
                    }
                    if (_Edit == false)
                    {
                        _theoDoiVanBanEntities.CreateJob(DinhDanhAccount.Id_Account, IdNguoiGiaoViec, txtSoVanBan.Text, (DateTime?)dateNgayPhatHanh.EditValue, txtSoGhiSoCongVan.Text, (DateTime?)dateNgayNhanVanBan.EditValue,
                            IdCoquanBanhanh, IdLoaiVanBan, IdLinhVucBanHanh, memoCommentGD.Text, memoTrichYeuVanBan.Text, (DateTime?)dateNgayChiDao.EditValue, (DateTime?)dateNgayPhaiHoanThanh.EditValue, MustReport,
                            txtNguoiNhanVanBan.Text, memoTomTatKetQua.Text, "", checkHoanThanh.Checked, checkChuaHoanThanh.Checked, checkDangThucHien.Checked, checkChuaThucHien.Checked, checkThucHienCham.Checked, checkKetThucCongViec.Checked, (DateTime?)DateHoanThanh.EditValue, DateTime.Now, false);

                        XtraMessageBox.Show("Lưu thông tin thành công");
                    }
                    if (_Edit == true && StatusForward != true && IdNguoikhoitao == DinhDanhAccount.Id_Account || IdNguoiGiaoViec == DinhDanhAccount.IdParent)
                    {
                        _theoDoiVanBanEntities.EditCreateJob(IdEdit, txtSoVanBan.Text, (DateTime?)dateNgayPhatHanh.EditValue, txtSoGhiSoCongVan.Text, (DateTime?)dateNgayNhanVanBan.EditValue,
                             IdCoquanBanhanh, IdLoaiVanBan, IdLinhVucBanHanh, memoCommentGD.Text, memoTrichYeuVanBan.Text, (DateTime?)dateNgayChiDao.EditValue, (DateTime?)dateNgayPhaiHoanThanh.EditValue, MustReport,
                             txtNguoiNhanVanBan.Text, memoTomTatKetQua.Text, "", checkHoanThanh.Checked, checkChuaHoanThanh.Checked, checkDangThucHien.Checked, checkChuaThucHien.Checked, checkThucHienCham.Checked, checkKetThucCongViec.Checked, (DateTime?)DateHoanThanh.EditValue, DateTime.Now);
                        XtraMessageBox.Show("Lưu thông tin thành công");
                    }
                    if (_Edit == true && StatusForward == true || IdNguoikhoitao != DinhDanhAccount.Id_Account || IdNguoiGiaoViec != DinhDanhAccount.IdParent)
                    {
                        XtraMessageBox.Show("Công việc không thể sửa, xóa");
                    }
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
                    var _GetOne = _theoDoiVanBanEntities.GetOneCongViec(IdEdit).Single();
                    IdNguoikhoitao = (int)_GetOne.Id_AccountKhoiTao;
                    IdNguoiGiaoviec = (int)_GetOne.Id_AccountGiaoViec;
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
                    DateHoanThanh.EditValue = _GetOne.NgayHoanThanh;
                    StatusForward = (bool)_GetOne.StatusForward;
                    checkHoanThanh.Checked = (bool)_GetOne.HoanThanh;

                    checkChuaHoanThanh.Checked = (bool)_GetOne.ChuaHoanThanh;

                    checkDangThucHien.Checked = (bool)_GetOne.DangThucHien;

                    checkChuaThucHien.Checked = (bool)_GetOne.ChuaThucHien;

                    checkThucHienCham.Checked = (bool)_GetOne.ThucHienCham;

                    checkKetThucCongViec.Checked = (bool)_GetOne.KetThucCongViec;

                    memoTomTatKetQua.EditValue = _GetOne.TomTatKetQua;
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