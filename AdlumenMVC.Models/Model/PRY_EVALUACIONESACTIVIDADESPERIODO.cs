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
    
    public partial class PRY_EVALUACIONESACTIVIDADESPERIODO
    {
        public int IDOBJETIVO { get; set; }
        public long IDPERIODO { get; set; }
        public int IDPROYECTO { get; set; }
        public string OBSERVACIONES { get; set; }
        public int IdTenant { get; set; }
    
        public virtual PRY_EVALUACIONPROYECTOPERIODO PRY_EVALUACIONPROYECTOPERIODO { get; set; }
        public virtual Pry_Objetivos Pry_Objetivos { get; set; }
    }
}