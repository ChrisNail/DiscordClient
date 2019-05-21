using System;
using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Thumbnail portion of an Embed.
     */
    public class EmbedThumbnail {

        /**
         * Source URL of Thumbnail.
         */
        [JsonProperty("url")]
        public string url;

        /**
         * Proxied URL of Thumbnail.
         */
        [JsonProperty("proxy_url")]
        public string proxyUrl;

        /**
         * Height of Thumbnail.
         */
        [JsonProperty("height")]
        public int? height;

        /**
         * Width of Thumbnail.
         */
        [JsonProperty("width")]
        public int? width;
    }
}
