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
    
    public partial class Pry_Informes_Indicador
    {
        public int IdInforme { get; set; }
        public int IdIndicador { get; set; }
        public Nullable<double> Meta { get; set; }
        public Nullable<int> IdDatosMuestra { get; set; }
        public Nullable<int> Evaluacion { get; set; }
        public int IdTenant { get; set; }
    
        public virtual Pry_DatosMuestras Pry_DatosMuestras { get; set; }
        public virtual Pry_Indicadores Pry_Indicadores { get; set; }
        public virtual Pry_Informes Pry_Informes { get; set; }
        public virtual Pry_NivelAceptacion Pry_NivelAceptacion { get; set; }
    }
}
