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
    
    public partial class xerife_retencao
    {
        public int retencao_id { get; set; }
        public Nullable<int> lancamento_servico_id { get; set; }
        public Nullable<System.DateTime> data_retencao { get; set; }
        public decimal valor_base_retencao { get; set; }
        public decimal percentual_retencao { get; set; }
        public decimal valor_retencao { get; set; }
        public Nullable<int> lancamento_fiscal_id { get; set; }
        public byte[] controlversion { get; set; }
        public int item_regime_tributario_id { get; set; }
    
        public virtual xerife_item_regime_tributario xerife_item_regime_tributario { get; set; }
        public virtual xerife_lancamento_fiscal xerife_lancamento_fiscal { get; set; }
        public virtual xerife_lancamento_servico xerife_lancamento_servico { get; set; }
    }
}
