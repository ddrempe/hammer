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
    
    public partial class skladista
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public skladista()
        {
            this.skladiste_materijali = new HashSet<skladiste_materijali>();
        }
    
        public int id { get; set; }
        public Nullable<int> kapacitet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<skladiste_materijali> skladiste_materijali { get; set; }
    }
}
