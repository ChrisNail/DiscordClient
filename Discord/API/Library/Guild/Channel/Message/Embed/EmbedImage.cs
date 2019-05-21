using System;
using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Image portion of an Embed.
     */
    public class EmbedImage {

        /**
         * Source URL of Image.
         */
        [JsonProperty("url")]
        public string url;

        /**
         * Proxied URL of Image.
         */
        [JsonProperty("proxy_url")]
        public string proxyUrl;

        /**
         * Height of Image.
         */
        [JsonProperty("height")]
        public int? height;

        /**
         * Width of Image.
         */
        [JsonProperty("width")]
        public int? width;
    }
}
