using Newtonsoft.Json;
using System;

namespace Discord.API {

    [JsonObject("user")]
    public class User {

        [JsonProperty("id")]
        public string id;

        [JsonProperty("username")]
        public string username;

        [JsonProperty("discriminator")]
        public string discriminator;

        [JsonProperty("avatar")]
        public string avatar;

        [JsonProperty("bot")]
        public Boolean bot;

        [JsonProperty("mfa_enabled")]
        public Boolean mfaEnabled;

        [JsonProperty("verified")]
        public Boolean verified;

        [JsonProperty("email")]
        public string email;
    }
}
