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
    
    public partial class xerife_documento
    {
        public int documento_id { get; set; }
        public System.Guid anexo_id { get; set; }
        public string tabela { get; set; }
        public int tipo_documento_id { get; set; }
        public System.DateTime data_upload { get; set; }
        public System.DateTime data_documento { get; set; }
        public System.DateTime data_entrega { get; set; }
        public byte[] controlversion { get; set; }
        public string usuario { get; set; }
        public int arquivo_id { get; set; }
        public string senha { get; set; }
    
        public virtual xerife_arquivo xerife_arquivo { get; set; }
        public virtual xerife_tipo_documento xerife_tipo_documento { get; set; }
    }
}
