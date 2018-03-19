using Newtonsoft.Json;
using System;

namespace Discord.API {

    public class VoiceState {

        [JsonProperty("guild_id")]
        public string guildId;

        [JsonProperty("channel_id")]
        public string channelId;

        [JsonProperty("user_id")]
        public string userId;

        [JsonProperty("session_id")]
        public string sessionId;

        [JsonProperty("deaf")]
        public Boolean deaf;

        [JsonProperty("mute")]
        public Boolean mute;

        [JsonProperty("self_deaf")]
        public Boolean selfDeaf;

        [JsonProperty("self_mute")]
        public Boolean selfMute;

        [JsonProperty("suppress")]
        public Boolean suppress;
    }
}
