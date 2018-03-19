using Newtonsoft.Json;

namespace Discord.API {

    [JsonObject("assets")]
    public class ActivityAssets {

        [JsonProperty("large_image")]
        public string largeImage;

        [JsonProperty("large_text")]
        public string largeText;

        [JsonProperty("small_image")]
        public string smallImage;

        [JsonProperty("small_text")]
        public string smallText;
    }
}
