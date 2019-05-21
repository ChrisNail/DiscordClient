using System;
using Newtonsoft.Json;

namespace Discord.API.Rest {

    /**
     * Modify a Guild Role's position.
     */
    public class ModifyRolePositionParams {

        /**
         * Role Snowflake ID.
         */
        [JsonProperty("id")]
        public string id;

        /**
         * Role position.
         */
        [JsonProperty("position")]
        public int position;
    }
}
