using skadiprices.csgofast.Factories;
using skadiprices.csgofast.Interfaces;

namespace skadiprices.csgofast
{
    public static class SkadiCsGoFast
    {
        public static ISkadiPriceList GetPrices()
        {
            return PriceListFactory.Create();
        }
    }
}
