using TDAmeritrade.Client.Models;

namespace TDAmeritrade.Client.Clients
{
    public class MarketHoursClient
    {
        private readonly TDAuth _auth;

        public MarketHoursClient(TDAuth auth)
        {
            _auth = auth;
        }
    }
}
