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
    
    public partial class lop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lop()
        {
            this.sinhVien = new HashSet<sinhVien>();
        }
    
        public string maLop { get; set; }
        public string tenLop { get; set; }
        public string maKhoa { get; set; }
        public string maGV { get; set; }
        public string maLT { get; set; }
    
        public virtual giangVien giangVien { get; set; }
        public virtual khoa khoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sinhVien> sinhVien { get; set; }
    }
}
