using TDAmeritrade.Client.Models;

namespace TDAmeritrade.Client.Clients
{
    public class PriceHistoryClient
    {
        private readonly TDAuth _auth;

        public PriceHistoryClient(TDAuth auth)
        {
            _auth = auth;
        }
    }
}
