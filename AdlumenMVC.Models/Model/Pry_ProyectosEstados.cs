//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdlumenMVC.Models.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pry_ProyectosEstados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pry_ProyectosEstados()
        {
            this.Pry_Proyectos = new HashSet<Pry_Proyectos>();
        }
    
        public int IdEstado { get; set; }
        public string Descripcion { get; set; }
        public int IdTenant { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pry_Proyectos> Pry_Proyectos { get; set; }
    }
}