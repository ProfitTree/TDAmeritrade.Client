using System;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace TDAmeritrade.Client.Utilities
{
    public class TDProtectedCache : ITDCache
    {
        public async Task SaveAsync<T>(T data, string path, string passPhrase = "password", CancellationToken cancellationToken = default) where T : class, new()
        {
            // Serialize object
            var dataString = JsonSerializer.Serialize(data);

            // Encrypt object string
            var contents = CipherHelper.Encrypt(dataString, passPhrase);

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
            try
            {
                return JsonSerializer.Deserialize<T>(contents);
            }
            catch (Exception)
            {
                // Decrypt file contents and deserialize
                var decryptedContents = CipherHelper.Decrypt(contents, passPhrase);
                return JsonSerializer.Deserialize<T>(decryptedContents);
            }
        }
    }
}
