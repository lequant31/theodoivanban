//------------------------------------------------------------------------------
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
    
    public partial class login_Result
    {
        public Nullable<int> Id_Account { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte[] Avartar { get; set; }
        public Nullable<int> Id_DonVi_Tbl_DonVi { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> IdParent { get; set; }
        public string NameParent { get; set; }
        public Nullable<int> Level { get; set; }
        public Nullable<int> TopLevelParent { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<int> ChildID { get; set; }
        public int Id_DonVi { get; set; }
        public string NameDonVi { get; set; }
        public string SoHieuDonVi { get; set; }
        public string PrintNameDonVi { get; set; }
    }
}