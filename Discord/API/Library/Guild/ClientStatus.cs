using Newtonsoft.Json;

namespace Discord.API.Library {

    public class ClientStatus {

        /**
         * User's status for an desktop session.
         */
        [JsonProperty("desktop")]
        public string desktop;

        /**
         * User's status for an mobile session.
         */
        [JsonProperty("mobile")]
        public string mobile;

        /**
         * User's status for an web session.
         */
        [JsonProperty("web")]
        public string web;
    }
}
