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
    
    public partial class xerife_empresa_comercial
    {
        public int empresa_id { get; set; }
        public byte[] controlversion { get; set; }
    
        public virtual xerife_empresa xerife_empresa { get; set; }
    }
}
