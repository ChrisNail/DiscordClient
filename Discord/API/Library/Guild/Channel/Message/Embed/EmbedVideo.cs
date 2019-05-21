using System;
using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Video portion of an Embed.
     */
    public class EmbedVideo {

        /**
         * Source URL of Video.
         */
        [JsonProperty("url")]
        public string url;

        /**
         * Height of Video.
         */
        [JsonProperty("height")]
        public int? height;

        /**
         * Width of Video.
         */
        [JsonProperty("width")]
        public int? width;
    }
}
