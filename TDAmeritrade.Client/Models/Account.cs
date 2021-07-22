using System.Collections.Generic;

namespace TDAmeritrade.Client.Models
{
    public class Account
    {
        public AccountType Type { get; set; }
        public bool IsClosingOnlyRestricted { get; set; }
        public bool IsDayTrader { get; set; }
        public CurrentBalances CurrentBalances { get; set; }
        public InitialBalances InitialBalances { get; set; }
        public int RoundTrips { get; set; }
        public List<OrderStrategy> OrderStrategies { get; set; }
        public List<Position> Positions { get; set; }
        public ProjectedBalances ProjectedBalances { get; set; }
        public string AccountId { get; set; }
    }
}
