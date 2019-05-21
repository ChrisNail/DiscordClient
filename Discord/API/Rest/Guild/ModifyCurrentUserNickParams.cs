using Newtonsoft.Json;

namespace Discord.API.Rest {

    /**
     * Parameters to modify the current User's nickname.
     */
    public class ModifyCurrentUserNickParams {

        /**
         * User nickname.
         */
        [JsonProperty("nick")]
        public string nickname;
    }
}
