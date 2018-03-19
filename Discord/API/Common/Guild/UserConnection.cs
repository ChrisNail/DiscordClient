using Newtonsoft.Json;

namespace Discord.API {

    public class UserConnection {

        [JsonProperty("id")]
        public string id;

        [JsonProperty("name")]
        public string name;

        [JsonProperty("type")]
        public string type;

        [JsonProperty("revoked")]
        public Boolean revoked;

        [JsonProperty("integrations")]
        public GuildIntegration[] integrations;
    }
}
