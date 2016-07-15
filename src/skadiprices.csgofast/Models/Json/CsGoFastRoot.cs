using System.Collections.Generic;
using Newtonsoft.Json;

namespace skadiprices.csgofast.Models.Json
{
    /// <summary>
    /// JSON Model for the deserialization of the csgofast
    /// api response.
    /// </summary>
    public class CsGoFastRoot
    {
        /// <summary>
        /// Dictionary of the markethashnames and prices.
        /// </summary>
        [JsonProperty(PropertyName = "prices")]
        internal Dictionary<string, decimal> Prices { get; set; }

        /// <summary>
        /// List of the bots provided by csgofast.
        /// </summary>
        [JsonProperty(PropertyName = "bots")]
        internal List<string> Bots { get; set; }
    }
}
