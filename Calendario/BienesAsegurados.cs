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
    
    public partial class BienesAsegurados
    {
        public int bienId { get; set; }
        public string polizaNumero { get; set; }
        public Nullable<int> tipoBienId { get; set; }
        public string bienNoSerie { get; set; }
        public string bienDescripcion { get; set; }
        public string bienModelo { get; set; }
        public string bienMarca { get; set; }
        public Nullable<decimal> bienValor { get; set; }
        public string bienObservaciones { get; set; }
        public Nullable<decimal> bienPrima { get; set; }
        public Nullable<int> primaId { get; set; }
        public string bienUbicacion { get; set; }
        public Nullable<bool> bienEstado { get; set; }
        public string usuarioNombre { get; set; }
        public string usuarioEmpresa { get; set; }
        public Nullable<System.DateTime> fechaGrabado { get; set; }
    
        public virtual Certificados Certificados { get; set; }
        public virtual Polizas Polizas { get; set; }
        public virtual Primas Primas { get; set; }
        public virtual TipoBien TipoBien { get; set; }
    }
}