//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Calendario
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoBeneficiario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoBeneficiario()
        {
            this.CertificadoPersonaBeneficiario = new HashSet<CertificadoPersonaBeneficiario>();
        }
    
        public int tipoBeneficiarioId { get; set; }
        public string tipoBeneficiarioDescripcion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CertificadoPersonaBeneficiario> CertificadoPersonaBeneficiario { get; set; }
    }
}
