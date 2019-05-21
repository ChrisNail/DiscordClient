using System;
using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Role or User Permission overwrite.
     */
    public class RoleOverwrite {

        /**
         * Role or User Snowflake ID.
         */
        [JsonProperty("id")]
        public string id;

        /**
         * Type (Role or Member)
         */
        [JsonProperty("type")]
        public string type;

        /**
         * Allow permission bit set.
         */
        [JsonProperty("allow")]
        public int? allow;

        /**
         * Deny permission bit set.
         */
        [JsonProperty("deny")]
        public int? deny;
    }
}
