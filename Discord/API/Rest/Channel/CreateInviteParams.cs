using Newtonsoft.Json;

namespace Discord.API.Rest {

    /**
     * Create an instant Invite to a Guild Channel.
     */
    public class CreateInviteParams {

        /**
         * Duration of Invite in seconds before expiration.
         * 0 for never.
         * Default is 86400 (24 hours).
         */
        [JsonProperty("max_age")]
        public int? maxAge;

        /**
         * Max number of uses or 0 for unlimited.
         */
        [JsonProperty("max_uses")]
        public int? maxUses;

        /**
         * Whether this Invite only grants temporary membership.
         */
        [JsonProperty("temporary")]
        public bool? temporary;

        /**
         * If true, don't reuse a similar invite.
         * Useful for creating many unique one-time use invites.
         */
        [JsonProperty("unique")]
        public bool? unique;
    }
}
