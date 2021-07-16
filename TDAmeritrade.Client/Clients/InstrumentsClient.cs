using TDAmeritrade.Client.Models;

namespace TDAmeritrade.Client.Clients
{
    public class InstrumentsClient
    {
        private readonly TDAuth _auth;

        public InstrumentsClient(TDAuth auth)
        {
            _auth = auth;
        }
    }
}
