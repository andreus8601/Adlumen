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
    
    public partial class Pry_Informes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pry_Informes()
        {
            this.Pry_Informes_Donantes = new HashSet<Pry_Informes_Donantes>();
            this.Pry_Informes_Encuestas = new HashSet<Pry_Informes_Encuestas>();
            this.Pry_Informes_Indicador = new HashSet<Pry_Informes_Indicador>();
            this.Pry_Informes_Presupuestos = new HashSet<Pry_Informes_Presupuestos>();
            this.Pry_Informes_Supuestos = new HashSet<Pry_Informes_Supuestos>();
        }
    
        public int IdInforme { get; set; }
        public Nullable<int> IdProyecto { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.DateTime> FechaProgramada { get; set; }
        public Nullable<System.DateTime> FechaInforme { get; set; }
        public Nullable<double> PresupuestoMeta { get; set; }
        public Nullable<double> PresupuestoEjecutado { get; set; }
        public Nullable<double> AvanceMeta { get; set; }
        public Nullable<double> AvanceEjecutado { get; set; }
        public string DescripcionSupuestos { get; set; }
        public string Informe { get; set; }
        public Nullable<int> EvaluacionComponentes { get; set; }
        public string EvaluacionComponentesDes { get; set; }
        public Nullable<int> EvaluacionProposito { get; set; }
        public string EvaluacionPropositoDes { get; set; }
        public string Lecciones { get; set; }
        public string Acciones { get; set; }
        public Nullable<int> IdEstado { get; set; }
        public Nullable<bool> IdEstadoNotificado { get; set; }
        public int IdTenant { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pry_Informes_Donantes> Pry_Informes_Donantes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pry_Informes_Encuestas> Pry_Informes_Encuestas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pry_Informes_Indicador> Pry_Informes_Indicador { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pry_Informes_Presupuestos> Pry_Informes_Presupuestos { get; set; }
        public virtual Pry_InformesEstados Pry_InformesEstados { get; set; }
        public virtual Pry_NivelAceptacion Pry_NivelAceptacion { get; set; }
        public virtual Pry_NivelAceptacion Pry_NivelAceptacion1 { get; set; }
        public virtual Pry_Proyectos Pry_Proyectos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pry_Informes_Supuestos> Pry_Informes_Supuestos { get; set; }
    }
}
