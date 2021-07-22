using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TDAmeritrade.Client.Models
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum Instruction
    {
        Buy,
        Sell,

        [EnumMember(Value = "BUY_TO_COVER")]
        BuyToCover,

        [EnumMember(Value = "SELL_SHORT")]
        SellShort,

        [EnumMember(Value = "BUY_TO_OPEN")]
        BuyToOpen,

        [EnumMember(Value = "BUY_TO_CLOSE")]
        BuyToClose,

        [EnumMember(Value = "SELL_TO_OPEN")]
        SellToOpen,

        [EnumMember(Value = "SELL_TO_CLOSE")]
        SellToClose,
        Exchange
    }
}
