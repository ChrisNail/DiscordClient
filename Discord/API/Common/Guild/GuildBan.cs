using Newtonsoft.Json;

namespace Discord.API {

    public class GuildBan {

        [JsonProperty("reason")]
        public string reason;

        [JsonProperty("user")]
        public User user;
    }
}
