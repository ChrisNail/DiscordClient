using Newtonsoft.Json;
using System;

namespace Discord.API {

    public class GuildIntegration {

        [JsonProperty("id")]
        public string id;

        [JsonProperty("name")]
        public string name;

        [JsonProperty("type")]
        public string type;

        [JsonProperty("enabled")]
        public Boolean enabled;

        [JsonProperty("syncing")]
        public Boolean syncing;

        [JsonProperty("role_id")]
        public string roleId;

        [JsonProperty("expire_behavior")]
        public Int32 expireBehavior;

        [JsonProperty("expire_grace_period")]
        public Int32 expireGracePeriod;

        [JsonProperty("user")]
        public User user;

        [JsonProperty("account")]
        public GuildIntegrationAccount account;

        [JsonProperty("synced_at")]
        public Int32 syncedAt;
    }
}
