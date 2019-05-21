using System;
using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Timestamps for an Activity.
     */
    public class ActivityTimestamps {

        /**
         * Start time (unix time in milliseconds).
         */
        [JsonProperty("start")]
        public int? start;

        /**
         * End time (unix time in milliseconds).
         */
        [JsonProperty("end")]
        public int? end;
    }
}
