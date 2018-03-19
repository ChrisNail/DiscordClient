using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Discord.API.Service {

    public class UserService {

        /*
         * 
         */
        public static async Task<User> getCurrentUser() {
            User user = null;
            HttpResponseMessage response = await DiscordClient.getClient().GetAsync(DiscordClient.BASE_URL + UserEndpoints.GET_CURRENT_USER);
            if(response.IsSuccessStatusCode) {
                string result = await response.Content.ReadAsStringAsync();
                user = JsonConvert.DeserializeObject<User>(result);
            }

            return user;
        }

        /*
         * 
         */
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
