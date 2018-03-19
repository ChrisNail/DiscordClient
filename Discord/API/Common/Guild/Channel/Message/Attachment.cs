using Newtonsoft.Json;
using System;

namespace Discord.API {

    [JsonObject("attachment")]
    public class Attachment {

        [JsonProperty("id")]
        public string id;

        [JsonProperty("filename")]
        public string filename;

        [JsonProperty("size")]
        public Int32 size;

        [JsonProperty("url")]
        public string url;

        [JsonProperty("proxy_url")]
        public string proxyUrl;

        [JsonProperty("height")]
        public Int32 height;

        [JsonProperty("width")]
        public Int32 width;
    }
}
