//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tp01_cSharp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            this.Admissions = new HashSet<Admission>();
        }
    
        public string NAS { get; set; }
        public Nullable<System.DateTime> Date_naissance { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse_civique { get; set; }
        public string App { get; set; }
        public string Ville { get; set; }
        public string Province { get; set; }
        public string Code_postal { get; set; }
        public string Telephone { get; set; }
        public string IDAssurance { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Admission> Admissions { get; set; }
        public virtual Assurance Assurance { get; set; }
    }
}
