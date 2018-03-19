using Newtonsoft.Json;

namespace Discord.API {

    [JsonObject("author")]
    public class EmbedAuthor {

        [JsonProperty("name")]
        public string name;

        [JsonProperty("url")]
        public string url;

        [JsonProperty("icon_url")]
        public string iconUrl;

        [JsonProperty("proxy_icon_url")]
        public string proxyIconUrl;
    }
}
