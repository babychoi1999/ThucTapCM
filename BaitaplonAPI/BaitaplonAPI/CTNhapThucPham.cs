//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaitaplonAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTNhapThucPham
    {
        public string MaPN { get; set; }
        public string MaThucPham { get; set; }
        public string TenThucPham { get; set; }
        public string MaLoai { get; set; }
        public Nullable<int> Soluong { get; set; }
        public Nullable<double> GiaNhap { get; set; }
        public byte[] Anh { get; set; }
        public string DonVi { get; set; }
    
        public virtual LoaiThucPham LoaiThucPham { get; set; }
        public virtual PhieuNhap PhieuNhap { get; set; }
    }
}
