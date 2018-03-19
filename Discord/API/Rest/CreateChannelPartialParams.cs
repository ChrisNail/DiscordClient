using Newtonsoft.Json;
using System;

namespace Discord.API.Rest {

    public class CreateChannelPartialParams {

        [JsonProperty("name")]
        public string name;

        [JsonProperty("type")]
        public Int32 type;
    }
}
