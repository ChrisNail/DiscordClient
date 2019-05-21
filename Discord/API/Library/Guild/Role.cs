using System;
using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Guild Permission Role.
     */
    public class Role {

        /**
         * Role Snowflake ID.
         */
        [JsonProperty("id")]
        public string id;

        /**
         * Role name.
         */
        [JsonProperty("name")]
        public string name;

        /**
         * Role color (hex).
         */
        [JsonProperty("color")]
        public int? color;

        /**
         * If Role is pinned in User listing.
         */
        [JsonProperty("hoist")]
        public bool? hoist;

        /**
         * Role position.
         */
        [JsonProperty("position")]
        public int? position;

        /**
         * Role Permission bit set.
         */
        [JsonProperty("permissions")]
        public int? permissions;

        /**
         * Is Role managed by Integration.
         */
        [JsonProperty("managed")]
        public bool? managed;

        /**
         * Is Role mentionable in Messages.
         */
        [JsonProperty("mentionable")]
        public bool? mentionable;
    }
}
