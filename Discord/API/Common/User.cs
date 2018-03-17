using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Discord.API {

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
        public bool bot;

        [JsonProperty("mfa_enabled")]
        public bool mfaEnabled;

        [JsonProperty("verified")]
        public bool verified;

        [JsonProperty("email")]
        public string email;
    }
}
