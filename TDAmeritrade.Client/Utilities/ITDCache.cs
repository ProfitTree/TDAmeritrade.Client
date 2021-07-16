using System.Threading;
using System.Threading.Tasks;

namespace TDAmeritrade.Client.Utilities
{
    public interface ITDCache
    {
        Task SaveAsync<T>(T data, string path, string passPhrase = "password", CancellationToken cancellationToken = default) where T : class, new();
        Task<T> LoadAsync<T>(string path, string passPhrase = "password", CancellationToken cancellationToken = default) where T : class, new();
    }
}
