using Newtonsoft.Json;
using System;

namespace Discord.API {

    [JsonObject("image")]
    public class EmbedImage {

        [JsonProperty("url")]
        public string url;

        [JsonProperty("proxy_url")]
        public string proxyUrl;

        [JsonProperty("height")]
        public Int32 height;

        [JsonProperty("width")]
        public Int32 width;
    }
}
