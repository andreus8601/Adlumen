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
