//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hammer
{
    using System;
    using System.Collections.Generic;
    
    public partial class gradilista
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gradilista()
        {
            this.izvode_radove = new HashSet<izvode_radove>();
            this.koriste = new HashSet<koriste>();
            this.rade = new HashSet<rade>();
            this.zaposlenici = new HashSet<zaposlenici>();
        }
    
        public int ID { get; set; }
        public string naziv { get; set; }
        public string aktivan_od { get; set; }
        public string aktivan_do { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<izvode_radove> izvode_radove { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<koriste> koriste { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rade> rade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zaposlenici> zaposlenici { get; set; }
    }
}
