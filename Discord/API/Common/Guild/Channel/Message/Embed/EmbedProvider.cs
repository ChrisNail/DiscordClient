using Newtonsoft.Json;

namespace Discord.API {

    [JsonObject("provider")]
    public class EmbedProvider {

        [JsonProperty("name")]
        public string name;

        [JsonProperty("url")]
        public string url;
    }
}
