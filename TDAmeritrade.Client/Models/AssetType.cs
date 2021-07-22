using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TDAmeritrade.Client.Models
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum AssetType
    {
        [EnumMember(Value = "EQUITY")]
        Equity,

        [EnumMember(Value = "OPTION")]
        Option,

        [EnumMember(Value = "INDEX")]
        Index,

        [EnumMember(Value = "MUTUAL_FUND")]
        MutualFund,

        [EnumMember(Value = "CASH_EQUIVALENT")]
        CashEquivalent,

        [EnumMember(Value = "FIXED_INCOME")]
        FixedIncome,

        [EnumMember(Value = "CURRENCY")]
        Currency
    }
}
