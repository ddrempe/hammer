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
    
    public partial class izracun
    {
        public string zaposlenici_oib { get; set; }
        public int obracun_placa_id { get; set; }
        public System.DateTime datum { get; set; }
        public Nullable<int> broj_sati { get; set; }
        public decimal bonusi { get; set; }
    
        public virtual obracun_placa obracun_placa { get; set; }
        public virtual zaposlenici zaposlenici { get; set; }
    }
}
