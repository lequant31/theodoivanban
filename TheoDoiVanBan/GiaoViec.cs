using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using TheoDoiVanBan.HeThong;

namespace TheoDoiVanBan
{
    public partial class GiaoViec : DevExpress.XtraEditors.XtraForm
    {
        public GiaoViec()
        {
            InitializeComponent();
        }

        public int Id_tbl_congviec;
        public Guid IdGDVanBanDen;
        public Guid IdEdit;
        public bool _Edit = false;
        private TheoDoiVanBanEntities _theoDoiVanBanEntities;

        private void GetAllItem()
        {
            using (_theoDoiVanBanEntities = new TheoDoiVanBanEntities())
            {
                int idtop;
                if (DinhDanhAccount.Level == 3)
                {
                    idtop = (int)DinhDanhAccount.IdParent;
                }
                else
                {
                    idtop = (int)DinhDanhAccount.TopLevelParent;
                }
                var ListAccountInGroup = _theoDoiVanBanEntities.GetAccountInGroup(idtop, DinhDanhAccount.Id_DonVi_Tbl_DonVi).ToList();

                SearchDonViChuTri.Properties.DataSource = ListAccountInGroup;
                SearchDonViChuTri.Properties.DisplayMember = "FullName";
                SearchDonViChuTri.Properties.ValueMember = "Id_Account";

                SearchDonViPhoiHop.Properties.DataSource = ListAccountInGroup;
                SearchDonViPhoiHop.Properties.DisplayMember = "FullName";
                SearchDonViPhoiHop.Properties.ValueMember = "Id_Account";
            }
        }

        private void BtnGiaoViec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //#region checkdonvinhan

            //if (SearchDonViChuTri.EditValue == null)
            //{
            //    XtraMessageBox.Show("Yêu cầu chọn đơn vị chủ trì");
            //    return;
            //}

            //#endregion checkdonvinhan

            try
            {
                using (_theoDoiVanBanEntities = new TheoDoiVanBanEntities())
                {
                    var _list = _theoDoiVanBanEntities.GetForwardCreateJob(Id_tbl_congviec).ToList();
                    if (_list.Count == 0)
                    {
                        _theoDoiVanBanEntities.GiaoViecChinh(Id_tbl_congviec, (int)SearchDonViChuTri.EditValue, DateTime.Now);
                        foreach (CheckedListBoxItem item in SearchDonViPhoiHop.Properties.Items)
                        {
                            if (item.CheckState == CheckState.Checked)
                            {
                                if ((int)SearchDonViChuTri.EditValue != (int)item.Value)
                                {
                                    _theoDoiVanBanEntities.GiaoViecHoTro(Id_tbl_congviec, (int)item.Value, DateTime.Now);
                                }
                            }
                        }
                    }
                    else
                    {
                        ArrayList al = new ArrayList();
                        foreach (var i in _list)
                        {
                            al.Add(i.Id_AccountTiepNhan);
                        }
                        foreach (CheckedListBoxItem item in SearchDonViPhoiHop.Properties.Items)
                        {
                            if (item.CheckState == CheckState.Checked)
                            {
                                if (al.Contains((int)item.Value))
                                {
                                }
                                else
                                {
                                    _theoDoiVanBanEntities.GiaoViecHoTro(Id_tbl_congviec, (int)item.Value, DateTime.Now);
                                }
                            }
                        }
                    }

                    _theoDoiVanBanEntities.EnableStatusforward(Id_tbl_congviec);
                }
                XtraMessageBox.Show("Công việc đã được giao.\n Bạn không thể sửa và xóa công việc này");
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Lỗi kết nối đến server");
            }
        }

        private void GiaoViec_Load(object sender, EventArgs e)
        {
            GetAllItem();
        }
    }
}