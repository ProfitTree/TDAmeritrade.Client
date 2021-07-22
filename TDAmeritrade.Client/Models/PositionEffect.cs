using System.Text.Json.Serialization;

namespace TDAmeritrade.Client.Models
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum PositionEffect
    {
        Opening,
        Closing,
        Automatic
    }
}
