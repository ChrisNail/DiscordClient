using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Http;
using System.Threading.Tasks;

namespace Discord {

    public class Guild {

        /*
         * Snowflake ID
         */
        [JsonProperty("id")]
        public string id;

        /*
         * Name
         */
        [JsonProperty("name")]
        public string name;

        /*
         * Icon hash
         */
        [JsonProperty("icon")]
        public string icon;

        /*
         * Splash hash
         */
        [JsonProperty("splash")]
        public string splash;

        /*
         * Current User is owner
         */
        [JsonProperty("owner")]
        public bool owner;

        /*
         * Snowflake ID of the owner
         */
        [JsonProperty("owner_id")]
        public string ownerId;

        /*
         * Current User permissions
         */
        [JsonProperty("permissions")]
        public int permissions;

        /*
         * Voice region ID
         */
        [JsonProperty("region")]
        public string region;

        /*
         * Snowflake ID of AFK Channel
         */
        [JsonProperty("afk_channel_id")]
        public string afkChannelId;

        /*
         * AFK timeout in seconds
         */
        [JsonProperty("afk_timeout")]
        public int afkTimeout;

        /*
         * Is Guild embeddable
         */
        [JsonProperty("embed_enabled")]
        public bool embedEnabled;

        /*
         * Snowflake ID of embedded channel
         */
        [JsonProperty("embed_channel_id")]
        public string embedChannelId;

        /*
         * Verification Level
         */
        [JsonProperty("verification_level")]
        public int verificationLevel;

        /*
         * Default Message notifications level
         */
        [JsonProperty("default_message_notifications")]
        public int defaultMessageNotifications;

        /*
         * Explicit content filter level
         */
        [JsonProperty("explicit_content_filter")]
        public int explicitContentFilter;

        /*
         * List of Roles
         */
        //[JsonProperty("roles")]
        //public List<Role> roles;

        /*
         * List of Custom Emojis
         */
        //[JsonProperty("emojis")]
        //public List<Emoji> emojis;

        /*
         * List of enabled features
         */
        [JsonProperty("features")]
        public List<string> features;

        /*
         * Required MFA level
         */
        [JsonProperty("mfa_level")]
        public int mfaLevel;

        /*
         * Snowflake ID of Guild creator (Bot)
         */
        [JsonProperty("application_id")]
        public string applicationId;

        /*
         * Widget enabled
         */
        [JsonProperty("widget_enabled")]
        public bool widgetEnabled;

        /*
         * Snowflake ID for Widget Channel
         */
        [JsonProperty("widget_channel_id")]
        public string widgetChannelId;

        /*
         * Snowflake ID for System Channel
         */
        [JsonProperty("system_channel_id")]
        public string systemChannelId;

        /*
         * Guild creation timestamp
         */
        [JsonProperty("joined_at")]
        public int createDate;

        /*
         * Large Guild flag
         */
        [JsonProperty("large")]
        public bool large;

        /*
         * Guild unavailable flag
         */
        [JsonProperty("unavailable")]
        public bool unavailable;

        /*
         * Total Guild member count
         */
        [JsonProperty("member_count")]
        public int memberCount;

        /*
         * List of Voice states
         */
        //[JsonProperty("voice_states")]
        //public List<Voice> voiceStates;

        /*
         * List of Guild Members
         */
        [JsonProperty("members")]
        public List<GuildMember> members;

        /*
         * List of Channels
         */
        [JsonProperty("channels")]
        public List<Channel> channels;

        /*
         * List of Presence Updates on Guild Users
         */
        //[JsonProperty("presences")]
        //public List<PresenceUpdate> presences;

        /*
         * Creates an empty Guild object
         */
        public Guild() {
            features = new List<string>();
            members = new List<GuildMember>();
            channels = new List<Channel>();
        }


        public static async Task<Guild> getGuild(string guildId) {
            Guild guild = null;
            HttpResponseMessage response = await DiscordClient.getClient().GetAsync(DiscordClient.BASE_URL + string.Format(GuildEndpoints.GET_GUILD, guildId));
            if (response.IsSuccessStatusCode) {
                NameValueCollection result = await response.Content.ReadAsFormDataAsync();
                Console.WriteLine(result);
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
