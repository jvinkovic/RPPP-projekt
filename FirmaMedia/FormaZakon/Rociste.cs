//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RPPP
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rociste
    {
        public Rociste()
        {
            this.Sudionik = new HashSet<Sudionik>();
        }
    
        public int IDRocista { get; set; }
        public Nullable<int> IDProcesa { get; set; }
        public Nullable<System.DateTime> Datum { get; set; }
        public Nullable<short> Trajanje { get; set; }
    
        public virtual Proces Proces { get; set; }
        public virtual ICollection<Sudionik> Sudionik { get; set; }
    }
}