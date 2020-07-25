using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace core.Domain.Entities
{
    public class PessoaFisica
    {
        [JsonProperty(PropertyName="idPessoaFisica")]
        public int idPessoaFisica { get; set; } 

        [JsonProperty(PropertyName="nomePessoaFisica")]
        public string nomePessoaFisica { get; set; } 
        
        [JsonProperty(PropertyName="cpfPessoaFisica")]
        public string cpfPessoaFisica { get; set; } 
    }
}

