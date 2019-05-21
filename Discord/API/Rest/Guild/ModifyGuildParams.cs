using Newtonsoft.Json;

namespace Discord.API.Rest {

    /**
     * Parameters to modify a Guild
     */
    public class ModifyGuildParams {

        [JsonProperty("name")]
        public string name;

        [JsonProperty("region")]
        public string region;

        [JsonProperty("verification_level")]
        public int? verificationLevel;

        [JsonProperty("default_message_notifications")]
        public int? defaultMessageNotifications;

        [JsonProperty("explicit_content_filter")]
        public int? explicitContentFilter;

        [JsonProperty("afk_channel_id")]
        public string afkChannelId;

        [JsonProperty("afk_timeout")]
        public int? afkTimeout;

        [JsonProperty("icon")]
        public string icon;

        [JsonProperty("owner_id")]
        public string ownerId;

        [JsonProperty("splash")]
        public string splash;

        [JsonProperty("system_channel_id")]
        public string systemChannelId;
    }
}
