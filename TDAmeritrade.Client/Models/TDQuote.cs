namespace TDAmeritrade.Client.Models
{
    public class TDQuote
    {
        public string Symbol { get; set; }
        public string Description { get; set; }
        public string ExchangeName { get; set; }
        public string SecurityStatus { get; set; }
        public decimal LastPrice { get; set; }
    }
}
