//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_StokProjesi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TBL_MUSTERILER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_MUSTERILER()
        {
            this.TBL_SATISLAR = new HashSet<TBL_SATISLAR>();
        }
    
        public int MUSTERIID { get; set; }

        [Required (ErrorMessage ="Bu Alan Bo� B�rak�lamaz")]
        [StringLength(50,ErrorMessage ="En Fazla 50 Karakterlik �sim Girilebilr")]
        public string MUSTERIAD { get; set; }
        public string MUSTERISOYAD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_SATISLAR> TBL_SATISLAR { get; set; }
    }
}
