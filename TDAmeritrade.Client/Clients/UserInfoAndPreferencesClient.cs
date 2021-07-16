using TDAmeritrade.Client.Models;

namespace TDAmeritrade.Client.Clients
{
    public class UserInfoAndPreferencesClient
    {
        private readonly TDAuth _auth;

        public UserInfoAndPreferencesClient(TDAuth auth)
        {
            _auth = auth;
        }
    }
}
