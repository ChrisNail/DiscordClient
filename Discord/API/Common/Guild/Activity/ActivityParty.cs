using Newtonsoft.Json;
using System;

namespace Discord.API {

    [JsonObject("party")]
    public class ActivityParty {

        [JsonProperty("id")]
        public string id;

        [JsonProperty("size")]
        public Int32[] size;
    }
}
