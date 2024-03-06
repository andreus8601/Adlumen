//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Org_Cargos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Org_Cargos()
        {
            this.Org_Empleados = new HashSet<Org_Empleados>();
            this.Org_EmpleadosCargosHistorico = new HashSet<Org_EmpleadosCargosHistorico>();
        }
    
        public int IdCargo { get; set; }
        public int IdArea { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> IdPadre { get; set; }
        public string Descripcion { get; set; }
        public string Perfil { get; set; }
        public string UsuarioCreacion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public bool Eliminado { get; set; }
        public int IdTenant { get; set; }
    
        public virtual Org_Areas Org_Areas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Org_Empleados> Org_Empleados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Org_EmpleadosCargosHistorico> Org_EmpleadosCargosHistorico { get; set; }
    }
}
