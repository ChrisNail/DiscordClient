using System;
using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Message Attachment
     */
    public class Attachment {

        /**
         * Attachment Snowflake ID
         */
        [JsonProperty("id")]
        public string id;

        /**
         * Attachment filename.
         */
        [JsonProperty("filename")]
        public string filename;

        /**
         * Attachment file size (in bytes).
         */
        [JsonProperty("size")]
        public int? size;

        /**
         * Source URL.
         */
        [JsonProperty("url")]
        public string url;

        /**
         * Proxied URL.
         */
        [JsonProperty("proxy_url")]
        public string proxyUrl;

        /**
         * File height (if Image).
         */
        [JsonProperty("height")]
        public int? height;

        /**
         * File width (if Image).
         */
        [JsonProperty("width")]
        public int? width;
    }
}
