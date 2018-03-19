using Newtonsoft.Json;
using System;

namespace Discord.API {

    public class InviteMetadata {

        [JsonProperty("inviter")]
        public User inviter;

        [JsonProperty("uses")]
        public Int32 uses;

        [JsonProperty("max_uses")]
        public Int32 maxUses;

        [JsonProperty("max_age")]
        public Int32 maxAge;

        [JsonProperty("temporary")]
        public Boolean temporary;

        [JsonProperty("created_at")]
        public Int32 createdAt;

        [JsonProperty("revoked")]
        public Boolean revoked;
    }
}
