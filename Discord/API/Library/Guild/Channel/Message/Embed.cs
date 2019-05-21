using System;
using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Message Embed.
     */
    public class Embed {

        /**
         * Embed title.
         */
        [JsonProperty("title")]
        public string title;

        /**
         * Embed type.
         * Always "rich" for webhook embeds.
         */
        [JsonProperty("type")]
        public string type;

        /**
         * Embed description.
         */
        [JsonProperty("description")]
        public string description;

        /**
         * Embed URL.
         */
        [JsonProperty("url")]
        public string url;

        /**
         * Embed Timestamp.
         */
        [JsonProperty("timestamp")]
        public int? timestamp;

        /**
         * Color of Embed.
         */
        [JsonProperty("color")]
        public int? color;

        /**
         * Footer information object.
         */
        [JsonProperty("footer")]
        public EmbedFooter footer;

        /**
         * Image information object.
         */
        [JsonProperty("image")]
        public EmbedImage image;

        /**
         * Thumnail information object.
         */
        [JsonProperty("thumbnail")]
        public EmbedThumbnail thumbnail;

        /**
         * Video information object.
         */
        [JsonProperty("video")]
        public EmbedVideo video;

        /**
         * Provider information object.
         */
        [JsonProperty("provider")]
        public EmbedProvider provider;

        /**
         * Author information object.
         */
        [JsonProperty("author")]
        public EmbedAuthor author;

        /**
         * List of Field information objects.
         */
        [JsonProperty("fields")]
        public EmbedField[] fields;
    }
}
