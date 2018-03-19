using Newtonsoft.Json;
using System;

namespace Discord.API {

    [JsonObject("guild")]
    public class Guild {

        /*
         * Snowflake ID
         */
        [JsonProperty("id")]
        public string id;

        /*
         * Name
         */
        [JsonProperty("name")]
        public string name;

        /*
         * Icon hash
         */
        [JsonProperty("icon")]
        public string icon;

        /*
         * Splash hash
         */
        [JsonProperty("splash")]
        public string splash;

        /*
         * Current User is owner
         */
        [JsonProperty("owner")]
        public Boolean owner;

        /*
         * Snowflake ID of the owner
         */
        [JsonProperty("owner_id")]
        public string ownerId;

        /*
         * Current User permissions
         */
        [JsonProperty("permissions")]
        public Int32 permissions;

        /*
         * Voice region ID
         */
        [JsonProperty("region")]
        public string region;

        /*
         * Snowflake ID of AFK Channel
         */
        [JsonProperty("afk_channel_id")]
        public string afkChannelId;

        /*
         * AFK timeout in seconds
         */
        [JsonProperty("afk_timeout")]
        public Int32 afkTimeout;

        /*
         * Is Guild embeddable
         */
        [JsonProperty("embed_enabled")]
        public Boolean embedEnabled;

        /*
         * Snowflake ID of embedded channel
         */
        [JsonProperty("embed_channel_id")]
        public string embedChannelId;

        /*
         * Verification Level
         */
        [JsonProperty("verification_level")]
        public Int32 verificationLevel;

        /*
         * Default Message notifications level
         */
        [JsonProperty("default_message_notifications")]
        public Int32 defaultMessageNotifications;

        /*
         * Explicit content filter level
         */
        [JsonProperty("explicit_content_filter")]
        public Int32 explicitContentFilter;

        /*
         * List of Roles
         */
        [JsonProperty("roles")]
        public Role[] roles;

        /*
         * List of Custom Emojis
         */
        [JsonProperty("emojis")]
        public Emoji[] emojis;

        /*
         * List of enabled features
         */
        [JsonProperty("features")]
        public string[] features;

        /*
         * Required MFA level
         */
        [JsonProperty("mfa_level")]
        public Int32 mfaLevel;

        /*
         * Snowflake ID of Guild creator (Bot)
         */
        [JsonProperty("application_id")]
        public string applicationId;

        /*
         * Widget enabled
         */
        [JsonProperty("widget_enabled")]
        public Boolean widgetEnabled;

        /*
         * Snowflake ID for Widget Channel
         */
        [JsonProperty("widget_channel_id")]
        public string widgetChannelId;

        /*
         * Snowflake ID for System Channel
         */
        [JsonProperty("system_channel_id")]
        public string systemChannelId;

        /*
         * Guild creation timestamp
         */
        [JsonProperty("joined_at")]
        public Int32 createDate;

        /*
         * Large Guild flag
         */
        [JsonProperty("large")]
        public Boolean large;

        /*
         * Guild unavailable flag
         */
        [JsonProperty("unavailable")]
        public Boolean unavailable;

        /*
         * Total Guild member count
         */
        [JsonProperty("member_count")]
        public Int32 memberCount;

        /*
         * List of Voice states
         */
        [JsonProperty("voice_states")]
        public VoiceState[] voiceStates;

        /*
         * List of Guild Members
         */
        [JsonProperty("members")]
        public GuildMember[] members;

        /*
         * List of Channels
         */
        [JsonProperty("channels")]
        public Channel[] channels;

        /*
         * List of Presence Updates on Guild Users
         */
        [JsonProperty("presences")]
        public PresenceUpdate[] presences;
    }

    enum DefaultMessageNotificationLevel {
        ALL_MESSAGES = 0,
        ONLY_MENTIONS = 1
    }

    enum ExplicitContentFilterLevel {
        DISABLED = 0,
        MEMBERS_WITHOUT_ROLES = 1,
        ALL_MEMBERS = 2
    }

    enum MFALevel {
        NONE = 0,
        ELEVATED = 1
    }

    enum VerificationLevel {
        NONE = 0,
        LOW = 1,
        MEDIUM = 2,
        HIGH = 3,
        VERY_HIGH = 4
    }
}
