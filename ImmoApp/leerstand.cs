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
    
    public partial class leerstand
    {
        public int leerstandsID { get; set; }
        public int mieteinheit { get; set; }
        public System.DateTime beginn { get; set; }
        public Nullable<System.DateTime> ende { get; set; }
    
        public virtual mieteinheit mieteinheit1 { get; set; }
    }
}
