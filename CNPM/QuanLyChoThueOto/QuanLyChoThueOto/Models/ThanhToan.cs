//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyChoThueOto.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThanhToan
    {
        public string id_Thanhtoan { get; set; }
        public int id_hopdong { get; set; }
        public Nullable<int> idNV { get; set; }
        public Nullable<System.DateTime> NgayTT { get; set; }
        public string LyDo { get; set; }
        public string HoSoKem { get; set; }
        public string TienTT { get; set; }
    
        public virtual HopDong HopDong { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
