using skadiprices.csgofast.Interfaces;

namespace skadiprices.csgofast.Models
{
    public class CsGoFastItem : ISkadiPriceItem
    {
        public string MarketHashName { get; set; }
        public decimal Price { get; set; }
    }
}
