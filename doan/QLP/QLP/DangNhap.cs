//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLP
{
    using System;
    using System.Collections.Generic;
    
    public partial class DangNhap
    {
        public string IDDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string Ten { get; set; }
        public Nullable<int> NhomNhanVienID { get; set; }
        public Nullable<bool> TrangThai { get; set; }
    
        public virtual NhomNhanVien NhomNhanVien { get; set; }
    }
}
