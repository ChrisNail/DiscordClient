using Newtonsoft.Json;

namespace Discord.API {

    [JsonObject("field")]
    public class EmbedField {

        [JsonProperty("name")]
        public string name;

        [JsonProperty("value")]
        public string value;

        [JsonProperty("inline")]
        public Boolean inline;
    }
}
