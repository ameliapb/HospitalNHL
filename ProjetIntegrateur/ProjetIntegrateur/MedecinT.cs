//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetIntegrateur
{
    using System;
    using System.Collections.Generic;
    
    public partial class MedecinT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedecinT()
        {
            this.Dossier_Admission = new HashSet<Dossier_Admission>();
            this.Dossier_Admission1 = new HashSet<Dossier_Admission>();
        }
    
        public int ID_Medecin { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string specialite { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dossier_Admission> Dossier_Admission { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dossier_Admission> Dossier_Admission1 { get; set; }
    }
}
