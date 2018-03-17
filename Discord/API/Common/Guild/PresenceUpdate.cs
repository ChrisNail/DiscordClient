using Newtonsoft.Json;

namespace Discord.API {

    public class PresenceUpdate {

        [JsonProperty("user")]
        public User user;

        [JsonProperty("roles")]
        public string[] roles;

        [JsonProperty("game")]
        public Activity game;

        [JsonProperty("guild_id")]
        public string guildId;

        [JsonProperty("status")]
        public string status;
    }
}
