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
    
    public partial class M_Monedas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public M_Monedas()
        {
            this.m_TipCambio = new HashSet<m_TipCambio>();
            this.Pry_Movimientos = new HashSet<Pry_Movimientos>();
            this.Pry_Proyectos = new HashSet<Pry_Proyectos>();
        }
    
        public int IdMoneda { get; set; }
        public string Nombre { get; set; }
        public string Representacion { get; set; }
        public int IdTenant { get; set; }
        public string Codigo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<m_TipCambio> m_TipCambio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pry_Movimientos> Pry_Movimientos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pry_Proyectos> Pry_Proyectos { get; set; }
    }
}
