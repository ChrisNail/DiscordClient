using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord.API {

    public class Channel {

        /*
         * Snowflake ID
         */
        [JsonProperty("id")]
        public string id;

        /*
         * Channel Type
         */
        [JsonProperty("type")]
        public int type;

        /*
         * Snowflake ID of the Guild
         */
        [JsonProperty("guild_id")]
        public string guildId;

        /*
         * Sorting position
         */
        [JsonProperty("position")]
        public int position;

        /*
         * List of Role Overwrites
         */
        //[JsonProperty("permission_overwrites")]
        //public List<RoleOverwrite> permissionOverwrites;

        /*
         * Name
         */
        [JsonProperty("name")]
        public string name;

        /*
         * Topic
         */
        [JsonProperty("topic")]
        public string topic;

        /*
         * NSFW flag
         */
        [JsonProperty("nsfw")]
        public bool nsfw;

        /*
         * Snowflake ID of last Message
         */
        [JsonProperty("last_message_id")]
        public string lastMessageId;

        /*
         * Bitrate in bits (Voice Channel)
         */
        [JsonProperty("bitrate")]
        public int bitrate;

        /*
         * User limit (Voice Channel)
         */
        [JsonProperty("user_limit")]
        public int userLimit;

        /*
         * Recipient Users of a DM
         */
        [JsonProperty("recipients")]
        public List<User> recipients;

        /*
         * Icon hash
         */
        [JsonProperty("icon")]
        public string icon;

        /*
         * Snowflake ID of owner
         */
        [JsonProperty("owner_id")]
        public string ownerId;

        /*
         * Snowflake ID of DM creator (Bot)
         */
        [JsonProperty("application_id")]
        public string applicationId;

        /*
         * Snowflake ID of parent category
         */
        [JsonProperty("parent_id")]
        public string parentId;

        /*
         * Timestamp of last pinned Message
         */
        [JsonProperty("last_pin_timestamp")]
        public int lastPinTimestamp;
    }

    class ChannelType {

        public readonly int GUILD_TEXT = 0;

        public readonly int DM = 1;

        public readonly int GUILD_VOICE = 2;

        public readonly int GROUP_DM = 3;

        public readonly int GUILD_CATEGORY = 4;
    }
}
