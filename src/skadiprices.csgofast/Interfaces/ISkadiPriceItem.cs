namespace skadiprices.csgofast.Interfaces
{
    /// <summary>
    /// Interface for providing items via the price api.
    /// </summary>
    public interface ISkadiPriceItem
    {
        /// <summary>
        /// Market Hash Name provided by steam for the item.
        /// </summary>
        string MarketHashName { get; set; }
        
        /// <summary>
        /// Price provided by the pricing api.
        /// </summary>
        decimal Price { get; set; }
    }
}
