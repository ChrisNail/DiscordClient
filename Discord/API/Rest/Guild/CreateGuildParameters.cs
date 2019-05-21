using Newtonsoft.Json;
using System;

namespace Discord.API.Rest {

    public class CreateGuildParameters {

        [JsonProperty("name")]
        public string name;

        [JsonProperty("region")]
        public string region;

        [JsonProperty("icon")]
        public string icon;

        [JsonProperty("verification_level")]
        public int? verificationLevel;

        [JsonProperty("default_message_notifications")]
        public int? defaultMessageNotifications;

        [JsonProperty("explicit_content_filter")]
        public int? explicitContentFilter;

        [JsonProperty("roles")]
        public CreateRoleParams[] roles;

        [JsonProperty("channels")]
        public CreateChannelParams[] channels;
    }
}
