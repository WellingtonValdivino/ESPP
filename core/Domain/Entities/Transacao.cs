using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace core.Domain.Entities
{
    public class Transacao
    {
        [JsonProperty(PropertyName="idTransacao")]
        public int idTransacao { get; set; } 

        [JsonProperty(PropertyName="dataTransacao")]
        public DateTime dataTransacao { get; set; } 

        [JsonProperty(PropertyName="tipoTransacao")]
        public string tipoTransacao { get; set; } 

        [JsonProperty(PropertyName="valorTransacao")]
        public float valorTransacao { get; set; } 
    }
}

