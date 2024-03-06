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
    
    public partial class Pry_Movimientos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pry_Movimientos()
        {
            this.Pry_MontoDonacion = new HashSet<Pry_MontoDonacion>();
        }
    
        public int IdMovimiento { get; set; }
        public Nullable<int> IdPresupuesto { get; set; }
        public Nullable<int> IdProveedor { get; set; }
        public Nullable<double> Monto { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Observaciones { get; set; }
        public string UrlSoporte { get; set; }
        public Nullable<long> IdPeriodo { get; set; }
        public string BENEFICIARIO { get; set; }
        public string MEDIOPAGO { get; set; }
        public Nullable<decimal> CONTRAPARTIDA { get; set; }
        public Nullable<decimal> APORTEPROGRAMA { get; set; }
        public Nullable<int> IDPARTIDAGASTO { get; set; }
        public string USUARIOCREACION { get; set; }
        public Nullable<System.DateTime> FECHACREACION { get; set; }
        public string USUARIOMODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHAMODIFICACION { get; set; }
        public Nullable<int> MONEDALOCAL { get; set; }
        public Nullable<decimal> APORTEMONEDALOCAL { get; set; }
        public int IdTenant { get; set; }
    
        public virtual M_Monedas M_Monedas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pry_MontoDonacion> Pry_MontoDonacion { get; set; }
        public virtual PRY_PARTIDAGASTOS PRY_PARTIDAGASTOS { get; set; }
        public virtual PRY_PERIODOSPROYECTOS PRY_PERIODOSPROYECTOS { get; set; }
        public virtual Pry_Presupuesto Pry_Presupuesto { get; set; }
    }
}
