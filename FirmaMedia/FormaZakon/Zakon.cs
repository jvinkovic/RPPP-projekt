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
    
    public partial class Zakon
    {
        public Zakon()
        {
            this.Optuzba = new HashSet<Optuzba>();
            this.Zakon1 = new HashSet<Zakon>();
        }
    
        public int IDZakona { get; set; }
        public string Naziv { get; set; }
        public Nullable<int> Razina { get; set; }
        public Nullable<int> IDNadredenog { get; set; }
        public byte[] Dokument { get; set; }
    
        public virtual ICollection<Optuzba> Optuzba { get; set; }
        public virtual RazinaZakona RazinaZakona { get; set; }
        public virtual ICollection<Zakon> Zakon1 { get; set; }
        public virtual Zakon Zakon2 { get; set; }
    }
}