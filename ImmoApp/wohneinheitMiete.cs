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
    
    public partial class wohneinheitMiete
    {
        public int mietID { get; set; }
        public int einheit { get; set; }
        public bool aktiv { get; set; }
    
        public virtual mieteinheit mieteinheit { get; set; }
        public virtual miete miete { get; set; }
    }
}
