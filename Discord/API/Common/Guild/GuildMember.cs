using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord.API {

    public class GuildMember {

        /*
         * User
         */
        [JsonProperty("user")]
        public User user;

        /*
         * Guild User nickname
         */
        [JsonProperty("nickname")]
        public string nickname;

        /*
         * List of Role IDs
         */
        [JsonProperty("roles")]
        public string[] roleIds;

        /*
         * Join date timestamp 
         */
        [JsonProperty("joined_at")]
        public Int32 joinDate;

        /*
         * Deaf flag
         */
        [JsonProperty("deaf")]
        public Boolean deaf;

        /*
         * Mute flag
         */
        [JsonProperty("mute")]
        public Boolean mute;
    }
}
