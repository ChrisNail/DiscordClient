using Newtonsoft.Json;

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
        public bool deaf;

        [JsonProperty("mute")]
        public bool mute;

        [JsonProperty("self_deaf")]
        public bool selfDeaf;

        [JsonProperty("self_mute")]
        public bool selfMute;

        [JsonProperty("suppress")]
        public bool suppress;
    }
}
