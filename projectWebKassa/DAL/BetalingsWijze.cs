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
    
    public partial class BetalingsWijze
    {
        public BetalingsWijze()
        {
            this.betalings = new HashSet<betaling>();
        }
    
        public int betalingsWijzeId { get; set; }
        public string PayPal { get; set; }
        public string IDeal { get; set; }
        public string Contant { get; set; }
        public string CreditCard { get; set; }
    
        public virtual ICollection<betaling> betalings { get; set; }
    }
}
