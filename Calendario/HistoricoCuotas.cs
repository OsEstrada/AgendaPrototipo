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
    
    public partial class HistoricoCuotas
    {
        public int idHistoricoCuota { get; set; }
        public Nullable<int> cuotaId { get; set; }
        public Nullable<int> primaId { get; set; }
        public string polizaNumero { get; set; }
        public Nullable<int> cuotaNumero { get; set; }
        public Nullable<decimal> cuotaPrimaExenta { get; set; }
        public Nullable<decimal> cuotaPrimaGravada { get; set; }
        public Nullable<decimal> cuotaPrimaNeta { get; set; }
        public Nullable<decimal> cuotaGastos { get; set; }
        public Nullable<double> cuotaIva { get; set; }
        public Nullable<decimal> cuotaTotal { get; set; }
        public Nullable<decimal> cuotaPagado { get; set; }
        public Nullable<decimal> cuotaDevolucion { get; set; }
        public Nullable<System.DateTime> cuotaFechaPago { get; set; }
        public string cuotaObservaciones { get; set; }
        public string cuotaPlan { get; set; }
        public Nullable<bool> cuotaEstado { get; set; }
        public string historicoCuotaAccion { get; set; }
        public string historicoCuotaUsuario { get; set; }
        public Nullable<System.DateTime> fechaGuardado { get; set; }
        public string empresa { get; set; }
    }
}
