using skadiprices.csgofast.Factories;
using skadiprices.csgofast.Models;

namespace skadiprices.csgofast
{
    public class SkadiCsGoFast
    {
        public static PriceList GetPrices()
        {
            return PriceListFactory.Create();
        }
    }
}
