using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Assets for an Activity.
     */
    public class ActivityAssets {

        /**
         * Large image Snowflake ID.
         */
        [JsonProperty("large_image")]
        public string largeImage;

        /**
         * Large image text.
         */
        [JsonProperty("large_text")]
        public string largeText;

        /**
         * Small image Snowflake ID.
         */
        [JsonProperty("small_image")]
        public string smallImage;

        /**
         * Small image text.
         */
        [JsonProperty("small_text")]
        public string smallText;
    }
}
