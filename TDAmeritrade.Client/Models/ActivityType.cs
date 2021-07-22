using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TDAmeritrade.Client.Models
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum ActivityType
    {
        Execution,
        [EnumMember(Value = "ORDER_ACTION")]
        OrderAction
    }
}
