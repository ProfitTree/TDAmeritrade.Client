using System;
using System.Collections.Generic;

namespace TDAmeritrade.Client.Models
{
    public class OrderStrategy
    {
        public bool Cancelable { get; set; }
        public bool Editable { get; set; }
        public CancelTime CancelTime { get; set; }
        public ComplexOrderStrategyType ComplexOrderStrategyType { get; set; }
        public DateTime CloseTime { get; set; }
        public DateTime EnteredTime { get; set; }
        public DateTime ReleaseTime { get; set; }
        public decimal ActivationPrice { get; set; }
        public decimal FilledQuantity { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal RemainingQuantity { get; set; }
        public decimal StopPrice { get; set; }
        public decimal StopPriceOffset { get; set; }
        public Exchanges RequestedDestination { get; set; }
        public int AccountId { get; set; }
        public int OrderId { get; set; }
        public LinkBasis PriceLinkBasis { get; set; }
        public LinkBasis StopPriceLinkBasis { get; set; }
        public LinkType PriceLinkType { get; set; }
        public LinkType StopPriceLinkType { get; set; }
        public List<OrderStrategy> ChildOrderStrategies { get; set; }
        public List<OrderActivity> OrderActivityCollection { get; set; }
        public List<OrderLeg> OrderLegCollection { get; set; }
        public List<ReplacingOrderCollection> ReplacingOrderCollection { get; set; }
        public OrderDuration Duration { get; set; }
        public OrderStatus Status { get; set; }
        public OrderStrategyType OrderStrategyType { get; set; }
        public OrderType OrderType { get; set; }
        public Session Session { get; set; }
        public SpecialInstruction SpecialInstruction { get; set; }
        public StopType StopType { get; set; }
        public string DestinationLinkName { get; set; }
        public string StatusDescription { get; set; }
        public string Tag { get; set; }
        public TaxLotMethod TaxLotMethod { get; set; }
    }
}
