using System.Text.Json.Serialization;

namespace TDAmeritrade.Client.Models
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum AccountType
    {
        Margin,
        Cash
    }
}
