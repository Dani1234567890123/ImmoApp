//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImmoApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwVertragsforderung
    {
        public int Vertragsnr { get; set; }
        public int Forderungsnr { get; set; }
        public Nullable<System.DateTime> Fällig_am { get; set; }
        public Nullable<decimal> Betrag { get; set; }
        public Nullable<System.DateTime> Beglichen_am { get; set; }
        public Nullable<bool> offen { get; set; }
    }
}
