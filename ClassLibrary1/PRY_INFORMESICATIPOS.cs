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
    
    public partial class PRY_INFORMESICATIPOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRY_INFORMESICATIPOS()
        {
            this.PRY_INFORMESICA = new HashSet<PRY_INFORMESICA>();
        }
    
        public int IDTIPO { get; set; }
        public string DESCRIPCION { get; set; }
        public int IdTenant { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRY_INFORMESICA> PRY_INFORMESICA { get; set; }
    }
}
