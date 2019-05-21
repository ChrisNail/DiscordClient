using System;
using Newtonsoft.Json;

namespace Discord.API.Library {

    public class UserConnection {

        /**
         * User Connection Snowflake ID.
         */
        [JsonProperty("id")]
        public string id;

        /**
         * User Connection Username.
         */
        [JsonProperty("name")]
        public string name;

        /**
         * Service type.
         */
        [JsonProperty("type")]
        public string type;

        /**
         * Is Connection revoked.
         */
        [JsonProperty("revoked")]
        public bool? revoked;

        /**
         * List of partial Integrations.
         */
        [JsonProperty("integrations")]
        public GuildIntegration[] integrations;

        /**
         * Is Connection verified.
         */
        [JsonProperty("verified")]
        public bool? verified;

        /**
         * Is friend sync enabled for Connection.
         */
        [JsonProperty("friend_sync")]
        public bool? friendSync;

        /**
         * Activities related to this Connection will be shown in PresenceUpdates.
         */
        [JsonProperty("show_activity")]
        public bool? showActivity;

        /**
         * Visibility of this Connection.
         */
        [JsonProperty("visibility")]
        public int? visibility;
    }

    enum ConnectionVisibility {
        NONE = 0,
        EVERYONE = 1
    }
}
