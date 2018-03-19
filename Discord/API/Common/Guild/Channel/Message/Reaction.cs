using Newtonsoft.Json;
using System;

namespace Discord.API {

    [JsonObject("reaction")]
    public class Reaction {

        [JsonProperty("count")]
        public Int32 count;

        [JsonProperty("me")]
        public Boolean me;

        [JsonProperty("emoji")]
        public Emoji emoji;
    }
}
