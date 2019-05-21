using System;
using Newtonsoft.Json;

namespace Discord.API.Rest {

    /**
     * Modify a Guild Role.
     */
    public class ModifyRoleParams {

        /**
         * Role name.
         */
        [JsonProperty("name")]
        public string name;

        /**
         * Bitwise value of the enabled/disabled permissions.
         */
        [JsonProperty("permissions")]
        public int? permissions;

        /**
         * RGB color value.
         */
        [JsonProperty("color")]
        public int? color;

        /**
         * Whether the Role should be displayed in the sidebar.
         */
        [JsonProperty("hoist")]
        public bool? hoist;

        /**
         * Whether the Role should be mentionable.
         */
        [JsonProperty("mentionable")]
        public bool? mentionable;
    }
}
