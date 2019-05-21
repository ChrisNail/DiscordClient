using Newtonsoft.Json;

namespace Discord.API.Rest {

    /**
     * Create Guild Integration parameters
     */
    public class CreateGuildIntegrationParams {

        /**
         * Integration type.
         */
        [JsonProperty("type")]
        public string type;

        /**
         * Integration Snowflake ID.
         */
        [JsonProperty("id")]
        public string id;
    }
}
