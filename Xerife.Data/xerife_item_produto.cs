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
    
    public partial class xerife_item_produto
    {
        public int item_fiscal_id { get; set; }
        public Nullable<int> produto_id { get; set; }
        public string descricao { get; set; }
        public int lancamento_fiscal_id { get; set; }
        public int codigo_fiscal_id { get; set; }
        public decimal quantidade { get; set; }
        public decimal valor { get; set; }
        public decimal total { get; set; }
        public byte[] controlversion { get; set; }
        public bool compoem_total_nf { get; set; }
        public decimal quantidade_tributavel { get; set; }
        public decimal valor_unitario_tributavel { get; set; }
        public decimal valor_frete { get; set; }
        public decimal valor_seguro { get; set; }
        public decimal valor_desconto { get; set; }
        public decimal valor_outras_despesas { get; set; }
        public Nullable<int> item_icms_id { get; set; }
        public Nullable<int> item_ipi_id { get; set; }
        public Nullable<int> item_pis_id { get; set; }
        public Nullable<int> item_imposto_importacao_id { get; set; }
        public Nullable<int> item_issqn_id { get; set; }
        public Nullable<int> item_cofins_id { get; set; }
        public Nullable<int> detalhamento_fiscal_id { get; set; }
    
        public virtual xerife_codigo_fiscal xerife_codigo_fiscal { get; set; }
        public virtual xerife_detalhamento_fiscal xerife_detalhamento_fiscal { get; set; }
        public virtual xerife_item_cofins xerife_item_cofins { get; set; }
        public virtual xerife_item_icms xerife_item_icms { get; set; }
        public virtual xerife_item_ii xerife_item_ii { get; set; }
        public virtual xerife_item_ipi xerife_item_ipi { get; set; }
        public virtual xerife_item_issqn xerife_item_issqn { get; set; }
        public virtual xerife_item_pis xerife_item_pis { get; set; }
        public virtual xerife_lancamento_fiscal xerife_lancamento_fiscal { get; set; }
        public virtual xerife_produto xerife_produto { get; set; }
    }
}