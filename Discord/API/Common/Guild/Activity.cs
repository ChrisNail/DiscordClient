using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord.API {

    public class Activity {


        [JsonProperty("name")]
        public string name;


        [JsonProperty("type")]
        public int type;


        [JsonProperty("url")]
        public string url;

        [JsonProperty("timestamps")]
        public Timestamps timestamps;

        [JsonProperty("application_id")]
        public string applicationId;

        [JsonProperty("details")]
        public string details;

        [JsonProperty("state")]
        public string state;

        [JsonProperty("party")]
        public Party party;

        [JsonProperty("assets")]
        public Assets assets;
    }

    class ActivityType {
        public static readonly int GAME = 0;
        public static readonly int STREAMING = 1;
        public static readonly int LISTENING = 2;
    }
}
