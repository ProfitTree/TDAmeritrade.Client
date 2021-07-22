using System.Text.Json.Serialization;

namespace TDAmeritrade.Client.Models
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum LinkType
    {
        Value,
        Percent,
        Tick
    }
}
