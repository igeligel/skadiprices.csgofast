using skadiprices.csgofast.Factories;
using skadiprices.csgofast.Interfaces;

namespace skadiprices.csgofast
{
    /// <summary>
    /// Class to contact the csgofast pricing api.
    /// </summary>
    public static class SkadiCsGoFast
    {
        /// <summary>
        /// Method to get the prices by the api.
        /// </summary>
        /// <returns>
        /// A list of items which contains the markethashname
        /// and the prices as decimal.
        /// For further reference lookup: <see cref="ISkadiPriceList"/>.
        /// </returns>
        /// <example>
        /// var prices = SkadiCsGoFast.GetPrices();
        /// </example>
        public static ISkadiPriceList GetPrices()
        {
            return PriceListFactory.Create();
        }
    }
}
