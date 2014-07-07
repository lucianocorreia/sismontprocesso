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
    
    public partial class xerife_item_icms
    {
        public xerife_item_icms()
        {
            this.xerife_item_produto = new HashSet<xerife_item_produto>();
        }
    
        public int item_icms_id { get; set; }
        public int regime { get; set; }
        public int origem { get; set; }
        public int situacao_tributaria { get; set; }
        public int modelo_base_calculo { get; set; }
        public decimal base_calculo { get; set; }
        public decimal aliquota { get; set; }
        public decimal reducao_base { get; set; }
        public decimal valor_icms { get; set; }
        public int modelo_base_calculo_st { get; set; }
        public decimal base_calculo_st { get; set; }
        public decimal aliquota_st { get; set; }
        public decimal valor_st { get; set; }
        public decimal reducao_base_st { get; set; }
        public decimal margem_valor_st { get; set; }
        public decimal base_operacao_propria { get; set; }
        public Nullable<int> uf_id_st { get; set; }
        public int motivo_desoneracao { get; set; }
        public decimal aliquota_credito { get; set; }
        public decimal credito { get; set; }
        public decimal base_calculo_st_remetente { get; set; }
        public decimal base_calculo_st_destinatario { get; set; }
        public decimal icms_retido_st_remetente { get; set; }
        public decimal icms_retido_st_destinatario { get; set; }
    
        public virtual ICollection<xerife_item_produto> xerife_item_produto { get; set; }
        public virtual xerife_uf xerife_uf { get; set; }
    }
}