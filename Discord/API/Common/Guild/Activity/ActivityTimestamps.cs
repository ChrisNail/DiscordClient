using Newtonsoft.Json;
using System;

namespace Discord.API {

    [JsonObject("timestamps")]
    public class ActivityTimestamps {

        [JsonProperty("start")]
        public Int32 start;

        [JsonProperty("end")]
        public Int32 end;
    }
}
