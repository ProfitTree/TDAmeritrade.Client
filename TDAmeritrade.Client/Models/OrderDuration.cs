using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TDAmeritrade.Client.Models
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum OrderDuration
    {
        [EnumMember(Value = "DAY")]
        Day,

        [EnumMember(Value = "GOOD_TILL_CANCEL")]
        GoodTillCancel,

        [EnumMember(Value = "FILL_OR_KILL")]
        FillOrKill
    }
}
