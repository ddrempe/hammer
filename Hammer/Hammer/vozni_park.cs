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
    
    public partial class vozni_park
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vozni_park()
        {
            this.zaposlenici = new HashSet<zaposlenici>();
        }
    
        public int id { get; set; }
        public string naziv { get; set; }
        public Nullable<decimal> cijena { get; set; }
        public Nullable<int> kolicina { get; set; }
        public Nullable<System.DateTime> servis { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zaposlenici> zaposlenici { get; set; }
    }
}
