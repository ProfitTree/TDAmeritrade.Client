using System.Text.Json.Serialization;

namespace TDAmeritrade.Client.Models
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum CurrencyType
    {
        Usd,
        Cad,
        Eur,
        Jpy
    }
}
