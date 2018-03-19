using Newtonsoft.Json;
using System;

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
        public Boolean requireColons;

        [JsonProperty("managed")]
        public Boolean managed;

        [JsonProperty("animated")]
        public Boolean animated;
    }
}
