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
    
    public partial class email
    {
        public string email1 { get; set; }
        public int kontakt { get; set; }
        public string kategorie { get; set; }
    
        public virtual eMailNummernKat eMailNummernKat { get; set; }
        public virtual kontakt kontakt1 { get; set; }
    }
}
