using Newtonsoft.Json;
using System;

namespace Discord.API {

    [JsonObject("permission_overwrite")]
    public class RoleOverwrite {

        [JsonProperty("id")]
        public string id;

        [JsonProperty("type")]
        public string type;

        [JsonProperty("allow")]
        public Int32 allow;

        [JsonProperty("deny")]
        public Int32 deny;
    }
}
