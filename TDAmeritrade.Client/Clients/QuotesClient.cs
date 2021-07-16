using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.SystemTextJson;
using TDAmeritrade.Client.Models;

namespace TDAmeritrade.Client.Clients
{
    public class QuotesClient
    {
        private const string ApiUrl = "https://api.tdameritrade.com/v1/marketdata/";
        private readonly IRestClient _client;
        private readonly TDAuth _auth;

        public QuotesClient(TDAuth auth)
        {
            _auth = auth;
            _client = new RestClient(ApiUrl) { Authenticator = new JwtAuthenticator(auth.AccessToken) }.UseSystemTextJson(new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<List<TDQuote>> GetQuotesAsync(IEnumerable<string> symbols, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest("quotes");
            request.AddQueryParameter("apikey", _auth.ConsumerKey);
            request.AddQueryParameter("symbol", string.Join(",", symbols));
            var response = await _client.ExecuteGetAsync<List<TDQuote>>(request, cancellationToken);
            if (response.StatusCode == HttpStatusCode.Unauthorized) throw new Exception(response.Content);

            var doc = JsonDocument.Parse(response.Content);
            return doc.RootElement.EnumerateObject().Select(x => JsonSerializer.Deserialize<TDQuote>(x.Value.GetRawText(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true })).ToList();
        }
    }
}
