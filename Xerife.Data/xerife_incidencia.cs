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
    
    public partial class xerife_incidencia
    {
        public int incidencia_id { get; set; }
        public int evento_id { get; set; }
        public int evento_id_base { get; set; }
        public int tipo { get; set; }
        public long flag_base { get; set; }
        public byte[] controlversion { get; set; }
        public int flag_afastamento { get; set; }
        public int flag_periodo_afastamento { get; set; }
        public int flag_retorno { get; set; }
        public bool sem_valor { get; set; }
        public bool valor_invertido { get; set; }
        public int flag_vinculo { get; set; }
        public bool admissao { get; set; }
        public int flag_tipo_salario { get; set; }
        public int uso_restrito { get; set; }
    
        public virtual xerife_evento xerife_evento { get; set; }
        public virtual xerife_evento xerife_evento1 { get; set; }
    }
}
