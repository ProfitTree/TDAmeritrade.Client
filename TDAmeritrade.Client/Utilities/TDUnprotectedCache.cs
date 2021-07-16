using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace TDAmeritrade.Client.Utilities
{
    public class TDUnprotectedCache : ITDCache
    {
        public async Task SaveAsync<T>(T data, string path, string passPhrase = "password", CancellationToken cancellationToken = default) where T : class, new()
        {
            // Serialize object
            var contents = JsonSerializer.Serialize(data);

            // Save string to file
            await File.WriteAllTextAsync(path, contents, cancellationToken);
        }

        public async Task<T> LoadAsync<T>(string path, string passPhrase = "password", CancellationToken cancellationToken = default) where T : class, new()
        {
            // Make sure file exists
            if (!File.Exists(path)) return new T();

            // Read file contents
            await using var stream = File.OpenRead(path);
            var contents = await new StreamReader(stream).ReadToEndAsync();

            // Return deserialized object
            return JsonSerializer.Deserialize<T>(contents);
        }
    }
}
