using System.Collections.Generic;

namespace skadiprices.csgofast.Interfaces
{
    /// <summary>
    /// Class which includes the prices given by the api.
    /// </summary>
    public interface ISkadiPriceList
    {
        /// <summary>
        /// List of items where the information are saved.
        /// </summary>
        List<ISkadiPriceItem> Items { get; set; }
    }
}
