using Newtonsoft.Json;

namespace Discord.API {

    [JsonObject("invite")]
    public class Invite {

        [JsonProperty("code")]
        public string code;

        [JsonProperty("guild")]
        public Guild guild;

        [JsonProperty("channel")]
        public Channel chanel;
    }
}
