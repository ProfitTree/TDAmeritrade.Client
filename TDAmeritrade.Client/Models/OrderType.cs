using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TDAmeritrade.Client.Models
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum OrderType
    {
        [EnumMember(Value = "MARKET")]
        Market,

        [EnumMember(Value = "LIMIT")]
        Limit,

        [EnumMember(Value = "STOP")]
        Stop,

        [EnumMember(Value = "STOP_LIMIT")]
        StopLimit,

        [EnumMember(Value = "TRAILING_STOP")]
        TrailingStop,

        [EnumMember(Value = "MARKET_ON_CLOSE")]
        MarketOnClose,

        [EnumMember(Value = "EXERCISE")]
        Exercise,

        [EnumMember(Value = "TRAILING_STOP_LIMIT")]
        TrailingStopLimit,

        [EnumMember(Value = "NET_DEBIT")]
        NetDebit,

        [EnumMember(Value = "NET_CREDIT")]
        NetCredit,

        [EnumMember(Value = "NET_ZERO")]
        NetZero
    }
}
