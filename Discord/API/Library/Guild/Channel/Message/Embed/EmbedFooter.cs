using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Footer portion of an Embed.
     */
    public class EmbedFooter {

        /**
         * Footer text.
         */
        [JsonProperty("text")]
        public string text;

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
