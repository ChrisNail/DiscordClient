using Newtonsoft.Json;
using Discord.API.Library;

namespace Discord.API.Rest {

    /**
     * Create Message parameters.
     */
    public class CreateMessageParams {

        /**
         * Message content.
         */
        [JsonProperty("content")]
        public string content;

        /**
         * A nonce that can be used for optimistic message sending.
         */
        [JsonProperty("nonce")]
        public string nonce;

        /**
         * True if this is a TTS Message.
         */
        [JsonProperty("tts")]
        public bool? tts;

        /**
         * Contents of the file being sent.
         */
        [JsonProperty("file")]
        public string file;

        /**
         * Embedded rich content.
         */
        [JsonProperty("embed")]
        public Embed embed;

        /**
         * JSON encoded body of any additional request fields.
         */
        [JsonProperty("payload_json")]
        public string payloadJson;
    }
}
