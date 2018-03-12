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
    }

    class ActivityType {
        public static readonly int GAME = 0;
        public static readonly int STREAMING = 1;
        public static readonly int LISTENING = 2;
    }
}
