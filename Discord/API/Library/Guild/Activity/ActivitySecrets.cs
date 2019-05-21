using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Secret IDs for an Activity.
     */
    public class ActivitySecrets {

        /**
         * Secret for joining a party.
         */
        [JsonProperty("join")]
        public string join;

        /**
         * Secret for spectating a game.
         */
        [JsonProperty("spectate")]
        public string spectate;

        /**
         * Secret for a specific instanced match.
         */
        [JsonProperty("match")]
        public string match;
    }
}
