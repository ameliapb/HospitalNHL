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
    
    public partial class Lit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lit()
        {
            this.Dossier_Admission = new HashSet<Dossier_Admission>();
        }
    
        public int Numero_Lit { get; set; }
        public string occupe { get; set; }
        public Nullable<int> numero_Type { get; set; }
        public Nullable<int> ID_Departement { get; set; }
    
        public virtual Departement Departement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dossier_Admission> Dossier_Admission { get; set; }
        public virtual Type_Lit Type_Lit { get; set; }
    }
}
