//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DGRLSV
{
    using System;
    using System.Collections.Generic;
    
    public partial class sinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sinhVien()
        {
            this.diemDanhGiaRenLuyen = new HashSet<diemDanhGiaRenLuyen>();
            this.ketQua = new HashSet<ketQua>();
        }
    
        public string MSSV { get; set; }
        public string hoTen { get; set; }
        public Nullable<System.DateTime> ngaySinh { get; set; }
        public string queQuan { get; set; }
        public string maLop { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<diemDanhGiaRenLuyen> diemDanhGiaRenLuyen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ketQua> ketQua { get; set; }
        public virtual lop lop { get; set; }
    }
}