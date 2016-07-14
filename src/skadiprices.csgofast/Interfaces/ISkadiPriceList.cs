using System.Collections.Generic;

namespace skadiprices.csgofast.Interfaces
{
    public interface ISkadiPriceList
    {
        List<ISkadiPriceItem> Items { get; set; }
    }
}
