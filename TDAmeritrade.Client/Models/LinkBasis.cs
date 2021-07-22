using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TDAmeritrade.Client.Models
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum LinkBasis
    {
        Manual,
        Base,
        Trigger,
        Last,
        Bid,
        Ask,

        [EnumMember(Value = "ASK_BID")]
        AskBid,
        Mark,
        Average
    }
}
