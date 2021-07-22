using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TDAmeritrade.Client.Models
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum QuantityType
    {
        [EnumMember(Value = "ALL_SHARES")]
        AllShares,
        Dollars,
        Shares
    }
}
