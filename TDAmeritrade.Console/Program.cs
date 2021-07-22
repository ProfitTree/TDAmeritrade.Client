using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using TDAmeritrade.Client.Clients;

namespace TDAmeritrade.Console
{
    public class Program
    {
        private static IConfiguration Configuration => new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", false)
            .AddUserSecrets<Program>()
            .Build();

        public static async Task Main(string[] args)
        {
            // Get secret values
            var values = new TDConfig();
            Configuration.Bind("TD", values);

            // Create client and sign in
            var client = new TDAmeritradeClient();
            //var url = TDAmeritradeClient.GetSignInUrl(values.ConsumerKey);
            //System.Console.WriteLine(url);
            //await client.SignInAsync(values.ConsumerKey, values.Code);
            await client.SignInAsync();

            while (true)
            {
                try
                {
                    var accounts = await client.Accounts.GetAccountsAsync();
                    var account = await client.Accounts.GetAccountAsync("124038883");
                    var quotes = await client.Quotes.GetQuotesAsync(new[] { "SPY", "TSLA" });
                    var spy = quotes.First(x => x.Symbol == "SPY");
                    var tsla = quotes.First(x => x.Symbol == "TSLA");
                    System.Console.WriteLine("SPY: {0:C} | TSLA: {1:C}", spy.LastPrice, tsla.LastPrice);
                    Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e);
                    throw;
                }
            }
        }
    }
}
