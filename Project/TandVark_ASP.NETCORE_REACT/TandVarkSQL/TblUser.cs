//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TandVarkSQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblUser
    {
        public int FldId { get; set; }
        public string FldAccountName { get; set; }
        public string FldPassword { get; set; }
        public Nullable<int> UserTypeId { get; set; }
    
        public virtual TblUserType TblUserType { get; set; }
    }
}
