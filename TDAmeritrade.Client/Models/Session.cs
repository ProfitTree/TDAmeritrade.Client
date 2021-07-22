// ReSharper disable InconsistentNaming

using System.Text.Json.Serialization;

namespace TDAmeritrade.Client.Models
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum Session
    {
        Normal,
        AM,
        PM,
        Seamless
    }
}
