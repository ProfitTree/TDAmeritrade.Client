using System.Collections.Generic;

namespace TDAmeritrade.Client.Models
{
    public class OrderActivity
    {
        public ActivityType ActivityType { get; set; }
        public decimal OrderRemainingQuantity { get; set; }
        public decimal Quantity { get; set; }
        public ExecutionType ExecutionType { get; set; }
        public List<ExecutionLeg> ExecutionLegs { get; set; }
    }
}
