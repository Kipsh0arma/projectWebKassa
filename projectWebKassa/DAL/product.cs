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
    
    public partial class product
    {
        public product()
        {
            this.prijs = new HashSet<prijs>();
            this.leveringRegels = new HashSet<leveringRegels>();
        }
    
        public int ProductId { get; set; }
        public int categorieId { get; set; }
        public string Naam { get; set; }
    
        public virtual ICollection<prijs> prijs { get; set; }
        public virtual categorie categorie { get; set; }
        public virtual ICollection<leveringRegels> leveringRegels { get; set; }
    }
}
