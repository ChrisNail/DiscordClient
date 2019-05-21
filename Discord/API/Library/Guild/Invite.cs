using System;
using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Guild Invite
     */
    public class Invite {

        /**
         * Invite code.
         */
        [JsonProperty("code")]
        public string code;

        /**
         * Partial Guild object for invite.
         */
        [JsonProperty("guild")]
        public Guild guild;

        /**
         * Partial Channel object for invite.
         */
        [JsonProperty("channel")]
        public Channel channel;

        /**
         * Partial User object for invite.
         */
        [JsonProperty("target_user")]
        public User user;

        /**
         * Type of target User for invite.
         */
        [JsonProperty("target_user_type")]
        public int? targetUserType;

        /**
         * Approximate count of online members.
         * Only present when targetUser is set.
         */
        [JsonProperty("approximate_presence_count")]
        public int? approximatePresenceCount;

        /**
         * Approximate count of total members.
         */
        [JsonProperty("approximate_member_count")]
        public int? approximateMemberCount;
    }

    enum TargetUserType {
        STREAM = 1
    }
}
