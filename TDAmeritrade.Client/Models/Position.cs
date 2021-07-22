namespace TDAmeritrade.Client.Models
{
    public class Position
    {
        public decimal AveragePrice { get; set; }
        public decimal MarketValue { get; set; }
        public decimal AgedQuantity { get; set; }
        public decimal CurrentDayProfitLoss { get; set; }
        public decimal CurrentDayProfitLossPercentage { get; set; }
        public decimal LongQuantity { get; set; }
        public decimal SettledLongQuantity { get; set; }
        public decimal SettledShortQuantity { get; set; }
        public decimal ShortQuantity { get; set; }
        public Instrument Instrument { get; set; }
    }
}
