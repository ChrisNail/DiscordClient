using Newtonsoft.Json;

namespace Discord.API {

    public class EmbedImage {

        [JsonProperty("url")]
        public string url;

        [JsonProperty("proxy_url")]
        public string proxyUrl;

        [JsonProperty("height")]
        public int height;

        [JsonProperty("width")]
        public int width;
    }
}
