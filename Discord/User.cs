using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Discord {

    public class User {

        [JsonProperty("id")]
        public string id;

        [JsonProperty("username")]
        public string username;

        [JsonProperty("discriminator")]
        public string discriminator;

        [JsonProperty("avatar")]
        public string avatar;

        [JsonProperty("bot")]
        public bool bot;

        [JsonProperty("mfa_enabled")]
        public bool mfaEnabled;

        [JsonProperty("verified")]
        public bool verified;

        [JsonProperty("email")]
        public string email;


        public User() {

        }

        public static async Task<User> getCurrentUser() {
            User user = null;
            HttpResponseMessage response = await DiscordClient.getClient().GetAsync(DiscordClient.BASE_URL + UserEndpoints.GET_CURRENT_USER);
            if(response.IsSuccessStatusCode) {
                string result = await response.Content.ReadAsStringAsync();
                user = JsonConvert.DeserializeObject<User>(result);
            }

            return user;
        }


        public static async Task<Guild[]> getCurrentUserGuilds() {
            Guild[] guilds = null;
            HttpResponseMessage response = await DiscordClient.getClient().GetAsync(DiscordClient.BASE_URL + UserEndpoints.GET_USER_GUILDS);
            if(response.IsSuccessStatusCode) {
                string results = await response.Content.ReadAsStringAsync();
                guilds = JsonConvert.DeserializeObject<Guild[]>(results);
            }

            return guilds;
        }
    }

    class UserEndpoints {
        public static readonly string GET_CURRENT_USER = "/users/@me";

        public static readonly string GET_USER = "/users/{0}";

        public static readonly string GET_USER_GUILDS = "/users/@me/guilds";
    }
}
