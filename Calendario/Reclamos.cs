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
    
    public partial class Reclamos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reclamos()
        {
            this.ReclamoDocumento = new HashSet<ReclamoDocumento>();
            this.ReclamoSeguimiento = new HashSet<ReclamoSeguimiento>();
        }
    
        public int reclamoId { get; set; }
        public string reclamoNo { get; set; }
        public string polizaNumero { get; set; }
        public Nullable<int> empresaId { get; set; }
        public Nullable<int> personaId { get; set; }
        public Nullable<int> dependiente { get; set; }
        public Nullable<int> certificadosId { get; set; }
        public string reclamoDependienteNombre { get; set; }
        public Nullable<System.DateTime> reclamoFechaEvento { get; set; }
        public Nullable<System.DateTime> reclamoFechaPago { get; set; }
        public Nullable<System.DateTime> reclamoFechaEnvio { get; set; }
        public Nullable<System.DateTime> reclamoFechaLiquidacionA { get; set; }
        public Nullable<System.DateTime> reclamoFechaLiquidacion { get; set; }
        public Nullable<decimal> reclamoDeducible { get; set; }
        public Nullable<decimal> reclamoMontoAbsorbido { get; set; }
        public Nullable<decimal> reclamoMontoPagado { get; set; }
        public string reclamoDiagnostico { get; set; }
        public string usuario { get; set; }
        public Nullable<System.DateTime> fechaGrabado { get; set; }
        public Nullable<bool> reclamoTerminado { get; set; }
        public Nullable<bool> reclamosAnulado { get; set; }
    
        public virtual CertificadoPersonaBeneficiario CertificadoPersonaBeneficiario { get; set; }
        public virtual Certificados Certificados { get; set; }
        public virtual Empresas Empresas { get; set; }
        public virtual Personas Personas { get; set; }
        public virtual Polizas Polizas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReclamoDocumento> ReclamoDocumento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReclamoSeguimiento> ReclamoSeguimiento { get; set; }
    }
}
