using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;
using TheoDoiVanBan.HeThong;

namespace TheoDoiVanBan
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        private TheoDoiVanBanEntities _theoDoiVanBanEntities;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void Dangnhap()
        {
            int iddonvi = 1;
            Mahoa _mahoa = new Mahoa();
            string _matkhau = _mahoa.EncryptString(TxtPassword.Text, "lamgico");
            try
            {
                using (_theoDoiVanBanEntities = new TheoDoiVanBanEntities())
                {
                    var Id = _theoDoiVanBanEntities.login(iddonvi, TxtUsername.Text, _matkhau).FirstOrDefault();
                    if (Id != null)
                    {
                        this.DialogResult = DialogResult.OK;
                        DinhDanhAccount.Id_Account = (int)Id.Id_Account;
                        DinhDanhAccount.FullName = Id.FullName;
                        DinhDanhAccount.UserName = Id.UserName;
                        DinhDanhAccount.Password = Id.Password;
                        DinhDanhAccount.Avartar = Id.Avartar;
                        DinhDanhAccount.Id_DonVi_Tbl_DonVi = Id.Id_DonVi_Tbl_DonVi;
                        DinhDanhAccount.Status = (bool)Id.Status;
                        DinhDanhAccount.IdParent = Id.IdParent;
                        DinhDanhAccount.NameParent = Id.NameParent;
                        DinhDanhAccount.Level = Id.Level;
                        DinhDanhAccount.TopLevelParent = Id.TopLevelParent;

                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Sai tên đăng nhập hoặc mật khẩu\nHoặc tài khoản đã bị khóa");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Dangnhap();
        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}