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
    
    public partial class VrstaKazne
    {
        public VrstaKazne()
        {
            this.Kazna = new HashSet<Kazna>();
        }
    
        public int SifraVrste { get; set; }
        public string NazivVrste { get; set; }
    
        public virtual ICollection<Kazna> Kazna { get; set; }
    }
}