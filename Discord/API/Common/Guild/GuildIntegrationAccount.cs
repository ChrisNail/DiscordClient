using Newtonsoft.Json;

namespace Discord.API {

    public class GuildIntegrationAccount {

        [JsonProperty("id")]
        public string id;

        [JsonProperty("name")]
        public string name;
    }
}
