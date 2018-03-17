using Newtonsoft.Json;

namespace Discord.API {

    public class EmbedVideo {

        [JsonProperty("url")]
        public string url;

        [JsonProperty("height")]
        public int height;

        [JsonProperty("width")]
        public int width;
    }
}
