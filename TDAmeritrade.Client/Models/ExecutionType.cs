using System.Text.Json.Serialization;

namespace TDAmeritrade.Client.Models
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum ExecutionType
    {
        Fill
    }
}
