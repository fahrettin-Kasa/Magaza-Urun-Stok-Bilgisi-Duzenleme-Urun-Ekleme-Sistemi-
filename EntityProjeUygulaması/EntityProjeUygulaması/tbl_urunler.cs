//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityProjeUygulaması
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_urunler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_urunler()
        {
            this.tbl_satis = new HashSet<tbl_satis>();
        }
    
        public int URUNID { get; set; }
        public string URUNAD { get; set; }
        public string MARKA { get; set; }
        public Nullable<short> STOK { get; set; }
        public Nullable<decimal> FİYAT { get; set; }
        public Nullable<bool> DURUM { get; set; }
        public Nullable<int> KATEGORİ { get; set; }
    
        public virtual tbl_katagori tbl_katagori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_satis> tbl_satis { get; set; }
    }
}
