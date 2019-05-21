using Newtonsoft.Json;
using Discord.API.Library;

namespace Discord.API.Rest {

    /**
     * Modify a Channel parameters
     */
    public class ModifyChannelParams {

        /**
         * Channel name.
         */
        [JsonProperty("name")]
        public string name;

        /**
         * Channel position in a Guild.
         */
        [JsonProperty("position")]
        public int? position;

        /**
         * Channel topic.
         */
        [JsonProperty("topic")]
        public string topic;

        /**
         * Whether Channel is NSFW
         */
        [JsonProperty("nsfw")]
        public bool? nsfw;

        /**
         * Amount of seconds a User must wait between sending messages.
         * Bots and Users with the "manage_messages" or "manage_channel" permissions are unaffected.
         */
        [JsonProperty("rate_limit_per_user")]
        public int? rateLimitPerUser;

        /**
         * Bitrate (in bits) of a Voice Channel.
         */
        [JsonProperty("bitrate")]
        public int? bitrate;

        /**
         * User limit of a Voice Channel.
         * 0 is no limit, 1 to 99 refers to a User limit.
         */
        [JsonProperty("user_limit")]
        public int? userLimit;

        /**
         * List of Channel permission overwrites.
         */
        [JsonProperty("permission_overwrites")]
        public RoleOverwrite[] permissionOverwrites;

        /**
         * ID of parent Category.
         */
        [JsonProperty("parent_id")]
        public string parentId;
    }
}
