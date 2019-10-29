using System;

namespace TheoDoiVanBan.HeThong
{
    public class DinhDanhAccount
    {
        public static int Id_Account { get; set; }
        public static string FullName { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static byte[] Avartar { get; set; }
        public static Nullable<int> Id_DonVi_Tbl_DonVi { get; set; }
        public static bool Status { get; set; }
        public static Nullable<int> IdParent { get; set; }
        public static string NameParent { get; set; }
        public static Nullable<int> Level { get; set; }
        public static Nullable<int> TopLevelParent { get; set; }
    }
}
