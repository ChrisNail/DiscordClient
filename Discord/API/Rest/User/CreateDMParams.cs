using Newtonsoft.Json;

namespace Discord.API.Rest {

    /**
     * Parameter to create a Direct Message with a User.
     */
    public class CreateDMParams {

        /**
         * Recipient User Snowflake ID.
         */
        [JsonProperty("recipient_id")]
        public string recipientId;
    }
}
