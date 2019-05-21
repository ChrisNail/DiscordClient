using Newtonsoft.Json;
using System;

namespace Discord.API.Rest {

    public class CreateRoleParams {

        [JsonProperty("name")]
        public string name;

        [JsonProperty("color")]
        public int? color;

        [JsonProperty("hoist")]
        public bool? hoist;

        [JsonProperty("position")]
        public int? position;

        [JsonProperty("permissions")]
        public int? permissions;

        [JsonProperty("managed")]
        public bool? managed;

        [JsonProperty("mentionable")]
        public bool? mentionable;
    }
}
