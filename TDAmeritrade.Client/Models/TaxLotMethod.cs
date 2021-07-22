// ReSharper disable InconsistentNaming

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TDAmeritrade.Client.Models
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum TaxLotMethod
    {
        FIFO,
        LIFO,

        [EnumMember(Value = "HIGH_COST")]
        HighCost,

        [EnumMember(Value = "LOW_COST")]
        LowCost,

        [EnumMember(Value = "AVERAGE_COST")]
        AverageCost,

        [EnumMember(Value = "SPECIFIC_LOT")]
        SpecificLot
    }
}
