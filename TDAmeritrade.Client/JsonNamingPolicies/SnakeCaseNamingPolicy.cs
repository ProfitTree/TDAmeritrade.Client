using System.Text.Json;
using TDAmeritrade.Client.Extensions;

namespace TDAmeritrade.Client.JsonNamingPolicies
{
    public class SnakeCaseNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name) => name.ToSnakeCase();
    }
}
