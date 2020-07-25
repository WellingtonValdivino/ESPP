using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace core.Api.Model.Components
{
    public class SelectComponent
    {
        public List<SelectItem> Select()
        {
            List<SelectItem> lista = new List<SelectItem>();
            return lista;
        }
    }

    public class SelectItem
    {
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "Value")]
        public string Value { get; set; }

    }
}