//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Thuctapchuyenmon
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTHoaDon
    {
        public string MaHD { get; set; }
        public string MaThuCung { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string tenthucung { get; set; }
    
        public virtual HoaDon HoaDon { get; set; }
        public virtual ThuCung ThuCung { get; set; }
    }
}
