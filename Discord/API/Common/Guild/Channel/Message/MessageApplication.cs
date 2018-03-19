using Newtonsoft.Json;

namespace Discord.API {

    [JsonObject("application")]
    public class MessageApplication {

        [JsonProperty("id")]
        public string id;

        [JsonProperty("cover_image")]
        public string coverImage;

        [JsonProperty("description")]
        public string description;

        [JsonProperty("icon")]
        public string icon;

        [JsonProperty("name")]
        public string name;
    }
}
