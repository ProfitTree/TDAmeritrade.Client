namespace TDAmeritrade.Client.Models
{
    public class OrderLeg
    {
        public AssetType OrderLegType { get; set; }
        public decimal LegId { get; set; }
        public decimal Quantity { get; set; }
        public Instruction Instruction { get; set; }
        public Instrument Instrument { get; set; }
        public PositionEffect PositionEffect { get; set; }
        public QuantityType QuantityType { get; set; }
    }
}
