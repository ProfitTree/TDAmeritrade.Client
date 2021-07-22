using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TDAmeritrade.Client.Models
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum PositionType
    {
        [EnumMember(Value = "NOT_APPLICABLE")]
        NotApplicable,

        [EnumMember(Value = "OPEN_END_NON_TAXABLE")]
        OpenEndNonTaxable,

        [EnumMember(Value = "OPEN_END_TAXABLE")]
        OpenEndTaxable,

        [EnumMember(Value = "NO_LOAD_NON_TAXABLE")]
        NoLoadNonTaxable,

        [EnumMember(Value = "NO_LOAD_TAXABLE")]
        NoLoadTaxable,

        [EnumMember(Value = "SAVINGS")]
        Savings,
        
        [EnumMember(Value = "MONEY_MARKET_FUND")]
        MoneyMarketFund,

        [EnumMember(Value = "VANILLA")]
        Vanilla,

        [EnumMember(Value = "BINARY")]
        Binary,

        [EnumMember(Value = "BARRIER")]
        Barrier
    }
}
