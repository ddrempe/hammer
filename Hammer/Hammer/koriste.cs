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
    
    public partial class koriste
    {
        public int id { get; set; }
        public Nullable<int> alati_id { get; set; }
        public Nullable<int> gradilista_id { get; set; }
        public Nullable<System.DateTime> od { get; set; }
        public Nullable<System.DateTime> @do { get; set; }
    
        public virtual alati alati { get; set; }
        public virtual gradilista gradilista { get; set; }
    }
}
