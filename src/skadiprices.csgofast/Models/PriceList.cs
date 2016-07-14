using System.Collections.Generic;
using skadiprices.csgofast.Interfaces;

namespace skadiprices.csgofast.Models
{
    public class PriceList: ISkadiPriceList
    {
        public List<ISkadiPriceItem> Items { get; set; }
    }
}
