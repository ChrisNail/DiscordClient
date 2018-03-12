
namespace Discord.API.Controller {

    public class GuildController {


        public static async Task<Guild> getGuild(DiscordClient client, string guildId) {
            Guild guild = null;
            HttpResponseMessage response = await DiscordClient.getClient().GetAsync(DiscordClient.BASE_URL + string.Format(GuildEndpoints.GET_GUILD, guildId));
            if (response.IsSuccessStatusCode) {
                string result = await response.Content.ReadAsStringAsync();
                guild = JsonConvert.DeserializeObject<Guild>(result);
            }

            return guild;
        }


    }

    class GuildEndpoints {

        public static readonly string CREATE_GUILD = "/guilds";

        public static readonly string GET_GUILD = "/guilds/{0}";

        public static readonly string LIST_CHANNELS = "/guilds/{0}/channels";

        public static readonly string LIST_MEMBERS = "/guilds/{0}/members";

        public static readonly string GET_MEMBER = "/guilds/{0}/members/{1}";
    }
}