using Newtonsoft.Json;

namespace Discord.API.Rest {

    /**
     * Modify a Guild Channel permissions for a User or Role.
     */
    public class ModifyChannelPermissionParams {

        /**
         * Bitwise value of allowed permissions.
         */
        [JsonProperty("allow")]
        public int allow;

        /**
         * Bitwise value of denied permissions.
         */
        [JsonProperty("deny")]
        public int deny;

        /**
         * "Member" for a User or "Role" for a Role.
         */
        [JsonProperty("type")]
        public int type;
    }
}
