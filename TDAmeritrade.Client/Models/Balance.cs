namespace TDAmeritrade.Client.Models
{
    public class Balance
    {
        public bool IsInCall { get; set; }
        public decimal AccruedInterest { get; set; }
        public decimal AvailableFunds { get; set; }
        public decimal AvailableFundsNonMarginableTrade { get; set; }
        public decimal BondValue { get; set; }
        public decimal BuyingPower { get; set; }
        public decimal BuyingPowerNonMarginableTrade { get; set; }
        public decimal CashBalance { get; set; }
        public decimal CashReceipts { get; set; }
        public decimal DayTradingBuyingPower { get; set; }
        public decimal DayTradingBuyingPowerCall { get; set; }
        public decimal Equity { get; set; }
        public decimal EquityPercentage { get; set; }
        public decimal LiquidationValue { get; set; }
        public decimal LongMarginValue { get; set; }
        public decimal LongMarketValue { get; set; }
        public decimal LongOptionMarketValue { get; set; }
        public decimal MaintenanceCall { get; set; }
        public decimal MaintenanceRequirement { get; set; }
        public decimal MarginBalance { get; set; }
        public decimal MoneyMarketFund { get; set; }
        public decimal MutualFundValue { get; set; }
        public decimal OptionBuyingPower { get; set; }
        public decimal PendingDeposits { get; set; }
        public decimal RegTCall { get; set; }
        public decimal Savings { get; set; }
        public decimal ShortBalance { get; set; }
        public decimal ShortMarginValue { get; set; }
        public decimal ShortMarketValue { get; set; }
        public decimal ShortOptionMarketValue { get; set; }
        public decimal Sma { get; set; }
        public decimal StockBuyingPower { get; set; }
    }
}
