// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using RestSharp;
using RestSharp.Serializers.SystemTextJson;
using TDAmeritrade.Client.Clients.Accounts;
using TDAmeritrade.Client.JsonNamingPolicies;
using TDAmeritrade.Client.Models;
using TDAmeritrade.Client.Utilities;

namespace TDAmeritrade.Client.Clients
{
    public class TDAmeritradeClient
    {
        // Fields
        private const string AuthPath = "TDClient.auth";
        private readonly IRestClient _client;
        private readonly ITDCache _cache;
        private readonly string _passPhrase;

        // Constructors
        public TDAmeritradeClient()
        {
            _cache = new TDUnprotectedCache();
            _client = new RestClient("https://api.tdameritrade.com/v1/").UseSystemTextJson(new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = new SnakeCaseNamingPolicy()
            });
        }

        public TDAmeritradeClient(ITDCache cache, string passPhrase) : this()
        {
            _cache = cache;
            _passPhrase = passPhrase;
        }

        // Clients
        public AccountsClient Accounts { get; set; }
        public InstrumentsClient Instruments { get; set; }
        public MarketHoursClient MarketHours { get; set; }
        public MoversClient Movers { get; set; }
        public OptionChainsClient OptionChains { get; set; }
        public PriceHistoryClient PriceHistory { get; set; }
        public QuotesClient Quotes { get; set; }
        public TransactionHistoryClient TransactionHistory { get; set; }
        public UserInfoAndPreferencesClient UserInfoAndPreferences { get; set; }
        public WatchlistClient Watchlists { get; set; }

        // Auth
        private TDAuth Auth { get; set; }

        public event Action SignedIn;

        /// <summary>
        /// Returns signin URL. This is used to get your Initial code. The code returned is then used to generate access tokens.
        /// </summary>
        public static string GetSignInUrl(string consumerKey, string redirectUrl = "http://localhost")
        {
            var encodedUri = HttpUtility.UrlEncode(redirectUrl);
            var encodedKey = HttpUtility.UrlEncode(consumerKey);
            return $"https://auth.tdameritrade.com/auth?response_type=code&redirect_uri={encodedUri}&client_id={encodedKey}%40AMER.OAUTHAP";
        }

        public async Task SignInAsync(string consumerKey, string code, string redirectUrl = "http://localhost", CancellationToken cancellationToken = default)
        {
            var decodedCode = HttpUtility.UrlDecode(code);

            // Create request to get new access token
            var request = new RestRequest("oauth2/token");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("grant_type", "authorization_code", ParameterType.GetOrPost);
            request.AddParameter("access_type", "offline", ParameterType.GetOrPost);
            request.AddParameter("client_id", $"{consumerKey}@AMER.OAUTHAP", ParameterType.GetOrPost);
            request.AddParameter("redirect_uri", redirectUrl, ParameterType.GetOrPost);
            request.AddParameter("code", decodedCode, ParameterType.GetOrPost);

            // Get access token
            var response = await _client.ExecutePostAsync<TDAuth>(request, cancellationToken);
            if (!response.IsSuccessful) throw new Exception(response.ErrorMessage);

            // Save access token to cache
            Auth = response.Data;
            Auth.Code = code;
            Auth.ConsumerKey = consumerKey;
            Auth.RedirectUrl = redirectUrl;
            Auth.Expires = DateTime.UtcNow.AddSeconds(Auth.ExpiresIn);
            Auth.RefreshTokenExpires = DateTime.UtcNow.AddSeconds(Auth.RefreshTokenExpiresIn);
            await _cache.SaveAsync(Auth, AuthPath, _passPhrase, cancellationToken);
            InitializeClients();
            SignedIn?.Invoke();
        }

        public async Task SignInAsync(CancellationToken cancellationToken = default)
        {
            // Load existing auth tokens if they exist
            Auth ??= await _cache.LoadAsync<TDAuth>(AuthPath, _passPhrase, cancellationToken);
            if (Auth is null) return;

            // Create request to get new access token
            var request = new RestRequest("oauth2/token");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("grant_type", "refresh_token", ParameterType.GetOrPost);
            request.AddParameter("access_type", Auth.RefreshTokenExpires.Subtract(DateTime.UtcNow).Days < 1 ? "offline" : "", ParameterType.GetOrPost);
            request.AddParameter("client_id", $"{Auth.ConsumerKey}@AMER.OAUTHAP", ParameterType.GetOrPost);
            request.AddParameter("refresh_token", Auth.RefreshToken, ParameterType.GetOrPost);

            // Get access token
            var response = await _client.ExecutePostAsync<TDAuth>(request, cancellationToken);
            if (!response.IsSuccessful) throw new Exception(response.ErrorMessage);

            // Save access token to cache
            Auth.AccessToken = response.Data.AccessToken;
            Auth.Expires = DateTime.UtcNow.AddSeconds(response.Data.ExpiresIn);
            await _cache.SaveAsync(Auth, AuthPath, _passPhrase, cancellationToken);
            InitializeClients();
            SignedIn?.Invoke();
        }

        public async Task SignOutAsync(bool keepConsumerKey = false, bool deleteCache = true, CancellationToken cancellationToken = default)
        {
            var auth = new TDAuth { ConsumerKey = keepConsumerKey ? Auth.ConsumerKey : null };

            if (deleteCache) await _cache.SaveAsync(auth, AuthPath, _passPhrase, cancellationToken);
        }

        private void InitializeClients()
        {
            Accounts = new AccountsClient(Auth);
            Instruments = new InstrumentsClient(Auth);
            MarketHours = new MarketHoursClient(Auth);
            Movers = new MoversClient(Auth);
            OptionChains = new OptionChainsClient(Auth);
            PriceHistory = new PriceHistoryClient(Auth);
            Quotes = new QuotesClient(Auth);
            TransactionHistory = new TransactionHistoryClient(Auth);
            UserInfoAndPreferences = new UserInfoAndPreferencesClient(Auth);
            Watchlists = new WatchlistClient(Auth);
        }
    }
}
