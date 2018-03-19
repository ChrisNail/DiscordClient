using Discord.API.Rest;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Discord.API.Service {

    public class GuildService {

        /*
         * 
         */
        public static async Task<Guild> getGuild(DiscordClient client, string guildId) {
            Guild guild = null;
            HttpResponseMessage response = await DiscordClient.getClient().GetAsync(DiscordClient.BASE_URL + string.Format(GuildEndpoints.GET_GUILD, guildId));
            if (response.IsSuccessStatusCode) {
                string result = await response.Content.ReadAsStringAsync();
                guild = JsonConvert.DeserializeObject<Guild>(result);
            }

            return guild;
        }

        public static async Task<Guild> modifyGuild(DiscordClient client, string guildId, Guild guildBean) {
            Guild guild = guildBean;
            string parameters = JsonConvert.SerializeObject(guildBean, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            HttpRequestMessage request = new HttpRequestMessage(new HttpMethod("PATCH"), DiscordClient.BASE_URL + string.Format(GuildEndpoints.GET_GUILD, guildId));
            HttpResponseMessage response = await DiscordClient.getClient().SendAsync(request);

            Console.WriteLine(parameters);

            return guild;
        }

        public static async Task<bool> deleteGuild(DiscordClient client, string guildId) {
            HttpResponseMessage response = await DiscordClient.getClient().DeleteAsync(DiscordClient.BASE_URL + string.Format(GuildEndpoints.GET_GUILD, guildId));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }


        public static async Task<Channel[]> getGuildChannels(DiscordClient client, string guildId) {
            Channel[] channels = new Channel[0];
            HttpResponseMessage response = await DiscordClient.getClient().GetAsync(DiscordClient.BASE_URL + string.Format(GuildEndpoints.GET_GUILD_CHANNELS, guildId));
            if (response.IsSuccessStatusCode) {
                string result = await response.Content.ReadAsStringAsync();
                channels = JsonConvert.DeserializeObject<Channel[]>(result);
            }

            return channels;
        }

        public static async Task<Channel> createGuildChannel(DiscordClient client, string guildId, Channel channelBean) {
            Channel channel = null;
            string parameters = JsonConvert.SerializeObject(channelBean, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            HttpResponseMessage response = await DiscordClient.getClient().PostAsJsonAsync<string>(DiscordClient.BASE_URL + string.Format(GuildEndpoints.GET_GUILD_CHANNELS, guildId), parameters);
            if (response.IsSuccessStatusCode) {
                string result = await response.Content.ReadAsStringAsync();
                channel = JsonConvert.DeserializeObject<Channel>(result);
            }

            return channel;
        }

        public static async Task<bool> modifyGuildChannelPositions(DiscordClient client, string guildId, ModifyChannelPositionParams[] channelPositions) {
            string parameters = JsonConvert.SerializeObject(channelPositions);
            HttpRequestMessage request = new HttpRequestMessage(new HttpMethod("PATCH"), DiscordClient.BASE_URL + string.Format(GuildEndpoints.GET_GUILD_CHANNELS, guildId));
            HttpResponseMessage response = await DiscordClient.getClient().SendAsync(request);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    }

    class GuildEndpoints {

        public static readonly string CREATE_GUILD = "/guilds";

        public static readonly string GET_GUILD = "/guilds/{0}";

        public static readonly string GET_GUILD_CHANNELS = "/guilds/{0}/channels";

        public static readonly string LIST_MEMBERS = "/guilds/{0}/members";

        public static readonly string GET_MEMBER = "/guilds/{0}/members/{1}";
    }
}