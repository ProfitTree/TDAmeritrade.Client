namespace TDAmeritrade.Client.Models
{
    public class InitialBalances : Balance
    {
        public decimal AccountValue { get; set; }
        public decimal CashAvailableForTrading { get; set; }
        public decimal DayTradingEquityCall { get; set; }
        public decimal LongStockValue { get; set; }
        public decimal Margin { get; set; }
        public decimal MarginEquity { get; set; }
        public decimal ShortStockValue { get; set; }
        public decimal TotalCash { get; set; }
        public decimal UnsettledCash { get; set; }
    }
}
