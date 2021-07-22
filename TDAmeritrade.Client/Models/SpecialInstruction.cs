using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TDAmeritrade.Client.Models
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum SpecialInstruction
    {
        [EnumMember(Value = "ALL_OR_NONE")]
        AllOrNone,

        [EnumMember(Value = "DO_NOT_REDUCE")]
        DoNotReduce,

        [EnumMember(Value = "ALL_OR_NONE_DO_NOT_REDUCE")]
        AllOrNoneDoNotReduce
    }
}
