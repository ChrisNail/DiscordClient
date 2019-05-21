using Newtonsoft.Json;
using System;

namespace Discord.API.Rest {

    public class ModifyGuildMemberParams {

        [JsonProperty("nick")]
        public string nickname;

        [JsonProperty("roles")]
        public string[] roles;

        [JsonProperty("mute")]
        public bool mute;

        [JsonProperty("deaf")]
        public bool deaf;

        [JsonProperty("channel_id")]
        public string channelId;
    }
}
