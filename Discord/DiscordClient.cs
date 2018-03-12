using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Discord {
    public class DiscordClient {

        public static readonly string BASE_URL = "https://discordapp.com/api/v6";

        private static string token;

        private static HttpClient client = new HttpClient();

        public DiscordClient(string token) {
            DiscordClient.token = token;
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bot", token);
        }

        public static HttpClient getClient() { return client; }
    }
}
