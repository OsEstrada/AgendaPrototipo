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
    
    public partial class HistorialUsuario
    {
        public int historialId { get; set; }
        public Nullable<int> usuarioID { get; set; }
        public Nullable<System.DateTime> historialFechaHora { get; set; }
        public string usuarioEmpresa { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
    }
}
