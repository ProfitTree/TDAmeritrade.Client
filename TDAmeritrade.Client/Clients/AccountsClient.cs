using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.SystemTextJson;
using TDAmeritrade.Client.Models;

namespace TDAmeritrade.Client.Clients.Accounts
{
    public sealed class AccountsClient
    {
        private const string ApiUrl = "https://api.tdameritrade.com/v1/";
        private readonly IRestClient _client;

        public AccountsClient(TDAuth auth)
        {
            _client = new RestClient(ApiUrl) { Authenticator = new JwtAuthenticator(auth.AccessToken) }.UseSystemTextJson(new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<TDAccount> GetAccountAsync(string accountNumber, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest($"accounts/{accountNumber}")
                .AddQueryParameter("fields", "positions,orders");
            var response = await _client.ExecuteGetAsync<TDAccount>(request, cancellationToken);
            if (response.StatusCode == HttpStatusCode.Unauthorized) throw new Exception(response.Content);

            return response.Data;
        }

        public async Task<List<TDAccount>> GetAccountsAsync(CancellationToken cancellationToken = default)
        {
            var request = new RestRequest("accounts")
                .AddQueryParameter("fields", "positions,orders");
            var response = await _client.ExecuteGetAsync<List<TDAccount>>(request, cancellationToken);
            if (response.StatusCode == HttpStatusCode.Unauthorized) throw new Exception(response.Content);

            return response.Data;
        }
    }
}
