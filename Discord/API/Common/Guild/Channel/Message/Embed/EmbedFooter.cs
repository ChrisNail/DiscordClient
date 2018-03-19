using Newtonsoft.Json;

namespace Discord.API {

    [JsonObject("footer")]
    public class EmbedFooter {

        [JsonProperty("text")]
        public string text;

        [JsonProperty("icon_url")]
        public string iconUrl;

        [JsonProperty("proxy_icon_url")]
        public string proxyIconUrl;
    }
}
