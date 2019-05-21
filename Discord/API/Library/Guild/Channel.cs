using System;
using Newtonsoft.Json;

namespace Discord.API.Library {

    public class Channel {

        /**
         * Channel Snowflake ID.
         */
        [JsonProperty("id")]
        public string id;

        /**
         * Channel type.
         */
        [JsonProperty("type")]
        public int? type;

        /**
         * Guild Snowflake ID.
         */
        [JsonProperty("guild_id")]
        public string guildId;

        /**
         * Sorting position of Channel.
         */
        [JsonProperty("position")]
        public int? position;

        /**
         * List of Role Overwrites.
         */
        [JsonProperty("permission_overwrites")]
        public RoleOverwrite[] permissionOverwrites;

        /**
         * Channel name.
         */
        [JsonProperty("name")]
        public string name;

        /**
         * Channel topic.
         */
        [JsonProperty("topic")]
        public string topic;

        /**
         * NSFW flag.
         */
        [JsonProperty("nsfw")]
        public bool? nsfw;

        /**
         * Last Message Snowflake ID.
         */
        [JsonProperty("last_message_id")]
        public string lastMessageId;

        /**
         * Bitrate in bits for Voice Channel.
         */
        [JsonProperty("bitrate")]
        public int? bitrate;

        /**
         * User limit for Voice Channel.
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
         * Recipient Users of a DM
         */
        [JsonProperty("recipients")]
        public User[] recipients;

        /**
         * Icon hash
         */
        [JsonProperty("icon")]
        public string icon;

        /**
         * Snowflake ID of owner
         */
        [JsonProperty("owner_id")]
        public string ownerId;

        /**
         * Snowflake ID of DM creator (Bot)
         */
        [JsonProperty("application_id")]
        public string applicationId;

        /**
         * Snowflake ID of parent category
         */
        [JsonProperty("parent_id")]
        public string parentId;

        /**
         * Timestamp of last pinned Message
         */
        [JsonProperty("last_pin_timestamp")]
        public string lastPinTimestamp;
    }

    enum ChannelType {
        GUILD_TEXT = 0,
        DM = 1,
        GUILD_VOICE = 2,
        GROUP_DM = 3,
        GUILD_CATEGORY = 4,
        GUILD_NEWS = 5,
        GUILD_STORE = 6
    }
}
