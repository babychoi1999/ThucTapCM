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
    
    public partial class THUCPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THUCPHAM()
        {
            this.CTTHUCPHAMs = new HashSet<CTTHUCPHAM>();
        }
    
        public string Mathucpham { get; set; }
        public string Tenthucpham { get; set; }
        public string donvi { get; set; }
        public Nullable<double> dongia { get; set; }
        public byte[] hinhanh { get; set; }
        public string MaLoai { get; set; }
        public Nullable<int> SOLUONG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTTHUCPHAM> CTTHUCPHAMs { get; set; }
        public virtual LoaiThucPham LoaiThucPham { get; set; }
    }
}
