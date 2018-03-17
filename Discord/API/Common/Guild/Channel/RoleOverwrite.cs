using Newtonsoft.Json;

namespace Discord.API {

    public class RoleOverwrite {

        [JsonProperty("id")]
        public string id;

        [JsonProperty("type")]
        public string type;

        [JsonProperty("allow")]
        public int allow;

        [JsonProperty("deny")]
        public int deny;
    }
}
