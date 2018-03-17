using Newtonsoft.Json;

namespace Discord.API {

    public class GuildIntegration {

        [JsonProperty("id")]
        public string id;

        [JsonProperty("name")]
        public string name;

        [JsonProperty("type")]
        public string type;

        [JsonProperty("enabled")]
        public bool enabled;

        [JsonProperty("syncing")]
        public bool syncing;

        [JsonProperty("role_id")]
        public string roleId;

        [JsonProperty("expire_behavior")]
        public int expireBehavior;

        [JsonProperty("expire_grace_period")]
        public int expireGracePeriod;

        [JsonProperty("user")]
        public User user;

        [JsonProperty("account")]
        public GuildIntegrationAccount account;

        [JsonProperty("synced_at")]
        public int syncedAt;
    }
}
