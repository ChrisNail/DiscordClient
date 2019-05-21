using Newtonsoft.Json;

namespace Discord.API.Library {

    public class PresenceUpdate {

        /**
         * User object.
         */
        [JsonProperty("user")]
        public User user;

        /**
         * List of Role Snowflake IDs for User.
         */
        [JsonProperty("roles")]
        public string[] roles;

        /**
         * Users current Activity.
         */
        [JsonProperty("game")]
        public Activity game;

        /**
         * Guild Snowflake ID
         */
        [JsonProperty("guild_id")]
        public string guildId;

        /**
         * User status.
         */
        [JsonProperty("status")]
        public string status;

        /**
         * List of current activities
         */
        [JsonProperty("activities")]
        public Activity[] activities;

        /**
         * User's platform-dependent status.
         */
        [JsonProperty("client_status")]
        public ClientStatus clientStatus;
    }
}
