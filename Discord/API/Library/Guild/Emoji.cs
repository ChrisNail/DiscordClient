using System;
using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Emoji object.
     * Used in Messages and for Reactions.
     */
    public class Emoji {

        /**
         * Emoji Snowflake ID.
         */
        [JsonProperty("id")]
        public string id;

        /**
         * Emoji name.
         */
        [JsonProperty("name")]
        public string name;

        /**
         * List of Roles that Emoji is whitelisted to.
         */
        [JsonProperty("roles")]
        public Role[] roles;

        /**
         * User that created this Emoji.
         */
        [JsonProperty("user")]
        public User user;

        /**
         * Should Emoji be wrapped in colons.
         */
        [JsonProperty("require_colons")]
        public bool? requireColons;

        /**
         * Is Emoji managed.
         */
        [JsonProperty("managed")]
        public bool? managed;

        /**
         * Is Emoji animated.
         */
        [JsonProperty("animated")]
        public bool? animated;
    }
}
