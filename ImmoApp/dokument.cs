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
    
    public partial class dokument
    {
        public int dokID { get; set; }
        public Nullable<int> kategorie { get; set; }
        public string titel { get; set; }
        public byte[] datei { get; set; }
        public Nullable<System.DateTime> datum { get; set; }
        public Nullable<int> zuPerson { get; set; }
        public Nullable<int> zuObjekt { get; set; }
        public Nullable<int> zuEinheit { get; set; }
        public Nullable<int> zuVertrag { get; set; }
        public Nullable<bool> Vorlage { get; set; }
    
        public virtual mieteinheit mieteinheit { get; set; }
        public virtual dokumentenkategorie dokumentenkategorie { get; set; }
        public virtual objekt objekt { get; set; }
        public virtual kontakt kontakt { get; set; }
        public virtual mietvertrag mietvertrag { get; set; }
    }
}
