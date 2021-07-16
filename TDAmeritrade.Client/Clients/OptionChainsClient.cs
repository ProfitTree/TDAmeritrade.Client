using TDAmeritrade.Client.Models;

namespace TDAmeritrade.Client.Clients
{
    public class OptionChainsClient
    {
        private readonly TDAuth _auth;

        public OptionChainsClient(TDAuth auth)
        {
            _auth = auth;
        }
    }
}
