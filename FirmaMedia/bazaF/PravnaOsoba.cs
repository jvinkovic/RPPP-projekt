//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bazaF
{
    using System;
    using System.Collections.Generic;
    
    public partial class PravnaOsoba
    {
        public PravnaOsoba()
        {
            this.FizickaOsoba = new HashSet<FizickaOsoba>();
        }
    
        public int IDOsobe { get; set; }
        public string Naziv { get; set; }
        public string MB { get; set; }
    
        public virtual ICollection<FizickaOsoba> FizickaOsoba { get; set; }
        public virtual Osoba Osoba { get; set; }
    }
}