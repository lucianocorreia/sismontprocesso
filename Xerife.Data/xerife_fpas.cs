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
    
    public partial class xerife_fpas
    {
        public xerife_fpas()
        {
            this.xerife_filial = new HashSet<xerife_filial>();
        }
    
        public int fpas_id { get; set; }
        public string descricao { get; set; }
        public int codigo_terceiro { get; set; }
        public decimal percentual_empresa { get; set; }
        public decimal percentual_terceiro { get; set; }
        public decimal percentual_automono { get; set; }
        public decimal percentual_socio { get; set; }
        public byte[] controlversion { get; set; }
        public int codigo_fpas { get; set; }
    
        public virtual ICollection<xerife_filial> xerife_filial { get; set; }
    }
}