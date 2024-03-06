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
    
    public partial class Doc_Documentos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doc_Documentos()
        {
            this.Documentos_Tareas = new HashSet<Documentos_Tareas>();
            this.Documentos_Tareas1 = new HashSet<Documentos_Tareas>();
        }
    
        public int IdDocumento { get; set; }
        public int IdCategoria { get; set; }
        public int IdTipoArchivo { get; set; }
        public string Titulo { get; set; }
        public string PalabrasClaves { get; set; }
        public string Resumen { get; set; }
        public string Url { get; set; }
        public string UsuarioCreacion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string Roles { get; set; }
        public int IdTenant { get; set; }
    
        public virtual Doc_ArchivosTipos Doc_ArchivosTipos { get; set; }
        public virtual Doc_Categorias Doc_Categorias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentos_Tareas> Documentos_Tareas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentos_Tareas> Documentos_Tareas1 { get; set; }
    }
}
