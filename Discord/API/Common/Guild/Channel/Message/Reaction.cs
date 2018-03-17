using Newtonsoft.Json;

namespace Discord.API {

    public class Reaction {

        [JsonProperty("count")]
        public int count;

        [JsonProperty("me")]
        public bool me;

        [JsonProperty("emoji")]
        public Emoji emoji;
    }
}
