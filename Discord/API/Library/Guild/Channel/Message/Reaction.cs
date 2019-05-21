using System;
using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Message Reaction.
     */
    public class Reaction {

        /**
         * Times this emoji has been used to react.
         */
        [JsonProperty("count")]
        public int? count;

        /**
         * If current User has reacted with this emoji.
         */
        [JsonProperty("me")]
        public bool? me;

        /**
         * Emoji object.
         */
        [JsonProperty("emoji")]
        public Emoji emoji;
    }
}
