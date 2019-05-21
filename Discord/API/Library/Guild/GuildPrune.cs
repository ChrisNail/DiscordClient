using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Count of Guild Members pruned during a prune operation.
     */
    public class GuildPrune {

        /**
         * Number of Guild Members pruned.
         */
        [JsonProperty("pruned")]
        public int? pruned;
    }
}
