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
    
    public partial class forderung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public forderung()
        {
            this.mietvertrags = new HashSet<mietvertrag>();
        }
    
        public int ford_nr { get; set; }
        public Nullable<int> kategorie { get; set; }
        public Nullable<System.DateTime> fälligkeit { get; set; }
        public Nullable<int> einnahme { get; set; }
        public Nullable<bool> ausgeglichen { get; set; }
        public Nullable<decimal> betrag { get; set; }
    
        public virtual einnahme einnahme1 { get; set; }
        public virtual zahlungskategorie zahlungskategorie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mietvertrag> mietvertrags { get; set; }
    }
}
