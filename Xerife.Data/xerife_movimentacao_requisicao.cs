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
    
    public partial class xerife_movimentacao_requisicao
    {
        public int movimentacao_requisicao_id { get; set; }
        public System.DateTime data { get; set; }
        public string solicitante { get; set; }
        public string anotacao { get; set; }
        public int requisicao_id { get; set; }
        public Nullable<System.Guid> anexo_id { get; set; }
    
        public virtual xerife_requisicao xerife_requisicao { get; set; }
    }
}
