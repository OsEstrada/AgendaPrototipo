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
    
    public partial class PolizaAutomotorCoberturas
    {
        public int polizaAutomotorCoberturasId { get; set; }
        public string automotorPlaca { get; set; }
        public string polizaNumero { get; set; }
        public Nullable<int> coberturasId { get; set; }
        public Nullable<int> certAutoId { get; set; }
        public Nullable<decimal> prima { get; set; }
        public Nullable<decimal> suma { get; set; }
    
        public virtual Automotores Automotores { get; set; }
        public virtual AutomotoresCoberturas AutomotoresCoberturas { get; set; }
        public virtual CertificadoAutomotor CertificadoAutomotor { get; set; }
        public virtual Polizas Polizas { get; set; }
    }
}