using Newtonsoft.Json;

namespace Discord.API.Rest {

    /**
     * Bulk delete Messages parameters
     */
    public class BulkDeleteMessageParams {

        /**
         * List of Message Snowflake IDs.
         */
        [JsonProperty("messages")]
        public string[] messages;
    }
}
