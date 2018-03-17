using Newtonsoft.Json;

namespace Discord.API {

    public class InviteMetadata {

        [JsonProperty("inviter")]
        public User inviter;

        [JsonProperty("uses")]
        public int uses;

        [JsonProperty("max_uses")]
        public int maxUses;

        [JsonProperty("max_age")]
        public int maxAge;

        [JsonProperty("temporary")]
        public bool temporary;

        [JsonProperty("created_at")]
        public int createdAt;

        [JsonProperty("revoked")]
        public bool revoked;
    }
}
