using RestSharp;

namespace TDAmeritrade.Client
{
    public class TDAmeritradeClient
    {
        private readonly RestClient _client;
        private readonly string _consumerKey;

        public TDAmeritradeClient(string consumerKey)
        {
            _client = new RestClient("https://auth.tdameritrade.com/auth");
            _consumerKey = consumerKey;
        }
    }
}
