using System;

namespace TDAmeritrade.Client.Models
{
    public class ExecutionLeg
    {
        public decimal LegId { get; set; }
        public decimal Quantity { get; set; }
        public decimal MismarkedQuantity { get; set; }
        public decimal Price { get; set; }
        public DateTime Time { get; set; }
    }
}
