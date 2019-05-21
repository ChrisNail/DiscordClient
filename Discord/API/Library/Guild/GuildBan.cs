using Newtonsoft.Json;

namespace Discord.API.Library {

    public class GuildBan {

        /**
         * Ban reason.
         */
        [JsonProperty("reason")]
        public string reason;

        /**
         * Banned User.
         */
        [JsonProperty("user")]
        public User user;
    }
}
