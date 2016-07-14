using Newtonsoft.Json;
using skadiprices.csgofast.Models;
using skadiprices.csgofast.Models.Json;
using System.Collections.Generic;
using skadiprices.csgofast.Interfaces;

namespace skadiprices.csgofast.Factories
{
    internal class PriceListFactory
    {
        internal static PriceList Create()
        {
            var responseBody =
                RequestFactory.Create().Content.ReadAsStringAsync().Result;
            var csgoFastRoot = JsonConvert.DeserializeObject<CsGoFastRoot>(responseBody);
            return ConvertCsGoFastRootToPriceList(csgoFastRoot);
        }

        private static PriceList ConvertCsGoFastRootToPriceList(
            CsGoFastRoot csGoFastRoot)
        {
            var priceList = new PriceList();
            priceList.Items = new List<ISkadiPriceItem>();
            foreach (KeyValuePair<string, decimal> entry in csGoFastRoot.Prices)
            {
                priceList.Items.Add(new CsGoFastItem
                {
                    MarketHashName = entry.Key,
                    Price = entry.Value
                });
            }
            return priceList;
        }
    }
}
