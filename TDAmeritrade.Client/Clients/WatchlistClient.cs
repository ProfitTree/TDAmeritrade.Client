using TDAmeritrade.Client.Models;

namespace TDAmeritrade.Client.Clients
{
    public class WatchlistClient
    {
        private readonly TDAuth _auth;

        public WatchlistClient(TDAuth auth)
        {
            _auth = auth;
        }
    }
}
