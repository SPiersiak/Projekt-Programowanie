//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aplikacja
{
    using System;
    using System.Collections.Generic;
    
    public partial class lotnisko
    {
        public long Id { get; set; }
        public string Nazwa_Lot { get; set; }
        public string Adres { get; set; }
        public string Dzien { get; set; }
        public string Godzina { get; set; }
        public long Nr_pas { get; set; }
        public string Typ_sam { get; set; }
        public long Koszt { get; set; }
        public string Zarezerwowane { get; set; }
        public Nullable<long> Id_lot { get; set; }
        public string Id_prze { get; set; }
        public string Nr_lot { get; set; }
    }
}
