namespace skadiprices.csgofast.Interfaces
{
    public interface ISkadiPriceItem
    {
        string MarketHashName { get; set; }
        decimal Price { get; set; }
    }
}
