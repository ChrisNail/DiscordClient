using System;
using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Guild Invite metadata.
     */
    public class InviteMetadata {

        /**
         * User who created Invite.
         */
        [JsonProperty("inviter")]
        public User inviter;

        /**
         * Number of times Invite has been used.
         */
        [JsonProperty("uses")]
        public int? uses;

        /**
         * Max number of times Invite can be used.
         */
        [JsonProperty("max_uses")]
        public int? maxUses;

        /**
         * Duration (in seconds) after which Invite expires.
         */
        [JsonProperty("max_age")]
        public int? maxAge;

        /**
         * Invite grants temporary membership.
         */
        [JsonProperty("temporary")]
        public bool? temporary;

        /**
         * When Invite was created.
         */
        [JsonProperty("created_at")]
        public int? createdAt;

        /**
         * Is Invite revoked.
         */
        [JsonProperty("revoked")]
        public bool? revoked;
    }
}
