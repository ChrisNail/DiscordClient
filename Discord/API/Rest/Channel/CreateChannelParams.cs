using System;
using Newtonsoft.Json;
using Discord.API.Library;

namespace Discord.API.Rest {

    public class CreateChannelParams {

        /**
         * Channel name.
         */
        [JsonProperty("name")]
        public string name;

        /**
         * Channel type from ChannelType
         */
        [JsonProperty("type")]
        public int? type;

        /**
         * Channel description.
         */
        [JsonProperty("topic")]
        public string topic;

        /**
         * Voice Channel bitrate (in bits).
         */
        [JsonProperty("bitrate")]
        public int? bitrate;

        /**
         * Voice Channel user limit.
         */
        [JsonProperty("user_limit")]
        public int? userLimit;

        /**
         * Seconds before another message can be sent.
         * Bots and Users with "manage_messages" or "manage_channel" are unaffected.
         */
        [JsonProperty("rate_limit_per_user")]
        public int? rateLimitPerUser;

        /**
         * Sorting position of Channel.
         */
        [JsonProperty("position")]
        public int? position;

        /**
         * Channel permission overwrites.
         */
        [JsonProperty("permission_overwrites")]
        public RoleOverwrite[] permissionOverwrites;

        /**
         * Parent Channel Snowflake ID.
         */
        [JsonProperty("parent_id")]
        public string parentId;

        /**
         * Whether Channel is NSFW.
         */
        [JsonProperty("nsfw")]
        public bool? nsfw;
    }
}
