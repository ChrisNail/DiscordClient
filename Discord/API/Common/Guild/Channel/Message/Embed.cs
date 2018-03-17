using Newtonsoft.Json;

namespace Discord.API {

    public class Embed {

        [JsonProperty("title")]
        public string title;

        [JsonProperty("type")]
        public string type;

        [JsonProperty("description")]
        public string description;

        [JsonProperty("url")]
        public string url;

        [JsonProperty("timestamp")]
        public int timestamp;

        [JsonProperty("color")]
        public int color;

        [JsonProperty("footer")]
        public EmbedFooter footer;

        [JsonProperty("image")]
        public EmbedImage image;

        [JsonProperty("thumbnail")]
        public EmbedThumbnail thumbnail;

        [JsonProperty("video")]
        public EmbedVideo video;

        [JsonProperty("provider")]
        public EmbedProvider provider;

        [JsonProperty("author")]
        public EmbedAuthor author;

        [JsonProperty("fields")]
        public EmbedField[] fields;
    }
}
