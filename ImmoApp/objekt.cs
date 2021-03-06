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
    
    public partial class objekt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public objekt()
        {
            this.dokuments = new HashSet<dokument>();
            this.mieteinheits = new HashSet<mieteinheit>();
            this.notizs = new HashSet<notiz>();
        }
    
        public int objektID { get; set; }
        public string bezeichnung { get; set; }
        public string straße { get; set; }
        public string hausnr { get; set; }
        public string plz { get; set; }
        public string ort { get; set; }
        public int eigentümer { get; set; }
        public string allgemeinstromzähler { get; set; }
        public string wasserzähler { get; set; }
        public string gaszähler { get; set; }
        public Nullable<int> baujahr { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dokument> dokuments { get; set; }
        public virtual kontakt kontakt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mieteinheit> mieteinheits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<notiz> notizs { get; set; }
    }
}
