using Newtonsoft.Json;

namespace Discord.API {
    public class VoiceRegion {

        [JsonProperty("id")]
        public string id;

        [JsonProperty("name")]
        public string name;

        [JsonProperty("vip")]
        public bool vip;

        [JsonProperty("optimal")]
        public bool optimal;

        [JsonProperty("deprecated")]
        public bool deprecated;

        [JsonProperty("custom")]
        public bool custom;
    }
}
