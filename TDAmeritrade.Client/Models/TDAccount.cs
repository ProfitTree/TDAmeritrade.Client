using System.Text.Json.Serialization;

namespace TDAmeritrade.Client.Models
{
    public class TDAccount
    {
        [JsonPropertyName("securitiesAccount")]
        public Account Root { get; set; }
    }
}
