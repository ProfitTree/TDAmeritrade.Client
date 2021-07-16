using TDAmeritrade.Client.Models;

namespace TDAmeritrade.Client.Clients
{
    public class TransactionHistoryClient
    {
        private readonly TDAuth _auth;

        public TransactionHistoryClient(TDAuth auth)
        {
            _auth = auth;
        }
    }
}
