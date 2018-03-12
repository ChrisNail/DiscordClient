using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord {

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
        public int joinDate;

        /*
         * Deaf flag
         */
        [JsonProperty("deaf")]
        public bool deaf;

        /*
         * Mute flag
         */
        [JsonProperty("mute")]
        public bool mute;

        
        public GuildMember() {

        }
    }
}
