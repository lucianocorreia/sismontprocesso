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
    
    public partial class xerife_acumulador_fiscal
    {
        public int acumulador_id { get; set; }
        public int filial_id { get; set; }
        public int imposto_id { get; set; }
        public int codigo_fiscal_id { get; set; }
        public int uf_id { get; set; }
        public System.DateTime exercicio { get; set; }
        public int periodo { get; set; }
        public int contribuicao { get; set; }
        public decimal valor_base_compra { get; set; }
        public decimal valor_imposto_compra { get; set; }
        public decimal valor_isentas_compra { get; set; }
        public decimal valor_outras_compra { get; set; }
        public decimal valor_contabil_compra { get; set; }
        public decimal valor_base_venda { get; set; }
        public decimal valor_imposto_venda { get; set; }
        public decimal valor_isentas_venda { get; set; }
        public decimal valor_outras_venda { get; set; }
        public decimal valor_contabil_venda { get; set; }
        public byte[] controlversion { get; set; }
    
        public virtual xerife_codigo_fiscal xerife_codigo_fiscal { get; set; }
        public virtual xerife_filial xerife_filial { get; set; }
        public virtual xerife_imposto xerife_imposto { get; set; }
        public virtual xerife_uf xerife_uf { get; set; }
    }
}