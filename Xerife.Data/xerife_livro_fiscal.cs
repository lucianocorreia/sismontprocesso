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
    
    public partial class xerife_livro_fiscal
    {
        public xerife_livro_fiscal()
        {
            this.xerife_livro_fiscal_item = new HashSet<xerife_livro_fiscal_item>();
        }
    
        public int livro_fiscal_id { get; set; }
        public string descricao { get; set; }
        public int tipo { get; set; }
        public byte[] controlversion { get; set; }
    
        public virtual ICollection<xerife_livro_fiscal_item> xerife_livro_fiscal_item { get; set; }
    }
}
