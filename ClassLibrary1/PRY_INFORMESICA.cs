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
    
    public partial class PRY_INFORMESICA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRY_INFORMESICA()
        {
            this.PRY_INFORMESICADETALLE = new HashSet<PRY_INFORMESICADETALLE>();
            this.PRY_INFORMESICADOCUMENTOS = new HashSet<PRY_INFORMESICADOCUMENTOS>();
            this.PRY_INFORMESICAINDICADORES = new HashSet<PRY_INFORMESICAINDICADORES>();
            this.PRY_INFORMESICAOBJETIVOS = new HashSet<PRY_INFORMESICAOBJETIVOS>();
        }
    
        public int IDINFORME { get; set; }
        public int IDPROYECTO { get; set; }
        public int IDTIPO { get; set; }
        public System.DateTime FECHA { get; set; }
        public int IDESTADO { get; set; }
        public long PERIODOINICIAL { get; set; }
        public long PERIODOFINAL { get; set; }
        public int IdTenant { get; set; }
    
        public virtual PRY_INFORMESICAESTADOS PRY_INFORMESICAESTADOS { get; set; }
        public virtual PRY_INFORMESICATIPOS PRY_INFORMESICATIPOS { get; set; }
        public virtual PRY_PERIODOSPROYECTOS PRY_PERIODOSPROYECTOS { get; set; }
        public virtual PRY_PERIODOSPROYECTOS PRY_PERIODOSPROYECTOS1 { get; set; }
        public virtual Pry_Proyectos Pry_Proyectos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRY_INFORMESICADETALLE> PRY_INFORMESICADETALLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRY_INFORMESICADOCUMENTOS> PRY_INFORMESICADOCUMENTOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRY_INFORMESICAINDICADORES> PRY_INFORMESICAINDICADORES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRY_INFORMESICAOBJETIVOS> PRY_INFORMESICAOBJETIVOS { get; set; }
    }
}
