// ReSharper disable InconsistentNaming

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TDAmeritrade.Client.Models
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum Exchanges
    {
        INET,

        [EnumMember(Value = "ECN_ARCA")]
        ECNARCA,
        CBOE,
        AMEX,
        PHLX,
        ISE,
        BOX,
        NYSE,
        NASDAQ,
        BATS,
        C2,
        Auto
    }
}
