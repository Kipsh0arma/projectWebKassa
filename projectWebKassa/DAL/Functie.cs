//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projectWebKassa.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Functie
    {
        public Functie()
        {
            this.personeel = new HashSet<personeel>();
        }
    
        public int FunctieId { get; set; }
        public string Naam { get; set; }
        public string Beginschaal { get; set; }
        public string Eindschaal { get; set; }
    
        public virtual ICollection<personeel> personeel { get; set; }
    }
}
