using System;
using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * User Activity.
     */
    public class Activity {

        /**
         * Activity name.
         */
        [JsonProperty("name")]
        public string name;

        /**
         * Activity type
         */
        [JsonProperty("type")]
        public int? type;

        /**
         * Stream URL.
         */
        [JsonProperty("url")]
        public string url;

        /**
         * Timestamps for start and/or end of the game.
         */
        [JsonProperty("timestamps")]
        public ActivityTimestamps timestamps;

        /**
         * Application Snowflake ID
         */
        [JsonProperty("application_id")]
        public string applicationId;

        /**
         * Activity details.
         */
        [JsonProperty("details")]
        public string details;

        /**
         * User's current party status.
         */
        [JsonProperty("state")]
        public string state;

        /**
         * Current party of the player.
         */
        [JsonProperty("party")]
        public ActivityParty party;

        /**
         * Imges for presence and hover text.
         */
        [JsonProperty("assets")]
        public ActivityAssets assets;

        /**
         * Secrets for Rich Presence joining and spectating.
         */
        [JsonProperty("secrets")]
        public ActivitySecrets secrets;

        /**
         * Is Activity an instanced game session.
         */
        [JsonProperty("instance")]
        public bool? instance;

        /**
         * Activity Flags ORd together.
         */
        [JsonProperty("flags")]
        public int? flags;
    }

    enum ActivityType {
        GAME = 0, STREAMING = 1, LISTENING = 2
    }

    enum ActivityFlag {
        INSTANCE = 0, JOIN = 1, SPECTATE = 2, JOIN_REQUEST = 3, SYNC = 4, PLAY = 5
    }
}
