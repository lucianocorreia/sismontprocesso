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
    
    public partial class xerife_contador
    {
        public xerife_contador()
        {
            this.xerife_filial = new HashSet<xerife_filial>();
        }
    
        public int contador_id { get; set; }
        public string nome { get; set; }
        public string crc { get; set; }
        public string cpf { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string complemento { get; set; }
        public string numero { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public Nullable<int> municipio_id { get; set; }
        public byte[] controlversion { get; set; }
        public string nomenclatura { get; set; }
        public int tipo_inscricao { get; set; }
        public string cnpj { get; set; }
        public string cei { get; set; }
        public string razao_social { get; set; }
        public Nullable<System.DateTime> data_nascimento { get; set; }
    
        public virtual ICollection<xerife_filial> xerife_filial { get; set; }
        public virtual xerife_municipio xerife_municipio { get; set; }
    }
}
