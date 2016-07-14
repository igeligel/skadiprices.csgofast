using System.Collections.Generic;
using Newtonsoft.Json;

namespace skadiprices.csgofast.Models.Json
{
    public class CsGoFastRoot
    {
        [JsonProperty(PropertyName = "prices")]
        internal Dictionary<string, decimal> Prices { get; set; }

        [JsonProperty(PropertyName = "bots")]
        internal List<string> Bots { get; set; }
    }
}
