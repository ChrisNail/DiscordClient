using Newtonsoft.Json;
using System;

namespace Discord.API.Rest {

    public class ModifyChannelPositionParams {

        [JsonProperty("id")]
        public string id;

        [JsonProperty("position")]
        public int? position;
    }
}
