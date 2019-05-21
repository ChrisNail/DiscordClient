using System;
using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Guild Embed.
     */
    public class GuildEmbed {

        /**
         * Enabled
         */
        [JsonProperty("enabled")]
        public bool? enabled;

        /**
         * Snowflake Channel ID for embed Channel.
         */
        [JsonProperty("channel_id")]
        public string channelId;
    }
}
