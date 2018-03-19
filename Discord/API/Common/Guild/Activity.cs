using Newtonsoft.Json;
using System;

namespace Discord.API {

    [JsonObject("activity")]
    public class Activity {


        [JsonProperty("name")]
        public string name;


        [JsonProperty("type")]
        public Int32 type;


        [JsonProperty("url")]
        public string url;

        [JsonProperty("timestamps")]
        public ActivityTimestamps timestamps;

        [JsonProperty("application_id")]
        public string applicationId;

        [JsonProperty("details")]
        public string details;

        [JsonProperty("state")]
        public string state;

        [JsonProperty("party")]
        public ActivityParty party;

        [JsonProperty("assets")]
        public ActivityAssets assets;
    }

    class ActivityType {
        public static readonly int GAME = 0;
        public static readonly int STREAMING = 1;
        public static readonly int LISTENING = 2;
    }
}
