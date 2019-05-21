using Newtonsoft.Json;

namespace Discord.API.Library {

    public class GuildIntegrationAccount {

        /**
         * Account Snowflake ID.
         */
        [JsonProperty("id")]
        public string id;

        /**
         * Account name.
         */
        [JsonProperty("name")]
        public string name;
    }
}
