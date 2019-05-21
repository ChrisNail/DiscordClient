using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Message Application.
     */
    public class MessageApplication {

        /**
         * Message Application Snowflake ID.
         */
        [JsonProperty("id")]
        public string id;

        /**
         * Cover image Snowflake ID.
         */
        [JsonProperty("cover_image")]
        public string coverImage;

        /**
         * Message Application description.
         */
        [JsonProperty("description")]
        public string description;

        /**
         * Application icon Snowflake ID.
         */
        [JsonProperty("icon")]
        public string icon;

        /**
         * Application name.
         */
        [JsonProperty("name")]
        public string name;
    }
}
