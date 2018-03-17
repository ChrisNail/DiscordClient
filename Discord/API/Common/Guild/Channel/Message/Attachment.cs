using Newtonsoft.Json;

namespace Discord.API {

    public class Attachment {

        [JsonProperty("id")]
        public string id;

        [JsonProperty("filename")]
        public string filename;

        [JsonProperty("size")]
        public int size;

        [JsonProperty("url")]
        public string url;

        [JsonProperty("proxy_url")]
        public string proxyUrl;

        [JsonProperty("height")]
        public int height;

        [JsonProperty("width")]
        public int width;
    }
}
