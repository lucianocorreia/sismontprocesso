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
    
    public partial class xerife_item_regime_tributario
    {
        public xerife_item_regime_tributario()
        {
            this.xerife_item_fiscal = new HashSet<xerife_item_fiscal>();
            this.xerife_item_lancamento_servico = new HashSet<xerife_item_lancamento_servico>();
            this.xerife_mapeamento_tabela = new HashSet<xerife_mapeamento_tabela>();
            this.xerife_retencao = new HashSet<xerife_retencao>();
        }
    
        public int item_regime_tributario_id { get; set; }
        public int imposto_id { get; set; }
        public int regime_tributario_id { get; set; }
        public string periodo { get; set; }
        public string formula_id { get; set; }
        public Nullable<int> tabela_id { get; set; }
        public int dia_vencimento { get; set; }
        public string codigo_receita { get; set; }
        public int ordem_apuracao { get; set; }
        public byte[] controlversion { get; set; }
    
        public virtual xerife_formula xerife_formula { get; set; }
        public virtual xerife_imposto xerife_imposto { get; set; }
        public virtual ICollection<xerife_item_fiscal> xerife_item_fiscal { get; set; }
        public virtual ICollection<xerife_item_lancamento_servico> xerife_item_lancamento_servico { get; set; }
        public virtual ICollection<xerife_mapeamento_tabela> xerife_mapeamento_tabela { get; set; }
        public virtual ICollection<xerife_retencao> xerife_retencao { get; set; }
        public virtual xerife_regime_tributario xerife_regime_tributario { get; set; }
        public virtual xerife_tabela xerife_tabela { get; set; }
    }
}
