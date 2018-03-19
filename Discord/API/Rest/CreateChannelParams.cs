using Newtonsoft.Json;
using System;

namespace Discord.API.Rest {

    public class CreateChannelParams {

        [JsonProperty("name")]
        public string name;

        [JsonProperty("type")]
        public Int32 type;

        [JsonProperty("bitrate")]
        public Int32 bitrate;

        [JsonProperty("user_limit")]
        public Int32 userLimit;

        [JsonProperty("permission_overwrites")]
        public RoleOverwrite[] permissionOverwrites;

        [JsonProperty("parent_id")]
        public string parentId;

        [JsonProperty("nsfw")]
        public Boolean nsfw;
    }
}
