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
    
    public partial class AgendaRegistro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AgendaRegistro()
        {
            this.AgendaRegistro1 = new HashSet<AgendaRegistro>();
        }
    
        public int idRegistro { get; set; }
        public Nullable<int> idUsuario { get; set; }
        public Nullable<int> idEmpresa { get; set; }
        public System.DateTime fechaHoraInicio { get; set; }
        public Nullable<System.DateTime> fechaHoraFinal { get; set; }
        public Nullable<int> tipoRegistro { get; set; }
        public string registroTitulo { get; set; }
        public string registroDetalles { get; set; }
        public Nullable<bool> registroEstado { get; set; }
        public Nullable<int> registroRef { get; set; }
    
        public virtual Empresas Empresas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgendaRegistro> AgendaRegistro1 { get; set; }
        public virtual AgendaRegistro AgendaRegistro2 { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
