using System;
using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Party for an Activity.
     */
    public class ActivityParty {

        /**
         * Activity Party Snowflake ID.
         */
        [JsonProperty("id")]
        public string id;

        /**
         * Party's maxmimum and current size.
         */
        [JsonProperty("size")]
        public int?[] size;
    }
}
