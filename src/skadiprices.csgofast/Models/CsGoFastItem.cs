using skadiprices.csgofast.Interfaces;

namespace skadiprices.csgofast.Models
{
    /// <summary>
    /// Implementation of the ISkadiPriceItem interface.
    /// Lookup: <see cref="ISkadiPriceItem"/>.
    /// </summary>
    public class CsGoFastItem : ISkadiPriceItem
    {
        /// <summary>
        /// Market Hash Name given by csgofast.
        /// </summary>
        public string MarketHashName { get; set; }

        /// <summary>
        /// Price given by csgofast.
        /// </summary>
        public decimal Price { get; set; }
    }
}
