using System;
using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Field portion of an Embed.
     */
    public class EmbedField {

        /**
         * Field name.
         */
        [JsonProperty("name")]
        public string name;

        /**
         * Field value.
         */
        [JsonProperty("value")]
        public string value;

        /**
         * Should Field display inline.
         */
        [JsonProperty("inline")]
        public bool? inline;
    }
}
