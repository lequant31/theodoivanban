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
    
    public partial class GetInfor_Result
    {
        public int Id_Account { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte[] Avartar { get; set; }
        public Nullable<int> Id_DonVi_Tbl_DonVi { get; set; }
        public bool Status { get; set; }
        public Nullable<int> IdParent { get; set; }
        public string NameParent { get; set; }
        public Nullable<int> Level { get; set; }
    }
}
