using Newtonsoft.Json;
using System;

namespace Discord.API {

    [JsonObject("video")]
    public class EmbedVideo {

        [JsonProperty("url")]
        public string url;

        [JsonProperty("height")]
        public Int32 height;

        [JsonProperty("width")]
        public Int32 width;
    }
}
