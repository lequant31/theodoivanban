﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheoDoiVanBan
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TheoDoiVanBanEntities : DbContext
    {
        public TheoDoiVanBanEntities()
            : base("name=TheoDoiVanBanEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Account> tbl_Account { get; set; }
        public virtual DbSet<tbl_AccountSupport> tbl_AccountSupport { get; set; }
        public virtual DbSet<tbl_CongViec> tbl_CongViec { get; set; }
        public virtual DbSet<tbl_CoQuanBanHanh> tbl_CoQuanBanHanh { get; set; }
        public virtual DbSet<tbl_Donvi> tbl_Donvi { get; set; }
        public virtual DbSet<tbl_LinhVucBanHanh> tbl_LinhVucBanHanh { get; set; }
        public virtual DbSet<tbl_LoaiVanBan> tbl_LoaiVanBan { get; set; }
        public virtual DbSet<ViewDonViVaCoQuan> ViewDonViVaCoQuan { get; set; }
    
        public virtual int AddLinhVucBanHanh(string codeLinhVuc, string nameLinhVuc)
        {
            var codeLinhVucParameter = codeLinhVuc != null ?
                new ObjectParameter("CodeLinhVuc", codeLinhVuc) :
                new ObjectParameter("CodeLinhVuc", typeof(string));
    
            var nameLinhVucParameter = nameLinhVuc != null ?
                new ObjectParameter("NameLinhVuc", nameLinhVuc) :
                new ObjectParameter("NameLinhVuc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddLinhVucBanHanh", codeLinhVucParameter, nameLinhVucParameter);
        }
    
        public virtual int AddLoaiVanBan(string codeVanBan, string nameVanBan)
        {
            var codeVanBanParameter = codeVanBan != null ?
                new ObjectParameter("CodeVanBan", codeVanBan) :
                new ObjectParameter("CodeVanBan", typeof(string));
    
            var nameVanBanParameter = nameVanBan != null ?
                new ObjectParameter("NameVanBan", nameVanBan) :
                new ObjectParameter("NameVanBan", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddLoaiVanBan", codeVanBanParameter, nameVanBanParameter);
        }
    
        public virtual ObjectResult<checkreceived_Result> checkreceived(Nullable<int> id_tbl_AccountSupport)
        {
            var id_tbl_AccountSupportParameter = id_tbl_AccountSupport.HasValue ?
                new ObjectParameter("Id_tbl_AccountSupport", id_tbl_AccountSupport) :
                new ObjectParameter("Id_tbl_AccountSupport", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<checkreceived_Result>("checkreceived", id_tbl_AccountSupportParameter);
        }
    
        public virtual int CreateJob(Nullable<int> id_AccountKhoiTao, Nullable<int> id_AccountGiaoViec, string soVanBan, Nullable<System.DateTime> ngayPhatHanh, string soGhiSoCongVan, Nullable<System.DateTime> ngayNhanVanBan, Nullable<int> id_CoQuanBanHanh, Nullable<int> id_loaiVanBan, Nullable<int> id_LinhVucVanBan, string commentLanhDao, string noiDungVanBan, Nullable<System.DateTime> ngayChiDao, Nullable<System.DateTime> ngayPhaiHoanThanh, Nullable<bool> phaiBaoCao, string nguoiNhanVanBan, string tomTatKetQua, string taiLieuDinhKem, Nullable<bool> hoanThanh, Nullable<bool> chuaHoanThanh, Nullable<bool> dangThucHien, Nullable<bool> chuaThucHien, Nullable<bool> thucHienCham, Nullable<bool> ketThucCongViec, Nullable<System.DateTime> ngayHoanThanh, Nullable<System.DateTime> ngayTaoCongViec, Nullable<bool> statusForward)
        {
            var id_AccountKhoiTaoParameter = id_AccountKhoiTao.HasValue ?
                new ObjectParameter("Id_AccountKhoiTao", id_AccountKhoiTao) :
                new ObjectParameter("Id_AccountKhoiTao", typeof(int));
    
            var id_AccountGiaoViecParameter = id_AccountGiaoViec.HasValue ?
                new ObjectParameter("Id_AccountGiaoViec", id_AccountGiaoViec) :
                new ObjectParameter("Id_AccountGiaoViec", typeof(int));
    
            var soVanBanParameter = soVanBan != null ?
                new ObjectParameter("SoVanBan", soVanBan) :
                new ObjectParameter("SoVanBan", typeof(string));
    
            var ngayPhatHanhParameter = ngayPhatHanh.HasValue ?
                new ObjectParameter("NgayPhatHanh", ngayPhatHanh) :
                new ObjectParameter("NgayPhatHanh", typeof(System.DateTime));
    
            var soGhiSoCongVanParameter = soGhiSoCongVan != null ?
                new ObjectParameter("SoGhiSoCongVan", soGhiSoCongVan) :
                new ObjectParameter("SoGhiSoCongVan", typeof(string));
    
            var ngayNhanVanBanParameter = ngayNhanVanBan.HasValue ?
                new ObjectParameter("NgayNhanVanBan", ngayNhanVanBan) :
                new ObjectParameter("NgayNhanVanBan", typeof(System.DateTime));
    
            var id_CoQuanBanHanhParameter = id_CoQuanBanHanh.HasValue ?
                new ObjectParameter("Id_CoQuanBanHanh", id_CoQuanBanHanh) :
                new ObjectParameter("Id_CoQuanBanHanh", typeof(int));
    
            var id_loaiVanBanParameter = id_loaiVanBan.HasValue ?
                new ObjectParameter("Id_loaiVanBan", id_loaiVanBan) :
                new ObjectParameter("Id_loaiVanBan", typeof(int));
    
            var id_LinhVucVanBanParameter = id_LinhVucVanBan.HasValue ?
                new ObjectParameter("Id_LinhVucVanBan", id_LinhVucVanBan) :
                new ObjectParameter("Id_LinhVucVanBan", typeof(int));
    
            var commentLanhDaoParameter = commentLanhDao != null ?
                new ObjectParameter("CommentLanhDao", commentLanhDao) :
                new ObjectParameter("CommentLanhDao", typeof(string));
    
            var noiDungVanBanParameter = noiDungVanBan != null ?
                new ObjectParameter("NoiDungVanBan", noiDungVanBan) :
                new ObjectParameter("NoiDungVanBan", typeof(string));
    
            var ngayChiDaoParameter = ngayChiDao.HasValue ?
                new ObjectParameter("NgayChiDao", ngayChiDao) :
                new ObjectParameter("NgayChiDao", typeof(System.DateTime));
    
            var ngayPhaiHoanThanhParameter = ngayPhaiHoanThanh.HasValue ?
                new ObjectParameter("NgayPhaiHoanThanh", ngayPhaiHoanThanh) :
                new ObjectParameter("NgayPhaiHoanThanh", typeof(System.DateTime));
    
            var phaiBaoCaoParameter = phaiBaoCao.HasValue ?
                new ObjectParameter("PhaiBaoCao", phaiBaoCao) :
                new ObjectParameter("PhaiBaoCao", typeof(bool));
    
            var nguoiNhanVanBanParameter = nguoiNhanVanBan != null ?
                new ObjectParameter("NguoiNhanVanBan", nguoiNhanVanBan) :
                new ObjectParameter("NguoiNhanVanBan", typeof(string));
    
            var tomTatKetQuaParameter = tomTatKetQua != null ?
                new ObjectParameter("TomTatKetQua", tomTatKetQua) :
                new ObjectParameter("TomTatKetQua", typeof(string));
    
            var taiLieuDinhKemParameter = taiLieuDinhKem != null ?
                new ObjectParameter("TaiLieuDinhKem", taiLieuDinhKem) :
                new ObjectParameter("TaiLieuDinhKem", typeof(string));
    
            var hoanThanhParameter = hoanThanh.HasValue ?
                new ObjectParameter("HoanThanh", hoanThanh) :
                new ObjectParameter("HoanThanh", typeof(bool));
    
            var chuaHoanThanhParameter = chuaHoanThanh.HasValue ?
                new ObjectParameter("ChuaHoanThanh", chuaHoanThanh) :
                new ObjectParameter("ChuaHoanThanh", typeof(bool));
    
            var dangThucHienParameter = dangThucHien.HasValue ?
                new ObjectParameter("DangThucHien", dangThucHien) :
                new ObjectParameter("DangThucHien", typeof(bool));
    
            var chuaThucHienParameter = chuaThucHien.HasValue ?
                new ObjectParameter("ChuaThucHien", chuaThucHien) :
                new ObjectParameter("ChuaThucHien", typeof(bool));
    
            var thucHienChamParameter = thucHienCham.HasValue ?
                new ObjectParameter("ThucHienCham", thucHienCham) :
                new ObjectParameter("ThucHienCham", typeof(bool));
    
            var ketThucCongViecParameter = ketThucCongViec.HasValue ?
                new ObjectParameter("KetThucCongViec", ketThucCongViec) :
                new ObjectParameter("KetThucCongViec", typeof(bool));
    
            var ngayHoanThanhParameter = ngayHoanThanh.HasValue ?
                new ObjectParameter("NgayHoanThanh", ngayHoanThanh) :
                new ObjectParameter("NgayHoanThanh", typeof(System.DateTime));
    
            var ngayTaoCongViecParameter = ngayTaoCongViec.HasValue ?
                new ObjectParameter("NgayTaoCongViec", ngayTaoCongViec) :
                new ObjectParameter("NgayTaoCongViec", typeof(System.DateTime));
    
            var statusForwardParameter = statusForward.HasValue ?
                new ObjectParameter("StatusForward", statusForward) :
                new ObjectParameter("StatusForward", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateJob", id_AccountKhoiTaoParameter, id_AccountGiaoViecParameter, soVanBanParameter, ngayPhatHanhParameter, soGhiSoCongVanParameter, ngayNhanVanBanParameter, id_CoQuanBanHanhParameter, id_loaiVanBanParameter, id_LinhVucVanBanParameter, commentLanhDaoParameter, noiDungVanBanParameter, ngayChiDaoParameter, ngayPhaiHoanThanhParameter, phaiBaoCaoParameter, nguoiNhanVanBanParameter, tomTatKetQuaParameter, taiLieuDinhKemParameter, hoanThanhParameter, chuaHoanThanhParameter, dangThucHienParameter, chuaThucHienParameter, thucHienChamParameter, ketThucCongViecParameter, ngayHoanThanhParameter, ngayTaoCongViecParameter, statusForwardParameter);
        }
    
        public virtual int DeleteCreateJob(Nullable<int> id_congviec)
        {
            var id_congviecParameter = id_congviec.HasValue ?
                new ObjectParameter("Id_congviec", id_congviec) :
                new ObjectParameter("Id_congviec", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteCreateJob", id_congviecParameter);
        }
    
        public virtual int DeleteLinhVucBanHanh(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteLinhVucBanHanh", idParameter);
        }
    
        public virtual int DeleteLoaiVanBan(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteLoaiVanBan", idParameter);
        }
    
        public virtual int EditCreateJob(Nullable<int> id_tbl_congviec, string soVanBan, Nullable<System.DateTime> ngayPhatHanh, string soGhiSoCongVan, Nullable<System.DateTime> ngayNhanVanBan, Nullable<int> id_CoQuanBanHanh, Nullable<int> id_loaiVanBan, Nullable<int> id_LinhVucVanBan, string commentLanhDao, string noiDungVanBan, Nullable<System.DateTime> ngayChiDao, Nullable<System.DateTime> ngayPhaiHoanThanh, Nullable<bool> phaiBaoCao, string nguoiNhanVanBan, string tomTatKetQua, string taiLieuDinhKem, Nullable<bool> hoanThanh, Nullable<bool> chuaHoanThanh, Nullable<bool> dangThucHien, Nullable<bool> chuaThucHien, Nullable<bool> thucHienCham, Nullable<bool> ketThucCongViec, Nullable<System.DateTime> ngayHoanThanh, Nullable<System.DateTime> ngaySuaCongViec)
        {
            var id_tbl_congviecParameter = id_tbl_congviec.HasValue ?
                new ObjectParameter("Id_tbl_congviec", id_tbl_congviec) :
                new ObjectParameter("Id_tbl_congviec", typeof(int));
    
            var soVanBanParameter = soVanBan != null ?
                new ObjectParameter("SoVanBan", soVanBan) :
                new ObjectParameter("SoVanBan", typeof(string));
    
            var ngayPhatHanhParameter = ngayPhatHanh.HasValue ?
                new ObjectParameter("NgayPhatHanh", ngayPhatHanh) :
                new ObjectParameter("NgayPhatHanh", typeof(System.DateTime));
    
            var soGhiSoCongVanParameter = soGhiSoCongVan != null ?
                new ObjectParameter("SoGhiSoCongVan", soGhiSoCongVan) :
                new ObjectParameter("SoGhiSoCongVan", typeof(string));
    
            var ngayNhanVanBanParameter = ngayNhanVanBan.HasValue ?
                new ObjectParameter("NgayNhanVanBan", ngayNhanVanBan) :
                new ObjectParameter("NgayNhanVanBan", typeof(System.DateTime));
    
            var id_CoQuanBanHanhParameter = id_CoQuanBanHanh.HasValue ?
                new ObjectParameter("Id_CoQuanBanHanh", id_CoQuanBanHanh) :
                new ObjectParameter("Id_CoQuanBanHanh", typeof(int));
    
            var id_loaiVanBanParameter = id_loaiVanBan.HasValue ?
                new ObjectParameter("Id_loaiVanBan", id_loaiVanBan) :
                new ObjectParameter("Id_loaiVanBan", typeof(int));
    
            var id_LinhVucVanBanParameter = id_LinhVucVanBan.HasValue ?
                new ObjectParameter("Id_LinhVucVanBan", id_LinhVucVanBan) :
                new ObjectParameter("Id_LinhVucVanBan", typeof(int));
    
            var commentLanhDaoParameter = commentLanhDao != null ?
                new ObjectParameter("CommentLanhDao", commentLanhDao) :
                new ObjectParameter("CommentLanhDao", typeof(string));
    
            var noiDungVanBanParameter = noiDungVanBan != null ?
                new ObjectParameter("NoiDungVanBan", noiDungVanBan) :
                new ObjectParameter("NoiDungVanBan", typeof(string));
    
            var ngayChiDaoParameter = ngayChiDao.HasValue ?
                new ObjectParameter("NgayChiDao", ngayChiDao) :
                new ObjectParameter("NgayChiDao", typeof(System.DateTime));
    
            var ngayPhaiHoanThanhParameter = ngayPhaiHoanThanh.HasValue ?
                new ObjectParameter("NgayPhaiHoanThanh", ngayPhaiHoanThanh) :
                new ObjectParameter("NgayPhaiHoanThanh", typeof(System.DateTime));
    
            var phaiBaoCaoParameter = phaiBaoCao.HasValue ?
                new ObjectParameter("PhaiBaoCao", phaiBaoCao) :
                new ObjectParameter("PhaiBaoCao", typeof(bool));
    
            var nguoiNhanVanBanParameter = nguoiNhanVanBan != null ?
                new ObjectParameter("NguoiNhanVanBan", nguoiNhanVanBan) :
                new ObjectParameter("NguoiNhanVanBan", typeof(string));
    
            var tomTatKetQuaParameter = tomTatKetQua != null ?
                new ObjectParameter("TomTatKetQua", tomTatKetQua) :
                new ObjectParameter("TomTatKetQua", typeof(string));
    
            var taiLieuDinhKemParameter = taiLieuDinhKem != null ?
                new ObjectParameter("TaiLieuDinhKem", taiLieuDinhKem) :
                new ObjectParameter("TaiLieuDinhKem", typeof(string));
    
            var hoanThanhParameter = hoanThanh.HasValue ?
                new ObjectParameter("HoanThanh", hoanThanh) :
                new ObjectParameter("HoanThanh", typeof(bool));
    
            var chuaHoanThanhParameter = chuaHoanThanh.HasValue ?
                new ObjectParameter("ChuaHoanThanh", chuaHoanThanh) :
                new ObjectParameter("ChuaHoanThanh", typeof(bool));
    
            var dangThucHienParameter = dangThucHien.HasValue ?
                new ObjectParameter("DangThucHien", dangThucHien) :
                new ObjectParameter("DangThucHien", typeof(bool));
    
            var chuaThucHienParameter = chuaThucHien.HasValue ?
                new ObjectParameter("ChuaThucHien", chuaThucHien) :
                new ObjectParameter("ChuaThucHien", typeof(bool));
    
            var thucHienChamParameter = thucHienCham.HasValue ?
                new ObjectParameter("ThucHienCham", thucHienCham) :
                new ObjectParameter("ThucHienCham", typeof(bool));
    
            var ketThucCongViecParameter = ketThucCongViec.HasValue ?
                new ObjectParameter("KetThucCongViec", ketThucCongViec) :
                new ObjectParameter("KetThucCongViec", typeof(bool));
    
            var ngayHoanThanhParameter = ngayHoanThanh.HasValue ?
                new ObjectParameter("NgayHoanThanh", ngayHoanThanh) :
                new ObjectParameter("NgayHoanThanh", typeof(System.DateTime));
    
            var ngaySuaCongViecParameter = ngaySuaCongViec.HasValue ?
                new ObjectParameter("NgaySuaCongViec", ngaySuaCongViec) :
                new ObjectParameter("NgaySuaCongViec", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EditCreateJob", id_tbl_congviecParameter, soVanBanParameter, ngayPhatHanhParameter, soGhiSoCongVanParameter, ngayNhanVanBanParameter, id_CoQuanBanHanhParameter, id_loaiVanBanParameter, id_LinhVucVanBanParameter, commentLanhDaoParameter, noiDungVanBanParameter, ngayChiDaoParameter, ngayPhaiHoanThanhParameter, phaiBaoCaoParameter, nguoiNhanVanBanParameter, tomTatKetQuaParameter, taiLieuDinhKemParameter, hoanThanhParameter, chuaHoanThanhParameter, dangThucHienParameter, chuaThucHienParameter, thucHienChamParameter, ketThucCongViecParameter, ngayHoanThanhParameter, ngaySuaCongViecParameter);
        }
    
        public virtual int EditLinhVucBanHanh(Nullable<int> id, string codeLinhVuc, string nameLinhVuc)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var codeLinhVucParameter = codeLinhVuc != null ?
                new ObjectParameter("CodeLinhVuc", codeLinhVuc) :
                new ObjectParameter("CodeLinhVuc", typeof(string));
    
            var nameLinhVucParameter = nameLinhVuc != null ?
                new ObjectParameter("NameLinhVuc", nameLinhVuc) :
                new ObjectParameter("NameLinhVuc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EditLinhVucBanHanh", idParameter, codeLinhVucParameter, nameLinhVucParameter);
        }
    
        public virtual int EditLoaiVanBan(Nullable<int> id, string codeVanBan, string nameVanBan)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var codeVanBanParameter = codeVanBan != null ?
                new ObjectParameter("CodeVanBan", codeVanBan) :
                new ObjectParameter("CodeVanBan", typeof(string));
    
            var nameVanBanParameter = nameVanBan != null ?
                new ObjectParameter("NameVanBan", nameVanBan) :
                new ObjectParameter("NameVanBan", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EditLoaiVanBan", idParameter, codeVanBanParameter, nameVanBanParameter);
        }
    
        public virtual int EnableStatusforward(Nullable<int> id_CongViec)
        {
            var id_CongViecParameter = id_CongViec.HasValue ?
                new ObjectParameter("Id_CongViec", id_CongViec) :
                new ObjectParameter("Id_CongViec", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EnableStatusforward", id_CongViecParameter);
        }
    
        public virtual ObjectResult<GetAccountInGroup_Result> GetAccountInGroup(Nullable<int> topLevelParent, Nullable<int> idDonVi)
        {
            var topLevelParentParameter = topLevelParent.HasValue ?
                new ObjectParameter("TopLevelParent", topLevelParent) :
                new ObjectParameter("TopLevelParent", typeof(int));
    
            var idDonViParameter = idDonVi.HasValue ?
                new ObjectParameter("IdDonVi", idDonVi) :
                new ObjectParameter("IdDonVi", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAccountInGroup_Result>("GetAccountInGroup", topLevelParentParameter, idDonViParameter);
        }
    
        public virtual ObjectResult<GetAllAccountSupport_OneJob_Result> GetAllAccountSupport_OneJob(Nullable<int> id_congviec)
        {
            var id_congviecParameter = id_congviec.HasValue ?
                new ObjectParameter("Id_congviec", id_congviec) :
                new ObjectParameter("Id_congviec", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllAccountSupport_OneJob_Result>("GetAllAccountSupport_OneJob", id_congviecParameter);
        }
    
        public virtual ObjectResult<GetAllCoQuanVaDonVi_Result> GetAllCoQuanVaDonVi()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllCoQuanVaDonVi_Result>("GetAllCoQuanVaDonVi");
        }
    
        public virtual ObjectResult<GetAllLinhVucBanHanh_Result> GetAllLinhVucBanHanh()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllLinhVucBanHanh_Result>("GetAllLinhVucBanHanh");
        }
    
        public virtual ObjectResult<GetAllLoaiVanBan_Result> GetAllLoaiVanBan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllLoaiVanBan_Result>("GetAllLoaiVanBan");
        }
    
        public virtual ObjectResult<GetCreateJob_Result> GetCreateJob(Nullable<int> id_AccountKhoiTao, Nullable<int> id_NguoiGiaoViec, Nullable<int> id_donvi)
        {
            var id_AccountKhoiTaoParameter = id_AccountKhoiTao.HasValue ?
                new ObjectParameter("Id_AccountKhoiTao", id_AccountKhoiTao) :
                new ObjectParameter("Id_AccountKhoiTao", typeof(int));
    
            var id_NguoiGiaoViecParameter = id_NguoiGiaoViec.HasValue ?
                new ObjectParameter("Id_NguoiGiaoViec", id_NguoiGiaoViec) :
                new ObjectParameter("Id_NguoiGiaoViec", typeof(int));
    
            var id_donviParameter = id_donvi.HasValue ?
                new ObjectParameter("Id_donvi", id_donvi) :
                new ObjectParameter("Id_donvi", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCreateJob_Result>("GetCreateJob", id_AccountKhoiTaoParameter, id_NguoiGiaoViecParameter, id_donviParameter);
        }
    
        public virtual ObjectResult<GetCreateJobPhoPhong_Result> GetCreateJobPhoPhong(Nullable<int> id_AccountKhoiTao, Nullable<int> id_NguoiGiaoViec, Nullable<int> id_donvi)
        {
            var id_AccountKhoiTaoParameter = id_AccountKhoiTao.HasValue ?
                new ObjectParameter("Id_AccountKhoiTao", id_AccountKhoiTao) :
                new ObjectParameter("Id_AccountKhoiTao", typeof(int));
    
            var id_NguoiGiaoViecParameter = id_NguoiGiaoViec.HasValue ?
                new ObjectParameter("Id_NguoiGiaoViec", id_NguoiGiaoViec) :
                new ObjectParameter("Id_NguoiGiaoViec", typeof(int));
    
            var id_donviParameter = id_donvi.HasValue ?
                new ObjectParameter("Id_donvi", id_donvi) :
                new ObjectParameter("Id_donvi", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCreateJobPhoPhong_Result>("GetCreateJobPhoPhong", id_AccountKhoiTaoParameter, id_NguoiGiaoViecParameter, id_donviParameter);
        }
    
        public virtual ObjectResult<GetCreateJobTruongPhong_Result> GetCreateJobTruongPhong(Nullable<int> id_donvi)
        {
            var id_donviParameter = id_donvi.HasValue ?
                new ObjectParameter("Id_donvi", id_donvi) :
                new ObjectParameter("Id_donvi", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCreateJobTruongPhong_Result>("GetCreateJobTruongPhong", id_donviParameter);
        }
    
        public virtual ObjectResult<GetForwardCreateJob_Result> GetForwardCreateJob(Nullable<int> id_tbl_congviec)
        {
            var id_tbl_congviecParameter = id_tbl_congviec.HasValue ?
                new ObjectParameter("Id_tbl_congviec", id_tbl_congviec) :
                new ObjectParameter("Id_tbl_congviec", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetForwardCreateJob_Result>("GetForwardCreateJob", id_tbl_congviecParameter);
        }
    
        public virtual ObjectResult<GetInfor_Result> GetInfor(Nullable<int> id_User)
        {
            var id_UserParameter = id_User.HasValue ?
                new ObjectParameter("Id_User", id_User) :
                new ObjectParameter("Id_User", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetInfor_Result>("GetInfor", id_UserParameter);
        }
    
        public virtual ObjectResult<GetOneCongViec_Result> GetOneCongViec(Nullable<int> id_conviec)
        {
            var id_conviecParameter = id_conviec.HasValue ?
                new ObjectParameter("Id_conviec", id_conviec) :
                new ObjectParameter("Id_conviec", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetOneCongViec_Result>("GetOneCongViec", id_conviecParameter);
        }
    
        public virtual int GiaoViecChinh(Nullable<int> id_tbl_CongViec, Nullable<int> id_Account, Nullable<System.DateTime> ngayChuyenDen)
        {
            var id_tbl_CongViecParameter = id_tbl_CongViec.HasValue ?
                new ObjectParameter("Id_tbl_CongViec", id_tbl_CongViec) :
                new ObjectParameter("Id_tbl_CongViec", typeof(int));
    
            var id_AccountParameter = id_Account.HasValue ?
                new ObjectParameter("Id_Account", id_Account) :
                new ObjectParameter("Id_Account", typeof(int));
    
            var ngayChuyenDenParameter = ngayChuyenDen.HasValue ?
                new ObjectParameter("NgayChuyenDen", ngayChuyenDen) :
                new ObjectParameter("NgayChuyenDen", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GiaoViecChinh", id_tbl_CongViecParameter, id_AccountParameter, ngayChuyenDenParameter);
        }
    
        public virtual int GiaoViecHoTro(Nullable<int> id_tbl_CongViec, Nullable<int> id_Account, Nullable<System.DateTime> ngayChuyenDen)
        {
            var id_tbl_CongViecParameter = id_tbl_CongViec.HasValue ?
                new ObjectParameter("Id_tbl_CongViec", id_tbl_CongViec) :
                new ObjectParameter("Id_tbl_CongViec", typeof(int));
    
            var id_AccountParameter = id_Account.HasValue ?
                new ObjectParameter("Id_Account", id_Account) :
                new ObjectParameter("Id_Account", typeof(int));
    
            var ngayChuyenDenParameter = ngayChuyenDen.HasValue ?
                new ObjectParameter("NgayChuyenDen", ngayChuyenDen) :
                new ObjectParameter("NgayChuyenDen", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GiaoViecHoTro", id_tbl_CongViecParameter, id_AccountParameter, ngayChuyenDenParameter);
        }
    
        public virtual int HoanThanhCongViec(Nullable<int> id_tbl_AccountSupport, Nullable<System.DateTime> ngayHoanThanhSupport, string ketQuaCongViec, Nullable<System.DateTime> ngaySua, Nullable<bool> statusFinish)
        {
            var id_tbl_AccountSupportParameter = id_tbl_AccountSupport.HasValue ?
                new ObjectParameter("Id_tbl_AccountSupport", id_tbl_AccountSupport) :
                new ObjectParameter("Id_tbl_AccountSupport", typeof(int));
    
            var ngayHoanThanhSupportParameter = ngayHoanThanhSupport.HasValue ?
                new ObjectParameter("NgayHoanThanhSupport", ngayHoanThanhSupport) :
                new ObjectParameter("NgayHoanThanhSupport", typeof(System.DateTime));
    
            var ketQuaCongViecParameter = ketQuaCongViec != null ?
                new ObjectParameter("KetQuaCongViec", ketQuaCongViec) :
                new ObjectParameter("KetQuaCongViec", typeof(string));
    
            var ngaySuaParameter = ngaySua.HasValue ?
                new ObjectParameter("NgaySua", ngaySua) :
                new ObjectParameter("NgaySua", typeof(System.DateTime));
    
            var statusFinishParameter = statusFinish.HasValue ?
                new ObjectParameter("StatusFinish", statusFinish) :
                new ObjectParameter("StatusFinish", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("HoanThanhCongViec", id_tbl_AccountSupportParameter, ngayHoanThanhSupportParameter, ketQuaCongViecParameter, ngaySuaParameter, statusFinishParameter);
        }
    
        public virtual ObjectResult<login_Result> login(Nullable<int> id_donvi, string username, string password)
        {
            var id_donviParameter = id_donvi.HasValue ?
                new ObjectParameter("Id_donvi", id_donvi) :
                new ObjectParameter("Id_donvi", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<login_Result>("login", id_donviParameter, usernameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<NhanViec_Result> NhanViec(Nullable<int> id_AccountSupport, Nullable<int> idDonvi)
        {
            var id_AccountSupportParameter = id_AccountSupport.HasValue ?
                new ObjectParameter("Id_AccountSupport", id_AccountSupport) :
                new ObjectParameter("Id_AccountSupport", typeof(int));
    
            var idDonviParameter = idDonvi.HasValue ?
                new ObjectParameter("idDonvi", idDonvi) :
                new ObjectParameter("idDonvi", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NhanViec_Result>("NhanViec", id_AccountSupportParameter, idDonviParameter);
        }
    
        public virtual ObjectResult<NhanViecChiTiet_Result> NhanViecChiTiet(Nullable<int> id_tbl_donvi, Nullable<int> id_AccountSupport, Nullable<int> id_btl_congviec)
        {
            var id_tbl_donviParameter = id_tbl_donvi.HasValue ?
                new ObjectParameter("Id_tbl_donvi", id_tbl_donvi) :
                new ObjectParameter("Id_tbl_donvi", typeof(int));
    
            var id_AccountSupportParameter = id_AccountSupport.HasValue ?
                new ObjectParameter("Id_AccountSupport", id_AccountSupport) :
                new ObjectParameter("Id_AccountSupport", typeof(int));
    
            var id_btl_congviecParameter = id_btl_congviec.HasValue ?
                new ObjectParameter("Id_btl_congviec", id_btl_congviec) :
                new ObjectParameter("Id_btl_congviec", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NhanViecChiTiet_Result>("NhanViecChiTiet", id_tbl_donviParameter, id_AccountSupportParameter, id_btl_congviecParameter);
        }
    
        public virtual ObjectResult<QuanlyViecNhom_Result> QuanlyViecNhom(Nullable<int> id_tbl_donvi, Nullable<int> id_Account)
        {
            var id_tbl_donviParameter = id_tbl_donvi.HasValue ?
                new ObjectParameter("Id_tbl_donvi", id_tbl_donvi) :
                new ObjectParameter("Id_tbl_donvi", typeof(int));
    
            var id_AccountParameter = id_Account.HasValue ?
                new ObjectParameter("Id_Account", id_Account) :
                new ObjectParameter("Id_Account", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<QuanlyViecNhom_Result>("QuanlyViecNhom", id_tbl_donviParameter, id_AccountParameter);
        }
    
        public virtual ObjectResult<QuanlyViecNhomChiTiet_Result> QuanlyViecNhomChiTiet(Nullable<int> id_tbl_donvi, Nullable<int> id_Account, Nullable<int> id_tbl_congviec)
        {
            var id_tbl_donviParameter = id_tbl_donvi.HasValue ?
                new ObjectParameter("Id_tbl_donvi", id_tbl_donvi) :
                new ObjectParameter("Id_tbl_donvi", typeof(int));
    
            var id_AccountParameter = id_Account.HasValue ?
                new ObjectParameter("Id_Account", id_Account) :
                new ObjectParameter("Id_Account", typeof(int));
    
            var id_tbl_congviecParameter = id_tbl_congviec.HasValue ?
                new ObjectParameter("Id_tbl_congviec", id_tbl_congviec) :
                new ObjectParameter("Id_tbl_congviec", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<QuanlyViecNhomChiTiet_Result>("QuanlyViecNhomChiTiet", id_tbl_donviParameter, id_AccountParameter, id_tbl_congviecParameter);
        }
    
        public virtual int UpdateGiaiQuyetViecDaNhan(Nullable<int> id_tblAccountSupport, Nullable<System.DateTime> ngayHoanThanh, string ketQuaCongViec, Nullable<System.DateTime> ngaySua)
        {
            var id_tblAccountSupportParameter = id_tblAccountSupport.HasValue ?
                new ObjectParameter("Id_tblAccountSupport", id_tblAccountSupport) :
                new ObjectParameter("Id_tblAccountSupport", typeof(int));
    
            var ngayHoanThanhParameter = ngayHoanThanh.HasValue ?
                new ObjectParameter("NgayHoanThanh", ngayHoanThanh) :
                new ObjectParameter("NgayHoanThanh", typeof(System.DateTime));
    
            var ketQuaCongViecParameter = ketQuaCongViec != null ?
                new ObjectParameter("KetQuaCongViec", ketQuaCongViec) :
                new ObjectParameter("KetQuaCongViec", typeof(string));
    
            var ngaySuaParameter = ngaySua.HasValue ?
                new ObjectParameter("NgaySua", ngaySua) :
                new ObjectParameter("NgaySua", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateGiaiQuyetViecDaNhan", id_tblAccountSupportParameter, ngayHoanThanhParameter, ketQuaCongViecParameter, ngaySuaParameter);
        }
    
        public virtual int UpdateNhanViec(Nullable<int> id_tbl_AccountSupport, Nullable<int> id_AccountSupport, Nullable<bool> statusReceived, Nullable<System.DateTime> ngayTiepNhan)
        {
            var id_tbl_AccountSupportParameter = id_tbl_AccountSupport.HasValue ?
                new ObjectParameter("Id_tbl_AccountSupport", id_tbl_AccountSupport) :
                new ObjectParameter("Id_tbl_AccountSupport", typeof(int));
    
            var id_AccountSupportParameter = id_AccountSupport.HasValue ?
                new ObjectParameter("Id_AccountSupport", id_AccountSupport) :
                new ObjectParameter("Id_AccountSupport", typeof(int));
    
            var statusReceivedParameter = statusReceived.HasValue ?
                new ObjectParameter("StatusReceived", statusReceived) :
                new ObjectParameter("StatusReceived", typeof(bool));
    
            var ngayTiepNhanParameter = ngayTiepNhan.HasValue ?
                new ObjectParameter("NgayTiepNhan", ngayTiepNhan) :
                new ObjectParameter("NgayTiepNhan", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateNhanViec", id_tbl_AccountSupportParameter, id_AccountSupportParameter, statusReceivedParameter, ngayTiepNhanParameter);
        }
    
        public virtual ObjectResult<ViecDaNhan_Result> ViecDaNhan(Nullable<int> id_AccountSupport)
        {
            var id_AccountSupportParameter = id_AccountSupport.HasValue ?
                new ObjectParameter("Id_AccountSupport", id_AccountSupport) :
                new ObjectParameter("Id_AccountSupport", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ViecDaNhan_Result>("ViecDaNhan", id_AccountSupportParameter);
        }
    
        [DbFunction("TheoDoiVanBanEntities", "tbl_Group_DonVi_CongViec")]
        public virtual IQueryable<tbl_Group_DonVi_CongViec_Result> tbl_Group_DonVi_CongViec(Nullable<int> id_donvi, Nullable<int> id_account)
        {
            var id_donviParameter = id_donvi.HasValue ?
                new ObjectParameter("Id_donvi", id_donvi) :
                new ObjectParameter("Id_donvi", typeof(int));
    
            var id_accountParameter = id_account.HasValue ?
                new ObjectParameter("Id_account", id_account) :
                new ObjectParameter("Id_account", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<tbl_Group_DonVi_CongViec_Result>("[TheoDoiVanBanEntities].[tbl_Group_DonVi_CongViec](@Id_donvi, @Id_account)", id_donviParameter, id_accountParameter);
        }
    
        public virtual ObjectResult<GetAllDonViCongViec_Result> GetAllDonViCongViec(Nullable<int> id_donvi, Nullable<int> id_Account)
        {
            var id_donviParameter = id_donvi.HasValue ?
                new ObjectParameter("Id_donvi", id_donvi) :
                new ObjectParameter("Id_donvi", typeof(int));
    
            var id_AccountParameter = id_Account.HasValue ?
                new ObjectParameter("Id_Account", id_Account) :
                new ObjectParameter("Id_Account", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllDonViCongViec_Result>("GetAllDonViCongViec", id_donviParameter, id_AccountParameter);
        }
    }
}
