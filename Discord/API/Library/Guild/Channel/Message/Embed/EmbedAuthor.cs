using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Author portion of an Embed.
     */
    public class EmbedAuthor {

        /**
         * Author name.
         */
        [JsonProperty("name")]
        public string name;

        /**
         * Author URL.
         */
        [JsonProperty("url")]
        public string url;

        /**
         * Icon URL.
         */
        [JsonProperty("icon_url")]
        public string iconUrl;

        /**
         * Proxied icon URL.
         */
        [JsonProperty("proxy_icon_url")]
        public string proxyIconUrl;
    }
}
