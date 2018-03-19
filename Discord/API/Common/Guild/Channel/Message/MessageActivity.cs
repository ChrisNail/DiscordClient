using Newtonsoft.Json;
using System;

namespace Discord.API {

    [JsonObject("activity")]
    public class MessageActivity {

        [JsonProperty("type")]
        public Int32 type;

        [JsonProperty("party_id")]
        public string partyId;
    }

    enum MessageActivityType {
        JOIN = 1,
        SPECTATE = 2,
        LISTEN = 3,
        JOIN_REQUEST = 5
    }
}
