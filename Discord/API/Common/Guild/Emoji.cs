using Newtonsoft.Json;

namespace Discord.API {

    public class Emoji {

        [JsonProperty("id")]
        public string id;

        [JsonProperty("name")]
        public string name;

        [JsonProperty("roles")]
        public Role[] roles;

        [JsonProperty("user")]
        public User user;

        [JsonProperty("require_colons")]
        public bool requireColons;

        [JsonProperty("managed")]
        public bool managed;

        [JsonProperty("animated")]
        public bool animated;
    }
}
