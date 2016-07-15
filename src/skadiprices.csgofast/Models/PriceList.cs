using System.Collections.Generic;
using skadiprices.csgofast.Interfaces;

namespace skadiprices.csgofast.Models
{
    /// <summary>
    /// Implementation of the SkadiPriceList interface.
    /// Lookup: <see cref="ISkadiPriceList"/>.
    /// </summary>
    public class PriceList: ISkadiPriceList
    {
        /// <summary>
        /// List containing the items of csgofast.
        /// </summary>
        public List<ISkadiPriceItem> Items { get; set; }
    }
}
