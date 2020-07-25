using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace core.Domain.Entities
{
    public class PessoaJuridica
    {
        [JsonProperty(PropertyName="idPessoaJuridica")]
        public int idPessoaJuridica { get; set; } 

        [JsonProperty(PropertyName="razaoSocialPessoaJuridica")]
        public string razaoSocialPessoaJuridica { get; set; } 

        [JsonProperty(PropertyName="nomeFantasiaPessoaJuridica")]
        public string nomeFantasiaPessoaJuridica { get; set; } 

        [JsonProperty(PropertyName="cnpjPessoaJuridica")]
        public string cnpjPessoaJuridica { get; set; } 
    }
}

