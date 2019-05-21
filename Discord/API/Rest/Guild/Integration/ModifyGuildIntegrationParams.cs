using Newtonsoft.Json;

namespace Discord.API.Rest {

    /**
     * Modify behavior and settings of an Integration for a Guild.
     */
    public class ModifyGuildIntegrationParams {

        /**
         * Behvaior when an Integration subscription lapses.
         */
        [JsonProperty("expire_behavior")]
        public int? expireBehavior;

        /**
         * Period (in seconds) where Integration will ignore lapsed subscriptions.
         */
        [JsonProperty("expire_grace_period")]
        public int? expireGracePeriod;

        /**
         * Whether emoticons should be synced for Integration.
         */
        [JsonProperty("enable_emoticons")]
        public bool enableEmoticons;
    }
}
