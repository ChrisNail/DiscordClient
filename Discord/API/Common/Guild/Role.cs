using Newtonsoft.Json;
using System;

namespace Discord.API {

    public class Role {

        [JsonProperty("id")]
        public string id;

        [JsonProperty("name")]
        public string name;

        [JsonProperty("color")]
        public Int32 color;

        [JsonProperty("hoist")]
        public Boolean hoist;

        [JsonProperty("position")]
        public Int32 position;

        [JsonProperty("permissions")]
        public Int32 permissions;

        [JsonProperty("managed")]
        public Boolean managed;

        [JsonProperty("mentionable")]
        public Boolean mentionable;
    }
}
