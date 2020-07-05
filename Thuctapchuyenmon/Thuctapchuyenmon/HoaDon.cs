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
    
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            this.CTDichVus = new HashSet<CTDichVu>();
            this.CTHoaDons = new HashSet<CTHoaDon>();
            this.CTPHUKIENs = new HashSet<CTPHUKIEN>();
            this.CTTHUCPHAMs = new HashSet<CTTHUCPHAM>();
            this.CTUuDais = new HashSet<CTUuDai>();
        }
    
        public string MaHD { get; set; }
        public Nullable<System.DateTime> ThoiGianLap { get; set; }
        public string MaKH { get; set; }
        public Nullable<double> TongTien { get; set; }
        public string MaUD { get; set; }
        public Nullable<bool> TrangThai { get; set; }
        public string UserName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDichVu> CTDichVus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHoaDon> CTHoaDons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPHUKIEN> CTPHUKIENs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTTHUCPHAM> CTTHUCPHAMs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTUuDai> CTUuDais { get; set; }
        public virtual DangNhap DangNhap { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual UuDaiHD UuDaiHD { get; set; }
    }
}
