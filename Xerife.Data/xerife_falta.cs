//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xerife.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class xerife_falta
    {
        public int falta_id { get; set; }
        public System.DateTime exercicio { get; set; }
        public string tipo { get; set; }
        public int minutos { get; set; }
        public Nullable<int> funcionario_id { get; set; }
        public string motivo { get; set; }
    
        public virtual xerife_funcionario xerife_funcionario { get; set; }
    }
}
