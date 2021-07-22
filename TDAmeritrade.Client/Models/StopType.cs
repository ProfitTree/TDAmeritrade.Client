using System.Text.Json.Serialization;

namespace TDAmeritrade.Client.Models
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum StopType
    {
        Standard,
        Bid,
        Ask,
        Last,
        Mark
    }
}
