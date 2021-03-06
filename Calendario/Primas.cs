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
    
    public partial class Primas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Primas()
        {
            this.BienesAsegurados = new HashSet<BienesAsegurados>();
            this.CertificadoAutomotor = new HashSet<CertificadoAutomotor>();
            this.CertificadoPersona = new HashSet<CertificadoPersona>();
            this.Cuotas = new HashSet<Cuotas>();
            this.Exclusiones = new HashSet<Exclusiones>();
            this.Pagos = new HashSet<Pagos>();
            this.PolizaDeducibles = new HashSet<PolizaDeducibles>();
            this.PolizaGastosFraccionados = new HashSet<PolizaGastosFraccionados>();
            this.PolizaGastosIniciales = new HashSet<PolizaGastosIniciales>();
        }
    
        public int primaId { get; set; }
        public Nullable<int> primaTipo { get; set; }
        public string polizaNumero { get; set; }
        public Nullable<int> clienteId { get; set; }
        public Nullable<int> primaPagador { get; set; }
        public Nullable<System.DateTime> primaVigencia { get; set; }
        public Nullable<System.DateTime> primaVencimiento { get; set; }
        public Nullable<System.DateTime> primaRegistrada { get; set; }
        public Nullable<decimal> primaAsegurada { get; set; }
        public Nullable<decimal> primaDeducible { get; set; }
        public Nullable<decimal> primaPrimaExenta { get; set; }
        public Nullable<decimal> primaPrimaGravada { get; set; }
        public Nullable<decimal> primaPrimaNeta { get; set; }
        public Nullable<decimal> primaGastos { get; set; }
        public Nullable<decimal> primaFraccionados { get; set; }
        public Nullable<decimal> primaIva { get; set; }
        public Nullable<decimal> primaTotal { get; set; }
        public Nullable<int> primaNumPagos { get; set; }
        public string primaObservaciones { get; set; }
        public Nullable<decimal> primaPagado { get; set; }
        public string primaStatus { get; set; }
        public string primaPeriodicidad { get; set; }
        public Nullable<decimal> primaTasa { get; set; }
        public string primaClienteCobro { get; set; }
        public string usuarioNombre { get; set; }
        public string usuarioEmpresa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BienesAsegurados> BienesAsegurados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CertificadoAutomotor> CertificadoAutomotor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CertificadoPersona> CertificadoPersona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cuotas> Cuotas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exclusiones> Exclusiones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pagos> Pagos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolizaDeducibles> PolizaDeducibles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolizaGastosFraccionados> PolizaGastosFraccionados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolizaGastosIniciales> PolizaGastosIniciales { get; set; }
        public virtual Polizas Polizas { get; set; }
        public virtual TipoPrima TipoPrima { get; set; }
    }
}
