using System;
using Newtonsoft.Json;

namespace Discord.API.Rest {

    /**
     * Parameters to add a User to a Guild.
     */
    public class AddGuildMemberParams {

        /**
         * An oath2 access token granted with the guilds.join 
         * to the bot's application for the user you want to add to the guild.
         */
        [JsonProperty("access_token")]
        public string accessToken;

        /**
         * User nickname.
         */
        [JsonProperty("nick")]
        public string nickname;

        /**
         * Array of Role Snowflake IDs the member is assigned.
         */
        [JsonProperty("roles")]
        public string[] roles;

        /**
         * Whether the User is muted in voice channels.
         */
        [JsonProperty("mute")]
        public bool? mute;

        /**
         * Whether the User is deafened in voice Channels.
         */
        [JsonProperty("deaf")]
        public bool? deaf;
    }
}
