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
    
    public partial class Org_EmpleadosCargosHistorico
    {
        public int IdEmpleadoCargo { get; set; }
        public int IdEmpleado { get; set; }
        public int IdCargo { get; set; }
        public System.DateTime FechaInicioCargo { get; set; }
        public Nullable<System.DateTime> FechaFinCargo { get; set; }
        public string UsuarioCreacion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public int IdTenant { get; set; }
    
        public virtual Org_Cargos Org_Cargos { get; set; }
        public virtual Org_Empleados Org_Empleados { get; set; }
    }
}