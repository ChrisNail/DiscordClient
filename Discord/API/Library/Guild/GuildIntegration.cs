using Newtonsoft.Json;
using System;

namespace Discord.API.Library {

    public class GuildIntegration {

        /**
         * Integration Snowflake ID.
         */
        [JsonProperty("id")]
        public string id;

        /**
         * Integration name.
         */
        [JsonProperty("name")]
        public string name;

        /**
         * Integration type.
         */
        [JsonProperty("type")]
        public string type;

        /**
         * Is Integration enabled.
         */
        [JsonProperty("enabled")]
        public bool? enabled;

        /**
         * Is Integration syncing.
         */
        [JsonProperty("syncing")]
        public bool? syncing;

        /**
         * Role Snowflake ID that Integration uses for "subscribers".
         */
        [JsonProperty("role_id")]
        public string roleId;

        /**
         * Behavior for expiring subsribers.
         */
        [JsonProperty("expire_behavior")]
        public int? expireBehavior;

        /**
         * Grace period before expiring subscribers.
         */
        [JsonProperty("expire_grace_period")]
        public int? expireGracePeriod;

        /**
         * User for Integration.
         */
        [JsonProperty("user")]
        public User user;

        /**
         * Integration Account information.
         */
        [JsonProperty("account")]
        public GuildIntegrationAccount account;

        /**
         * Last synced.
         */
        [JsonProperty("synced_at")]
        public int? syncedAt;
    }
}
