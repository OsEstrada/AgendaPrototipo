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
    
    public partial class Inmuebles
    {
        public int inmuebleId { get; set; }
        public string polizaNumero { get; set; }
        public string inmuebleDireccion1 { get; set; }
        public string inmuebleDireccion2 { get; set; }
        public string inmuebleDireccion3 { get; set; }
        public string inmuebleTipo { get; set; }
        public Nullable<decimal> inmuebleContenido { get; set; }
        public Nullable<decimal> inmuebleConstruccion { get; set; }
        public Nullable<decimal> inmuebleValuo { get; set; }
        public Nullable<decimal> inmueblePrima { get; set; }
        public Nullable<int> primaId { get; set; }
        public Nullable<bool> inmuebleEstado { get; set; }
        public string inmuebleObservaciones { get; set; }
        public string usuarioNombre { get; set; }
        public string usuarioEmpresa { get; set; }
        public Nullable<System.DateTime> fechaGrabado { get; set; }
    
        public virtual Certificados Certificados { get; set; }
        public virtual Polizas Polizas { get; set; }
    }
}