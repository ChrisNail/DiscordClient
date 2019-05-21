using System;
using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Message Activity (e.g. Game, Spotify).
     */
    public class MessageActivity {

        /**
         * Message Activity type.
         */
        [JsonProperty("type")]
        public int? type;

        /**
         * Party Snowflake ID from Rich Presence Event.
         */
        [JsonProperty("party_id")]
        public string partyId;
    }

    enum MessageActivityType {
        JOIN = 1,
        SPECTATE = 2,
        LISTEN = 3,
        JOIN_REQUEST = 5
    }
}
