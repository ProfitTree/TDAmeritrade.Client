using TDAmeritrade.Client.Models;

namespace TDAmeritrade.Client.Clients
{
    public class MoversClient
    {
        private readonly TDAuth _auth;

        public MoversClient(TDAuth auth)
        {
            _auth = auth;
        }
    }
}
