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
    
    public partial class TipoPrima
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoPrima()
        {
            this.Primas = new HashSet<Primas>();
        }
    
        public int tipoPrimaId { get; set; }
        public string tipoPrimaDescripcion { get; set; }
        public Nullable<int> tipoPrimaCodigo { get; set; }
        public Nullable<bool> FactorSumaAsegurada { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Primas> Primas { get; set; }
    }
}