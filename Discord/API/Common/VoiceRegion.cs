using Newtonsoft.Json;
using System;

namespace Discord.API {

    [JsonObject("voice_region")]
    public class VoiceRegion {

        [JsonProperty("id")]
        public string id;

        [JsonProperty("name")]
        public string name;

        [JsonProperty("vip")]
        public Boolean vip;

        [JsonProperty("optimal")]
        public Boolean optimal;

        [JsonProperty("deprecated")]
        public Boolean deprecated;

        [JsonProperty("custom")]
        public Boolean custom;
    }
}
