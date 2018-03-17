using Newtonsoft.Json;

namespace Discord.API {

    public class EmbedProvider {

        [JsonProperty("name")]
        public string name;

        [JsonProperty("url")]
        public string url;
    }
}
