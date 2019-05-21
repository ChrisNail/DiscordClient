using Newtonsoft.Json;
using System;

namespace Discord.API.Library {

    public class GuildMember {

        /**
         * User object.
         */
        [JsonProperty("user")]
        public User user;

        /**
         * Guild User nickname.
         */
        [JsonProperty("nick")]
        public string nickname;

        /**
         * List of Role Snowflake IDs
         */
        [JsonProperty("roles")]
        public string[] roleIds;

        /**
         * Join date timestamp 
         */
        [JsonProperty("joined_at")]
        public int? joinDate;

        /**
         * Deaf flag
         */
        [JsonProperty("deaf")]
        public bool? deaf;

        /**
         * Mute flag
         */
        [JsonProperty("mute")]
        public bool? mute;
    }
}
