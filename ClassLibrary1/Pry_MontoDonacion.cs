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
    
    public partial class Pry_MontoDonacion
    {
        public int IdMontoDonante { get; set; }
        public Nullable<int> IdMovimiento { get; set; }
        public Nullable<int> IdDonante { get; set; }
        public Nullable<double> Monto { get; set; }
        public int IdTenant { get; set; }
    
        public virtual Pry_Movimientos Pry_Movimientos { get; set; }
    }
}