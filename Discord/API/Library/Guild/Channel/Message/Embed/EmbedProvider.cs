using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Provider portion of an Embed.
     */
    public class EmbedProvider {

        /**
         * Provider name.
         */
        [JsonProperty("name")]
        public string name;

        /**
         * Provider URL.
         */
        [JsonProperty("url")]
        public string url;
    }
}
