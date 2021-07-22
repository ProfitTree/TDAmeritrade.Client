namespace TDAmeritrade.Client.Models
{
    public class OptionDeliverable
    {
        public AssetType AssetType { get; set; }
        public CurrencyType CurrencyType { get; set; }
        public decimal DeliverableUnits { get; set; }
        public string Symbol { get; set; }
    }
}
