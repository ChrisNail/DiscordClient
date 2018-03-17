using Newtonsoft.Json;

namespace Discord.API {

    public class EmbedField {

        [JsonProperty("name")]
        public string name;

        [JsonProperty("value")]
        public string value;

        [JsonProperty("inline")]
        public bool inline;
    }
}
