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
    
    public partial class PHUKIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHUKIEN()
        {
            this.CTNhapPhuKiens = new HashSet<CTNhapPhuKien>();
            this.CTPHUKIENs = new HashSet<CTPHUKIEN>();
        }
    
        public string Maphukien { get; set; }
        public string Tenphukien { get; set; }
        public string donvi { get; set; }
        public Nullable<double> dongia { get; set; }
        public string MaLoai { get; set; }
        public byte[] HinhAnh { get; set; }
        public Nullable<int> Soluong { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTNhapPhuKien> CTNhapPhuKiens { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPHUKIEN> CTPHUKIENs { get; set; }
        public virtual LoaiPhuKien LoaiPhuKien { get; set; }
    }
}
