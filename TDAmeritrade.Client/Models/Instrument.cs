using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TDAmeritrade.Client.Models
{
    public class Instrument
    {
        public AssetType AssetType { get; set; }
        public DateTime MaturityDate { get; set; }
        public decimal Factor { get; set; }
        public decimal OptionMultiplier { get; set; }
        public decimal VariableRate { get; set; }
        public List<OptionDeliverable> OptionDeliverables { get; set; }

        [JsonPropertyName("putCall")]
        public OptionSide OptionSide { get; set; }

        public PositionType Type { get; set; }
        public string Cusip { get; set; }
        public string Description { get; set; }
        public string Symbol { get; set; }
        public string UnderlyingSymbol { get; set; }
    }
}
