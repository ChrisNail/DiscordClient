using Newtonsoft.Json;

namespace Discord.API {

    public class MessageActivity {

        [JsonProperty("type")]
        public int type;

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
