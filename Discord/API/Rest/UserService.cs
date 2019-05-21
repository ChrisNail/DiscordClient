using System;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Discord.API.Library;
using Discord.API.Rest;
using System.Collections.Generic;

namespace Discord.API.Rest {

    public class UserService {

        /**
         * Get the current User.
         */
        public static async Task<User> getCurrentUser() {
            string url = DiscordClient.BASE_URL + Endpoints.USERS + Endpoints.CURRENT_USER;
            string result = await DiscordClient.getAsync(url);

            User user = null;
            if (result != null) {
                user = JsonConvert.DeserializeObject<User>(result);
            }

            return user;
        }

        /**
         * Get a User by Snowflake ID.
         */
        public static async Task<User> getUser(string userId) {
            string url = DiscordClient.BASE_URL + Endpoints.USERS + string.Format(Endpoints.PARAMETER, userId);
            string result = await DiscordClient.getAsync(url);

            User user = null;
            if (result != null) {
                user = JsonConvert.DeserializeObject<User>(result);
            }

            return user;
        }

        /**
         * Modify the Current User's username or avatar.
         */
        public static async Task<User> modifyCurrentUser(ModifyCurrentUserParams currentUserParams) {
            string url = DiscordClient.BASE_URL + Endpoints.USERS + Endpoints.CURRENT_USER;
            string result = await DiscordClient.patchAsync(url, null, currentUserParams);

            User user = null;
            if (result != null) {
                user = JsonConvert.DeserializeObject<User>(result);
            }

            return user;
        }

        /**
         * Get the list of Guilds the current User is a part of.
         */
        public static async Task<Guild[]> getCurrentUserGuilds(string before = null, string after = null, int? limit = null) {
            string url = DiscordClient.BASE_URL + Endpoints.USERS + Endpoints.CURRENT_USER  + Endpoints.GUILDS;
            Dictionary<string, object> queryList = new Dictionary<string, object>() {
                { "before", before },
                { "after", after },
                { "limit", limit }
            };

            string result = await DiscordClient.getAsync(url, queryList);

            Guild[] guilds = null;
            if (result != null) {
                guilds = JsonConvert.DeserializeObject<Guild[]>(result);
            }

            return guilds;
        }

        /**
         * Leave a Guild by Guild Snowflake ID.
         */
        public static async Task<bool> leaveGuild(string guildId) {
            string url = DiscordClient.BASE_URL + Endpoints.USERS + Endpoints.CURRENT_USER + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId);
            string result = await DiscordClient.deleteAsync(url);

            bool success = false;
            if(result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Get a list of User Direct Messages
         * Discord API states that this method is deprecated for Bots.
         */
        public static async Task<Channel[]> getUserDMs() {
            string url = DiscordClient.BASE_URL + Endpoints.USERS + Endpoints.CURRENT_USER + Endpoints.CHANNELS;
            string result = await DiscordClient.getAsync(url);

            Channel[] channels = null;
            if (result != null) {
                channels = JsonConvert.DeserializeObject<Channel[]>(result);
            }

            return channels;
        }

        /**
         * Create a new Direct Message Channel with a User.
         * Returns a DM Channel object.
         */
        public static async Task<Channel> createDM(CreateDMParams messageParams) {
            string url = DiscordClient.BASE_URL + Endpoints.USERS + Endpoints.CURRENT_USER + Endpoints.CHANNELS;
            string result = await DiscordClient.postAsync(url, null, messageParams);

            Channel channel = null;
            if(result != null) {
                channel = JsonConvert.DeserializeObject<Channel>(result);
            }

            return channel;
        }
    }
}
