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
    
    public partial class bank
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bank()
        {
            this.bankverbindungs = new HashSet<bankverbindung>();
        }
    
        public int bankID { get; set; }
        public string name { get; set; }
        public string bic { get; set; }
        public string straße { get; set; }
        public string hausnr { get; set; }
        public string plz { get; set; }
        public string ort { get; set; }
        public string land { get; set; }
        public string ansprechpartner { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bankverbindung> bankverbindungs { get; set; }
    }
}
