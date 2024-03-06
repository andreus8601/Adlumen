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
    
    public partial class Org_Donantes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Org_Donantes()
        {
            this.Pry_Proyectos_Donantes = new HashSet<Pry_Proyectos_Donantes>();
            this.Pry_CalendarioDonaciones = new HashSet<Pry_CalendarioDonaciones>();
            this.Pry_Informes_Donantes = new HashSet<Pry_Informes_Donantes>();
            this.Org_Empresas = new HashSet<Org_Empresas>();
            this.Sys_Usuarios = new HashSet<Sys_Usuarios>();
        }
    
        public int IdDonante { get; set; }
        public string Nombre { get; set; }
        public int IdIdentificacionTipo { get; set; }
        public string Identificacion { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Ubicacion { get; set; }
        public string Correo { get; set; }
        public string URL { get; set; }
        public string HojaVida { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public bool Eliminado { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<int> IdPrograma { get; set; }
        public int IdTenant { get; set; }
    
        public virtual Org_IdentificacionTipos Org_IdentificacionTipos { get; set; }
        public virtual Sys_Clientes Sys_Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pry_Proyectos_Donantes> Pry_Proyectos_Donantes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pry_CalendarioDonaciones> Pry_CalendarioDonaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pry_Informes_Donantes> Pry_Informes_Donantes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Org_Empresas> Org_Empresas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_Usuarios> Sys_Usuarios { get; set; }
    }
}
