//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfTilaukset
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tilausrivit
    {
        public int TilausriviID { get; set; }
        public Nullable<int> TilausID { get; set; }
        public Nullable<int> TuoteID { get; set; }
        public Nullable<int> Maara { get; set; }
        public Nullable<decimal> Ahinta { get; set; }
    
        public virtual Tilaukset Tilaukset { get; set; }
        public virtual Tuotteet Tuotteet { get; set; }
    }
}
