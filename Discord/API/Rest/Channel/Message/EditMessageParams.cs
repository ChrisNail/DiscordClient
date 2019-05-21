using Newtonsoft.Json;
using Discord.API.Library;

namespace Discord.API.Rest {

    /**
     * Edit a Message parameters
     */
    public class EditMessageParams {

        /**
         * Message content.
         */
        [JsonProperty("content")]
        public string content;

        /**
         * Embedded rich content.
         */
        [JsonProperty("embed")]
        public Embed embed;
    }
}
