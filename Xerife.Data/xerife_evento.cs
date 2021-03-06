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
    
    public partial class xerife_evento
    {
        public xerife_evento()
        {
            this.xerife_evento1 = new HashSet<xerife_evento>();
            this.xerife_evento_automatizado = new HashSet<xerife_evento_automatizado>();
            this.xerife_evento_departamento = new HashSet<xerife_evento_departamento>();
            this.xerife_evento_filial = new HashSet<xerife_evento_filial>();
            this.xerife_evento_funcionario = new HashSet<xerife_evento_funcionario>();
            this.xerife_evento_programado_item = new HashSet<xerife_evento_programado_item>();
            this.xerife_evento_sindicato = new HashSet<xerife_evento_sindicato>();
            this.xerife_evento_tomador = new HashSet<xerife_evento_tomador>();
            this.xerife_folha = new HashSet<xerife_folha>();
            this.xerife_incidencia = new HashSet<xerife_incidencia>();
            this.xerife_incidencia_opcoes = new HashSet<xerife_incidencia_opcoes>();
            this.xerife_incidencia1 = new HashSet<xerife_incidencia>();
            this.xerife_evento_parametro = new HashSet<xerife_evento_parametro>();
            this.xerife_evento_usuario = new HashSet<xerife_evento_usuario>();
        }
    
        public int evento_id { get; set; }
        public Nullable<int> evento_id_media { get; set; }
        public int codigo { get; set; }
        public string descricao { get; set; }
        public string titulo { get; set; }
        public byte[] controlversion { get; set; }
        public int tipo_evento_id { get; set; }
        public string formula_id { get; set; }
        public string operacao { get; set; }
        public decimal indice { get; set; }
        public string referencia { get; set; }
        public string modelo_bloqueio { get; set; }
        public long flag_processamento { get; set; }
        public Nullable<int> tabela_id { get; set; }
        public bool aceitar_valor_zerado { get; set; }
        public int flag_incidencia_afastamento { get; set; }
        public int flag_incidencia_periodo_afastamento { get; set; }
        public int flag_incidencia_retorno_afastamento { get; set; }
        public bool adicionar_salario_minimo { get; set; }
        public Nullable<int> variavel_id { get; set; }
        public bool adicionar_variavel { get; set; }
        public bool adicionar_salario_adicional { get; set; }
        public bool adicionar_salario { get; set; }
        public string campo_rescisao { get; set; }
        public int flag_vinculo { get; set; }
        public int flag_proporcional { get; set; }
        public long flag_incidencia { get; set; }
        public int flag_processamento_afastamento { get; set; }
        public int flag_processamento_periodo_afastamento { get; set; }
        public int flag_processamento_retorno_afastamento { get; set; }
        public bool incide_admissao { get; set; }
        public int flag_tipo_salario { get; set; }
        public int uso_restrito { get; set; }
        public string rubrica_rescisao { get; set; }
        public bool fixo_rescisao { get; set; }
        public int flag_compatibilidade { get; set; }
        public string campo_homolognet { get; set; }
        public decimal ordem { get; set; }
        public string sip_codigo_evento { get; set; }
        public string fixo_variavel_eventual { get; set; }
        public string sip_agrupamento { get; set; }
    
        public virtual ICollection<xerife_evento> xerife_evento1 { get; set; }
        public virtual xerife_evento xerife_evento2 { get; set; }
        public virtual ICollection<xerife_evento_automatizado> xerife_evento_automatizado { get; set; }
        public virtual ICollection<xerife_evento_departamento> xerife_evento_departamento { get; set; }
        public virtual ICollection<xerife_evento_filial> xerife_evento_filial { get; set; }
        public virtual ICollection<xerife_evento_funcionario> xerife_evento_funcionario { get; set; }
        public virtual ICollection<xerife_evento_programado_item> xerife_evento_programado_item { get; set; }
        public virtual ICollection<xerife_evento_sindicato> xerife_evento_sindicato { get; set; }
        public virtual ICollection<xerife_evento_tomador> xerife_evento_tomador { get; set; }
        public virtual ICollection<xerife_folha> xerife_folha { get; set; }
        public virtual ICollection<xerife_incidencia> xerife_incidencia { get; set; }
        public virtual ICollection<xerife_incidencia_opcoes> xerife_incidencia_opcoes { get; set; }
        public virtual ICollection<xerife_incidencia> xerife_incidencia1 { get; set; }
        public virtual ICollection<xerife_evento_parametro> xerife_evento_parametro { get; set; }
        public virtual ICollection<xerife_evento_usuario> xerife_evento_usuario { get; set; }
        public virtual xerife_formula xerife_formula { get; set; }
        public virtual xerife_tabela xerife_tabela { get; set; }
        public virtual xerife_tipo_evento xerife_tipo_evento { get; set; }
        public virtual xerife_variavel xerife_variavel { get; set; }
    }
}
