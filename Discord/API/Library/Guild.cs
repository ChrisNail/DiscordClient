using Newtonsoft.Json;
using System;

namespace Discord.API.Library {

    public class Guild {

        /**
         * Guild Snowflake ID.
         */
        [JsonProperty("id")]
        public string id;

        /**
         * Guild name.
         */
        [JsonProperty("name")]
        public string name;

        /**
         * Guild icon hash.
         */
        [JsonProperty("icon")]
        public string icon;

        /**
         * Guild splash hash.
         */
        [JsonProperty("splash")]
        public string splash;

        /**
         * True if current User is owner.
         */
        [JsonProperty("owner")]
        public bool? owner;

        /**
         * User Snowflake ID of the owner.
         */
        [JsonProperty("owner_id")]
        public string ownerId;

        /**
         * Current User permissions.
         */
        [JsonProperty("permissions")]
        public int? permissions;

        /**
         * Voice region ID.
         */
        [JsonProperty("region")]
        public string region;

        /**
         * Channel Snowflake ID of AFK Channel.
         */
        [JsonProperty("afk_channel_id")]
        public string afkChannelId;

        /**
         * AFK timeout in seconds.
         */
        [JsonProperty("afk_timeout")]
        public int? afkTimeout;

        /**
         * Is Guild embeddable (e.g. Widget).
         */
        [JsonProperty("embed_enabled")]
        public bool? embedEnabled;

        /**
         * Channel Snowflake ID that widget will generate an invite to.
         */
        [JsonProperty("embed_channel_id")]
        public string embedChannelId;

        /**
         * Verification Level required for Guild.
         */
        [JsonProperty("verification_level")]
        public int? verificationLevel;

        /**
         * Default Message notifications level.
         */
        [JsonProperty("default_message_notifications")]
        public int? defaultMessageNotifications;

        /**
         * Explicit content filter level.
         */
        [JsonProperty("explicit_content_filter")]
        public int? explicitContentFilter;

        /**
         * List of guild Roles.
         */
        [JsonProperty("roles")]
        public Role[] roles;

        /**
         * List of custom Emojis.
         */
        [JsonProperty("emojis")]
        public Emoji[] emojis;

        /**
         * List of enabled features.
         */
        [JsonProperty("features")]
        public string[] features;

        /**
         * Required MFA level.
         */
        [JsonProperty("mfa_level")]
        public int? mfaLevel;

        /**
         * Application Snowflake ID of Guild creator if bot-created.
         */
        [JsonProperty("application_id")]
        public string applicationId;

        /**
         * Is server Widget enabled.
         */
        [JsonProperty("widget_enabled")]
        public bool? widgetEnabled;

        /**
         * Channel Snowflake ID for server Widget.
         */
        [JsonProperty("widget_channel_id")]
        public string widgetChannelId;

        /**
         * Channel Snowflake ID for where system messages are sent.
         */
        [JsonProperty("system_channel_id")]
        public string systemChannelId;

        /**
         * Guild creation timestamp.
         */
        [JsonProperty("joined_at")]
        public int? createDate;

        /**
         * Whether Guild is considered large.
         */
        [JsonProperty("large")]
        public bool? large;

        /**
         * Guild unavailable flag.
         */
        [JsonProperty("unavailable")]
        public bool? unavailable;

        /**
         * Total Guild member count.
         */
        [JsonProperty("member_count")]
        public int? memberCount;

        /**
         * List of Voice states.
         */
        [JsonProperty("voice_states")]
        public VoiceState[] voiceStates;

        /**
         * List of Guild Members.
         */
        [JsonProperty("members")]
        public GuildMember[] members;

        /**
         * List of Channels.
         */
        [JsonProperty("channels")]
        public Channel[] channels;

        /**
         * List of Presence Updates on Guild Users.
         */
        [JsonProperty("presences")]
        public PresenceUpdate[] presences;

        /**
         * Max amount of presences for the Guild.
         * Default value, 5000, is in effect when null is returned.
         */
        [JsonProperty("max_presences")]
        public int? maxPresences;


        /**
         * Maximum amount of members for the Guild.
         */
        [JsonProperty("max_members")]
        public int? maxMembers;

        /**
         * Vanity URL code for the Guild.
         */
        [JsonProperty("vanity_url_code")]
        public string vanityUrlCode;

        /**
         * Guild description.
         */
        [JsonProperty("description")]
        public string description;

        /**
         * Guild banner hash.
         */
        [JsonProperty("banner")]
        public string banner;
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
        // Unrestricted.
        NONE = 0,
        // Verified email.
        LOW = 1,
        // Registered for no longer than 5 minutes.
        MEDIUM = 2,
        // Must be member of server for longer than 10 minutes.
        HIGH = 3,
        // Must have verified phone number.
        VERY_HIGH = 4
    }
}
